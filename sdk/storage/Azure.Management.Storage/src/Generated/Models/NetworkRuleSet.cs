// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> Network rule set. </summary>
    public partial class NetworkRuleSet
    {
        /// <summary> Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, &quot;Logging, Metrics&quot;), or None to bypass none of those traffics. </summary>
        public Bypass? Bypass { get; set; }
        /// <summary> Sets the virtual network rules. </summary>
        public ICollection<VirtualNetworkRule> VirtualNetworkRules { get; set; }
        /// <summary> Sets the IP ACL rules. </summary>
        public ICollection<IPRule> IpRules { get; set; }
        /// <summary> Specifies the default action of allow or deny when no other rules match. </summary>
        public DefaultAction DefaultAction { get; set; }
    }
}
