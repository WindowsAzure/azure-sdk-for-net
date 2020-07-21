// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListFirewallPolicies API service call. </summary>
    public partial class FirewallPolicyListResult
    {
        /// <summary> Initializes a new instance of FirewallPolicyListResult. </summary>
        internal FirewallPolicyListResult()
        {
            Value = new ChangeTrackingList<FirewallPolicy>();
        }

        /// <summary> Initializes a new instance of FirewallPolicyListResult. </summary>
        /// <param name="value"> List of Firewall Policies in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal FirewallPolicyListResult(IReadOnlyList<FirewallPolicy> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Firewall Policies in a resource group. </summary>
        public IReadOnlyList<FirewallPolicy> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
