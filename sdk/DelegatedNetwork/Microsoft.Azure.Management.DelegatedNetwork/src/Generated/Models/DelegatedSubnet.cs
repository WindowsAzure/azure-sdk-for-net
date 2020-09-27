// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DelegatedNetwork.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an instance of a orchestrator.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DelegatedSubnet : DelegatedSubnetResource
    {
        /// <summary>
        /// Initializes a new instance of the DelegatedSubnet class.
        /// </summary>
        public DelegatedSubnet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelegatedSubnet class.
        /// </summary>
        /// <param name="id">An identifier that represents the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of resource.</param>
        /// <param name="location">Location of the resource.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="resourceGuid">Resource guid.</param>
        /// <param name="provisioningState">The current state of dnc delegated
        /// subnet resource. Possible values include: 'Deleting', 'Succeeded',
        /// 'Failed', 'Provisioning'</param>
        /// <param name="subnetDetails">orchestrator details</param>
        /// <param name="controllerDetails">controller details</param>
        public DelegatedSubnet(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string resourceGuid = default(string), string provisioningState = default(string), SubnetDetails subnetDetails = default(SubnetDetails), ControllerDetailsModel controllerDetails = default(ControllerDetailsModel))
            : base(id, name, type, location, tags)
        {
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            SubnetDetails = subnetDetails;
            ControllerDetails = controllerDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource guid.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the current state of dnc delegated subnet resource. Possible
        /// values include: 'Deleting', 'Succeeded', 'Failed', 'Provisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets orchestrator details
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetDetails")]
        public SubnetDetails SubnetDetails { get; set; }

        /// <summary>
        /// Gets or sets controller details
        /// </summary>
        [JsonProperty(PropertyName = "properties.controllerDetails")]
        public ControllerDetailsModel ControllerDetails { get; set; }

    }
}
