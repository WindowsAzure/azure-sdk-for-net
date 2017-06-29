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
    /// The HDInsight cluster.
    /// </summary>
    public partial class Cluster : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="location">The resource location</param>
        /// <param name="id">The resource Id</param>
        /// <param name="name">The resource name</param>
        /// <param name="type">The resource type</param>
        /// <param name="tags">The resource tags</param>
        /// <param name="etag">The ETag for the resource</param>
        /// <param name="properties">The properties of the cluster.</param>
        public Cluster(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), ClusterGetProperties properties = default(ClusterGetProperties))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ETag for the resource
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the properties of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ClusterGetProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
