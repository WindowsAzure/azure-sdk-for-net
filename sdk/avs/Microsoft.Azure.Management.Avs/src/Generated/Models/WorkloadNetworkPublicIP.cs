// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// NSX Public IP Block
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkloadNetworkPublicIP : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkPublicIP class.
        /// </summary>
        public WorkloadNetworkPublicIP()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkPublicIP class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">Display name of the Public IP
        /// Block.</param>
        /// <param name="numberOfPublicIPs">Number of Public IPs
        /// requested.</param>
        /// <param name="publicIPBlock">CIDR Block of the Public IP
        /// Block.</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Succeeded', 'Failed', 'Building', 'Deleting',
        /// 'Updating'</param>
        public WorkloadNetworkPublicIP(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), long? numberOfPublicIPs = default(long?), string publicIPBlock = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            NumberOfPublicIPs = numberOfPublicIPs;
            PublicIPBlock = publicIPBlock;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the Public IP Block.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets number of Public IPs requested.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfPublicIPs")]
        public long? NumberOfPublicIPs { get; set; }

        /// <summary>
        /// Gets CIDR Block of the Public IP Block.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPBlock")]
        public string PublicIPBlock { get; private set; }

        /// <summary>
        /// Gets the provisioning state. Possible values include: 'Succeeded',
        /// 'Failed', 'Building', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
