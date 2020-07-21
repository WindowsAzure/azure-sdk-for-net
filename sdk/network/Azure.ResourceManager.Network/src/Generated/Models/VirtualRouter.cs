// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VirtualRouter Resource. </summary>
    public partial class VirtualRouter : Resource
    {
        /// <summary> Initializes a new instance of VirtualRouter. </summary>
        public VirtualRouter()
        {
            VirtualRouterIps = new ChangeTrackingList<string>();
            Peerings = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of VirtualRouter. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualRouterAsn"> VirtualRouter ASN. </param>
        /// <param name="virtualRouterIps"> VirtualRouter IPs. </param>
        /// <param name="hostedSubnet"> The Subnet on which VirtualRouter is hosted. </param>
        /// <param name="hostedGateway"> The Gateway on which VirtualRouter is hosted. </param>
        /// <param name="peerings"> List of references to VirtualRouterPeerings. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal VirtualRouter(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, long? virtualRouterAsn, IList<string> virtualRouterIps, SubResource hostedSubnet, SubResource hostedGateway, IList<SubResource> peerings, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualRouterAsn = virtualRouterAsn;
            VirtualRouterIps = virtualRouterIps;
            HostedSubnet = hostedSubnet;
            HostedGateway = hostedGateway;
            Peerings = peerings;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> VirtualRouter ASN. </summary>
        public long? VirtualRouterAsn { get; set; }
        /// <summary> VirtualRouter IPs. </summary>
        public IList<string> VirtualRouterIps { get; }
        /// <summary> The Subnet on which VirtualRouter is hosted. </summary>
        public SubResource HostedSubnet { get; set; }
        /// <summary> The Gateway on which VirtualRouter is hosted. </summary>
        public SubResource HostedGateway { get; set; }
        /// <summary> List of references to VirtualRouterPeerings. </summary>
        public IList<SubResource> Peerings { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
