// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> Virtual Network rule. </summary>
    public partial class VirtualNetworkRule
    {
        /// <summary> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </summary>
        public string VirtualNetworkResourceId { get; set; }
        /// <summary> The action of virtual network rule. </summary>
        public string Action { get; set; } = "Allow";
        /// <summary> Gets the state of virtual network rule. </summary>
        public State? State { get; set; }
    }
}
