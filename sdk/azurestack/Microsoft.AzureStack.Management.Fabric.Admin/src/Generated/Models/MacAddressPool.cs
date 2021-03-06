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
    /// This resource represents a MAC address pool.  The default MAC address
    /// pools are used if you set the MAC address type for a virtual machine to
    /// 'Static'.  If the virtual machine setting is 'Dynamic', the hypervisor
    /// assigns the MAC address.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MacAddressPool : Resource
    {
        /// <summary>
        /// Initializes a new instance of the MacAddressPool class.
        /// </summary>
        public MacAddressPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MacAddressPool class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="metadata">Metadata related to the MAC pool.</param>
        /// <param name="startMacAddress">Starting MAC address.</param>
        /// <param name="endMacAddress">Ending MAC address.</param>
        /// <param name="numberOfAllocatedMacAddresses">Number of MAC addresses
        /// allocated.</param>
        /// <param name="numberOfAvailableMacAddresses">Number of MAC addresses
        /// available.</param>
        public MacAddressPool(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> metadata = default(IDictionary<string, string>), string startMacAddress = default(string), string endMacAddress = default(string), long? numberOfAllocatedMacAddresses = default(long?), long? numberOfAvailableMacAddresses = default(long?))
            : base(id, name, type, location, tags)
        {
            Metadata = metadata;
            StartMacAddress = startMacAddress;
            EndMacAddress = endMacAddress;
            NumberOfAllocatedMacAddresses = numberOfAllocatedMacAddresses;
            NumberOfAvailableMacAddresses = numberOfAvailableMacAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets metadata related to the MAC pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets starting MAC address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startMacAddress")]
        public string StartMacAddress { get; set; }

        /// <summary>
        /// Gets or sets ending MAC address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endMacAddress")]
        public string EndMacAddress { get; set; }

        /// <summary>
        /// Gets or sets number of MAC addresses allocated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfAllocatedMacAddresses")]
        public long? NumberOfAllocatedMacAddresses { get; set; }

        /// <summary>
        /// Gets or sets number of MAC addresses available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfAvailableMacAddresses")]
        public long? NumberOfAvailableMacAddresses { get; set; }

    }
}
