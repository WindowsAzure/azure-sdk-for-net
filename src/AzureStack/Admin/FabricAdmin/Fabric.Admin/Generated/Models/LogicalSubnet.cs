// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This resource represents a logical subnet.  A logical subnet is made of
    /// a subnet-vlan pair.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogicalSubnet : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LogicalSubnet class.
        /// </summary>
        public LogicalSubnet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogicalSubnet class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="ipPools">All IP pools which belong to this
        /// subnet.</param>
        /// <param name="isPublic">The visibility status of the IP pool.  If is
        /// true the associated pools are public IP address pools.</param>
        /// <param name="metadata">Metadata related to the logical
        /// network.</param>
        public LogicalSubnet(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> ipPools = default(IList<string>), bool? isPublic = default(bool?), IDictionary<string, string> metadata = default(IDictionary<string, string>))
            : base(id, name, type, location, tags)
        {
            IpPools = ipPools;
            IsPublic = isPublic;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets all IP pools which belong to this subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipPools")]
        public IList<string> IpPools { get; set; }

        /// <summary>
        /// Gets or sets the visibility status of the IP pool.  If is true the
        /// associated pools are public IP address pools.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Gets or sets metadata related to the logical network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

    }
}
