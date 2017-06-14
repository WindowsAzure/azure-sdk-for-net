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
    using System.Linq;

    /// <summary>
    /// The virtual network properties.
    /// </summary>
    public partial class VirtualNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkProfile class.
        /// </summary>
        public VirtualNetworkProfile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkProfile class.
        /// </summary>
        /// <param name="id">The ID of the virtual network.</param>
        /// <param name="subnet">The name of the subnet.</param>
        public VirtualNetworkProfile(string id = default(string), string subnet = default(string))
        {
            Id = id;
            Subnet = subnet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string Subnet { get; set; }

    }
}
