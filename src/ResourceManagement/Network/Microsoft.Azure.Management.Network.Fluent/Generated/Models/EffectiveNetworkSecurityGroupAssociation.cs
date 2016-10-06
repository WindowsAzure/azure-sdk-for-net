// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Effective NetworkSecurityGroup association
    /// </summary>
    public partial class EffectiveNetworkSecurityGroupAssociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupAssociation class.
        /// </summary>
        public EffectiveNetworkSecurityGroupAssociation() { }

        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupAssociation class.
        /// </summary>
        /// <param name="subnet">Gets the id of subnet if assigned</param>
        /// <param name="networkInterface">Gets the id of network interface if
        /// assigned</param>
        public EffectiveNetworkSecurityGroupAssociation(Microsoft.Azure.Management.Resource.Fluent.SubResource subnet = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), Microsoft.Azure.Management.Resource.Fluent.SubResource networkInterface = default(Microsoft.Azure.Management.Resource.Fluent.SubResource))
        {
            Subnet = subnet;
            NetworkInterface = networkInterface;
        }

        /// <summary>
        /// Gets the id of subnet if assigned
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subnet")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource Subnet { get; set; }

        /// <summary>
        /// Gets the id of network interface if assigned
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkInterface")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource NetworkInterface { get; set; }

    }
}
