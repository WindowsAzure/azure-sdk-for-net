// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Frontend IP address of the load balancer. </summary>
    public partial class FrontendIPConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of FrontendIPConfiguration. </summary>
        public FrontendIPConfiguration()
        {
            Zones = new ChangeTrackingList<string>();
            InboundNatRules = new ChangeTrackingList<SubResource>();
            InboundNatPools = new ChangeTrackingList<SubResource>();
            OutboundRules = new ChangeTrackingList<SubResource>();
            LoadBalancingRules = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of FrontendIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within the set of frontend IP configurations used by the load balancer. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="inboundNatRules"> An array of references to inbound rules that use this frontend IP. </param>
        /// <param name="inboundNatPools"> An array of references to inbound pools that use this frontend IP. </param>
        /// <param name="outboundRules"> An array of references to outbound rules that use this frontend IP. </param>
        /// <param name="loadBalancingRules"> An array of references to load balancing rules that use this frontend IP. </param>
        /// <param name="privateIPAddress"> The private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The Private IP allocation method. </param>
        /// <param name="privateIPAddressVersion"> Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. </param>
        /// <param name="subnet"> The reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference to the Public IP resource. </param>
        /// <param name="publicIPPrefix"> The reference to the Public IP Prefix resource. </param>
        /// <param name="provisioningState"> The provisioning state of the frontend IP configuration resource. </param>
        internal FrontendIPConfiguration(string id, string name, string etag, string type, IList<string> zones, IList<SubResource> inboundNatRules, IList<SubResource> inboundNatPools, IList<SubResource> outboundRules, IList<SubResource> loadBalancingRules, string privateIPAddress, IPAllocationMethod? privateIPAllocationMethod, IPVersion? privateIPAddressVersion, Subnet subnet, PublicIPAddress publicIPAddress, SubResource publicIPPrefix, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Zones = zones;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundRules = outboundRules;
            LoadBalancingRules = loadBalancingRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            PrivateIPAddressVersion = privateIPAddressVersion;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PublicIPPrefix = publicIPPrefix;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within the set of frontend IP configurations used by the load balancer. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> An array of references to inbound rules that use this frontend IP. </summary>
        public IList<SubResource> InboundNatRules { get; }
        /// <summary> An array of references to inbound pools that use this frontend IP. </summary>
        public IList<SubResource> InboundNatPools { get; }
        /// <summary> An array of references to outbound rules that use this frontend IP. </summary>
        public IList<SubResource> OutboundRules { get; }
        /// <summary> An array of references to load balancing rules that use this frontend IP. </summary>
        public IList<SubResource> LoadBalancingRules { get; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The Private IP allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. </summary>
        public IPVersion? PrivateIPAddressVersion { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public Subnet Subnet { get; set; }
        /// <summary> The reference to the Public IP resource. </summary>
        public PublicIPAddress PublicIPAddress { get; set; }
        /// <summary> The reference to the Public IP Prefix resource. </summary>
        public SubResource PublicIPPrefix { get; set; }
        /// <summary> The provisioning state of the frontend IP configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
