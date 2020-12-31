// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The list of new failover policies for the failover priority change. </summary>
    public partial class FailoverPolicies
    {
        /// <summary> Initializes a new instance of FailoverPolicies. </summary>
        /// <param name="failoverPoliciesValue"> List of failover policies. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverPoliciesValue"/> is null. </exception>
        public FailoverPolicies(IEnumerable<FailoverPolicy> failoverPoliciesValue)
        {
            if (failoverPoliciesValue == null)
            {
                throw new ArgumentNullException(nameof(failoverPoliciesValue));
            }

            FailoverPoliciesValue = failoverPoliciesValue.ToList();
        }

        /// <summary> List of failover policies. </summary>
        public IList<FailoverPolicy> FailoverPoliciesValue { get; }
    }
}
