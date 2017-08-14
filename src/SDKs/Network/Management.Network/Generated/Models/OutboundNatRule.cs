// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Outbound NAT pool of the load balancer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OutboundNatRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the OutboundNatRule class.
        /// </summary>
        public OutboundNatRule()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OutboundNatRule class.
        /// </summary>
        /// <param name="backendAddressPool">A reference to a pool of DIPs.
        /// Outbound traffic is randomly load balanced across IPs in the
        /// backend IPs.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="allocatedOutboundPorts">The number of outbound ports
        /// to be used for NAT.</param>
        /// <param name="frontendIPConfigurations">The Frontend IP addresses of
        /// the load balancer.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// PublicIP resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public OutboundNatRule(SubResource backendAddressPool, string id = default(string), int? allocatedOutboundPorts = default(int?), IList<SubResource> frontendIPConfigurations = default(IList<SubResource>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            AllocatedOutboundPorts = allocatedOutboundPorts;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPool = backendAddressPool;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of outbound ports to be used for NAT.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allocatedOutboundPorts")]
        public int? AllocatedOutboundPorts { get; set; }

        /// <summary>
        /// Gets or sets the Frontend IP addresses of the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<SubResource> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets a reference to a pool of DIPs. Outbound traffic is
        /// randomly load balanced across IPs in the backend IPs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets the provisioning state of the PublicIP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackendAddressPool == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackendAddressPool");
            }
        }
    }
}
