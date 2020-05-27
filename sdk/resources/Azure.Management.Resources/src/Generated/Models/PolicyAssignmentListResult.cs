// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resources.Models
{
    /// <summary> List of policy assignments. </summary>
    public partial class PolicyAssignmentListResult
    {
        /// <summary> Initializes a new instance of PolicyAssignmentListResult. </summary>
        internal PolicyAssignmentListResult()
        {
        }

        /// <summary> Initializes a new instance of PolicyAssignmentListResult. </summary>
        /// <param name="value"> An array of policy assignments. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal PolicyAssignmentListResult(IReadOnlyList<PolicyAssignment> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of policy assignments. </summary>
        public IReadOnlyList<PolicyAssignment> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
