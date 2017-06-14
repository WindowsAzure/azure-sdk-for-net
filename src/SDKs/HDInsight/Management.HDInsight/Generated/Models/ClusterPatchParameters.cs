// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight.Models
{
    using Microsoft.HDInsight;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The PatchCluster request parameters
    /// </summary>
    public partial class ClusterPatchParameters
    {
        /// <summary>
        /// Initializes a new instance of the ClusterPatchParameters class.
        /// </summary>
        public ClusterPatchParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterPatchParameters class.
        /// </summary>
        /// <param name="tags">The resource tags.</param>
        public ClusterPatchParameters(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
