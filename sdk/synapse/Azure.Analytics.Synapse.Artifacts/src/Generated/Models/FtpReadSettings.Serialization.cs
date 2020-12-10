// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class FtpReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive");
                writer.WriteObjectValue(Recursive);
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath");
                writer.WriteObjectValue(WildcardFolderPath);
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName");
                writer.WriteObjectValue(WildcardFileName);
            }
            if (Optional.IsDefined(UseBinaryTransfer))
            {
                writer.WritePropertyName("useBinaryTransfer");
                writer.WriteBooleanValue(UseBinaryTransfer.Value);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static FtpReadSettings DeserializeFtpReadSettings(JsonElement element)
        {
            Optional<object> recursive = default;
            Optional<object> wildcardFolderPath = default;
            Optional<object> wildcardFileName = default;
            Optional<bool> useBinaryTransfer = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recursive = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wildcardFolderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFileName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wildcardFileName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("useBinaryTransfer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useBinaryTransfer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FtpReadSettings(type, maxConcurrentConnections.Value, additionalProperties, recursive.Value, wildcardFolderPath.Value, wildcardFileName.Value, Optional.ToNullable(useBinaryTransfer));
        }
    }
}
