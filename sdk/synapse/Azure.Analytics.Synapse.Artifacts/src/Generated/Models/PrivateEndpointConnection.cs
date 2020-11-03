// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The PrivateEndpointConnection. </summary>
    public partial class PrivateEndpointConnection : Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        public PrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="privateEndpoint"> Private Endpoint. </param>
        /// <param name="privateLinkServiceConnectionState"> Private Link Service Connection State. </param>
        internal PrivateEndpointConnection(string id, string name, string type, string provisioningState, PrivateEndpoint privateEndpoint, PrivateLinkServiceConnectionState privateLinkServiceConnectionState) : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        }

        /// <summary> Provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Private Endpoint. </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> Private Link Service Connection State. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}
