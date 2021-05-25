// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Resources.ResourceWriteFailure event. This is raised when a resource create or update operation fails. </summary>
    public partial class ResourceWriteFailureEventData
    {
        /// <summary> Initializes a new instance of ResourceWriteFailureEventData. </summary>
        internal ResourceWriteFailureEventData()
        {
        }

        /// <summary> Initializes a new instance of ResourceWriteFailureEventData. </summary>
        /// <param name="tenantId"> The tenant ID of the resource. </param>
        /// <param name="subscriptionId"> The subscription ID of the resource. </param>
        /// <param name="resourceGroup"> The resource group of the resource. </param>
        /// <param name="resourceProvider"> The resource provider performing the operation. </param>
        /// <param name="resourceUri"> The URI of the resource in the operation. </param>
        /// <param name="operationName"> The operation that was performed. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="authorization"> The requested authorization for the operation. </param>
        /// <param name="claims"> The properties of the claims. </param>
        /// <param name="correlationId"> An operation ID used for troubleshooting. </param>
        /// <param name="httpRequest"> The details of the operation. </param>
        internal ResourceWriteFailureEventData(string tenantId, string subscriptionId, string resourceGroup, string resourceProvider, string resourceUri, string operationName, string status, string authorization, string claims, string correlationId, string httpRequest)
        {
            TenantId = tenantId;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            ResourceProvider = resourceProvider;
            ResourceUri = resourceUri;
            OperationName = operationName;
            Status = status;
            Authorization = authorization;
            Claims = claims;
            CorrelationId = correlationId;
            HttpRequest = httpRequest;
        }

        /// <summary> The tenant ID of the resource. </summary>
        public string TenantId { get; }
        /// <summary> The subscription ID of the resource. </summary>
        public string SubscriptionId { get; }
        /// <summary> The resource group of the resource. </summary>
        public string ResourceGroup { get; }
        /// <summary> The resource provider performing the operation. </summary>
        public string ResourceProvider { get; }
        /// <summary> The URI of the resource in the operation. </summary>
        public string ResourceUri { get; }
        /// <summary> The operation that was performed. </summary>
        public string OperationName { get; }
        /// <summary> The status of the operation. </summary>
        public string Status { get; }
        /// <summary> The requested authorization for the operation. </summary>
        public string Authorization { get; }
        /// <summary> The properties of the claims. </summary>
        public string Claims { get; }
        /// <summary> An operation ID used for troubleshooting. </summary>
        public string CorrelationId { get; }
        /// <summary> The details of the operation. </summary>
        public string HttpRequest { get; }
    }
}
