// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the Web Application Firewall policy for each routing rule (if
    /// applicable)
    /// </summary>
    public partial class RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink class.
        /// </summary>
        public RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        public RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
