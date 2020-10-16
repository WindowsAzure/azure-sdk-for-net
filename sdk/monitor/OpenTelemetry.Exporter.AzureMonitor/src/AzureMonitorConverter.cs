﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

using OpenTelemetry.Exporter.AzureMonitor.Models;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace OpenTelemetry.Exporter.AzureMonitor
{
    /// <summary>
    /// This class is responsible for converting an OpenTelemetry <see cref="Batch{T}"/> of <see cref="Activity"/>
    /// into a collection of <see cref="TelemetryItem"/> for Azure Monitor.
    /// </summary>
    internal static class AzureMonitorConverter
    {
        private const int Version2 = 2; // The ingestion schema version
        private static readonly IReadOnlyDictionary<TelemetryType, string> Telemetry_Base_Type_Mapping = new Dictionary<TelemetryType, string>
        {
            [TelemetryType.Request] = "RequestData",
            [TelemetryType.Dependency] = "RemoteDependencyData",
            [TelemetryType.Message] = "MessageData",
            [TelemetryType.Event] = "EventData",
        };

        private static readonly IReadOnlyDictionary<TelemetryType, string> PartA_Name_Mapping = new Dictionary<TelemetryType, string>
        {
            [TelemetryType.Request] = "Request",
            [TelemetryType.Dependency] = "RemoteDependency",
            [TelemetryType.Message] = "Message",
            [TelemetryType.Event] = "Event",
        };

        public static List<TelemetryItem> Convert(Batch<Activity> batchActivity, string instrumentationKey)
        {
            List<TelemetryItem> telemetryItems = new List<TelemetryItem>();
            TelemetryItem telemetryItem;

            foreach (var activity in batchActivity)
            {
                telemetryItem = GeneratePartAEnvelope(activity);
                telemetryItem.InstrumentationKey = instrumentationKey;
                telemetryItem.Data = GenerateTelemetryData(activity);
                telemetryItems.Add(telemetryItem);
            }

            return telemetryItems;
        }

        private static TelemetryItem GeneratePartAEnvelope(Activity activity)
        {
            TelemetryItem telemetryItem = new TelemetryItem(PartA_Name_Mapping[activity.GetTelemetryType()], activity.StartTimeUtc.ToString(CultureInfo.InvariantCulture));
            ExtractRoleInfo(activity.GetResource(), out var roleName, out var roleInstance);
            telemetryItem.Tags[ContextTagKeys.AiCloudRole.ToString()] = roleName;
            telemetryItem.Tags[ContextTagKeys.AiCloudRoleInstance.ToString()] = roleInstance;
            telemetryItem.Tags[ContextTagKeys.AiOperationId.ToString()] = activity.TraceId.ToHexString();
            if (activity.Parent != null)
            {
                telemetryItem.Tags[ContextTagKeys.AiOperationParentId.ToString()] = activity.Parent.SpanId.ToHexString();
            }
            // TODO: Handle exception
            telemetryItem.Tags[ContextTagKeys.AiInternalSdkVersion.ToString()] = SdkVersionUtils.SdkVersion;

            return telemetryItem;
        }

        internal static void ExtractRoleInfo(Resource resource, out string roleName, out string roleInstance)
        {
            if (resource == null)
            {
                roleName = null;
                roleInstance = null;
                return;
            }

            string serviceName = null;
            string serviceNamespace = null;
            roleInstance = null;

            foreach (var attribute in resource.Attributes)
            {
                if (attribute.Key == Resource.ServiceNameKey && attribute.Value is string)
                {
                    serviceName = attribute.Value.ToString();
                }
                else if (attribute.Key == Resource.ServiceNamespaceKey && attribute.Value is string)
                {
                    serviceNamespace = attribute.Value.ToString();
                }
                else if (attribute.Key == Resource.ServiceInstanceIdKey && attribute.Value is string)
                {
                    roleInstance = attribute.Value.ToString();
                }
            }

            if (serviceName != null && serviceNamespace != null)
            {
                roleName = string.Concat(serviceNamespace, ".", serviceName);
            }
            else
            {
                roleName = serviceName;
            }
        }

        private static MonitorBase GenerateTelemetryData(Activity activity)
        {
            var telemetryType = activity.GetTelemetryType();
            var activityType = activity.TagObjects.ToAzureMonitorTags(out var partBTags, out var PartCTags);
            MonitorBase telemetry = new MonitorBase
            {
                BaseType = Telemetry_Base_Type_Mapping[telemetryType]
            };

            if (telemetryType == TelemetryType.Request)
            {
                string source = null;
                string statusCode = string.Empty;
                string url = null;
                bool success = true;

                switch (activityType)
                {
                    case PartBType.Http:
                        url = activity.Kind == ActivityKind.Server ? UrlHelper.GetUrl(partBTags) : AzureMonitorConverter.GetMessagingUrl(partBTags);
                        statusCode = GetHttpStatusCode(partBTags);
                        success = GetSuccessFromHttpStatusCode(statusCode);
                        break;
                    case PartBType.Azure:
                        ComponentHelper.ExtractComponentProperties(partBTags, activity.Kind, out _, out source);
                        break;
                }

                RequestData request = new RequestData(Version2, activity.Context.SpanId.ToHexString(), activity.Duration.ToString("c", CultureInfo.InvariantCulture), success, statusCode)
                {
                    Name = activity.DisplayName,
                    Url = url,
                    Source = source
                };

                AddPropertiesToTelemetry(request.Properties, PartCTags);
                telemetry.BaseData = request;
            }
            else if (telemetryType == TelemetryType.Dependency)
            {
                var dependency = new RemoteDependencyData(Version2, activity.DisplayName, activity.Duration.ToString("c", CultureInfo.InvariantCulture))
                {
                    Id = activity.Context.SpanId.ToHexString()
                };

                switch (activityType)
                {
                    case PartBType.Http:
                        dependency.Data = UrlHelper.GetUrl(partBTags);
                        dependency.Target = GetHost(partBTags);
                        dependency.Type = RemoteDependencyConstants.HTTP;
                        var statusCode = GetHttpStatusCode(partBTags);
                        dependency.ResultCode = statusCode;
                        dependency.Success = GetSuccessFromHttpStatusCode(statusCode);
                        break;
                    case PartBType.Azure:
                        ComponentHelper.ExtractComponentProperties(partBTags, activity.Kind, out var type, out var target);
                        dependency.Target = target;
                        dependency.Type = type;
                        break;
                }

                AddPropertiesToTelemetry(dependency.Properties, PartCTags);
                telemetry.BaseData = dependency;
            }

            return telemetry;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetHttpStatusCode(Dictionary<string, string> tags)
        {
            if (tags.TryGetValue(SemanticConventions.AttributeHttpStatusCode, out var status))
            {
                return status;
            }

            return "0";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool GetSuccessFromHttpStatusCode(string statusCode)
        {
            return statusCode == "200" || statusCode == "Ok";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static string GetHost(Dictionary<string, string> tags)
        {
            if (tags != null && tags.TryGetValue(SemanticConventions.AttributeHttpHost, out var host))
            {
                return host;
            }

            return null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static string GetMessagingUrl(Dictionary<string, string> tags)
        {
            if (tags != null && tags.TryGetValue(SemanticConventions.AttributeMessagingUrl, out var url))
            {
                return url;
            }

            return null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void AddPropertiesToTelemetry(IDictionary<string, string> destination, IEnumerable<KeyValuePair<string, string>> PartCTags)
        {
            // TODO: Iterate only interested fields. Ref: https://github.com/Azure/azure-sdk-for-net/pull/14254#discussion_r470907560
            foreach (var tag in PartCTags)
            {
                destination.Add(tag);
            }
        }
    }
}
