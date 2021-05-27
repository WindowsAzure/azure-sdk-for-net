// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of job steps. </summary>
    internal partial class JobStepListResult
    {
        /// <summary> Initializes a new instance of JobStepListResult. </summary>
        internal JobStepListResult()
        {
            Value = new ChangeTrackingList<JobStep>();
        }

        /// <summary> Initializes a new instance of JobStepListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobStepListResult(IReadOnlyList<JobStep> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<JobStep> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
