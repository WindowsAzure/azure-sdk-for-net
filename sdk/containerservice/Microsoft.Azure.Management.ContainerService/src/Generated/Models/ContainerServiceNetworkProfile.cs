// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile of network configuration.
    /// </summary>
    public partial class ContainerServiceNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceNetworkProfile
        /// class.
        /// </summary>
        public ContainerServiceNetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceNetworkProfile
        /// class.
        /// </summary>
        /// <param name="networkPlugin">Network plugin used for building
        /// Kubernetes network. Possible values include: 'azure',
        /// 'kubenet'</param>
        /// <param name="networkPolicy">Network policy used for building
        /// Kubernetes network. Possible values include: 'calico',
        /// 'azure'</param>
        /// <param name="podCidr">A CIDR notation IP range from which to assign
        /// pod IPs when kubenet is used.</param>
        /// <param name="serviceCidr">A CIDR notation IP range from which to
        /// assign service cluster IPs. It must not overlap with any Subnet IP
        /// ranges.</param>
        /// <param name="dnsServiceIP">An IP address assigned to the Kubernetes
        /// DNS service. It must be within the Kubernetes service address range
        /// specified in serviceCidr.</param>
        /// <param name="dockerBridgeCidr">A CIDR notation IP range assigned to
        /// the Docker bridge network. It must not overlap with any Subnet IP
        /// ranges or the Kubernetes service address range.</param>
        /// <param name="loadBalancerSku">The load balancer sku for the managed
        /// cluster. Possible values include: 'standard', 'basic'</param>
        /// <param name="loadBalancerProfile">Profile of the cluster load
        /// balancer.</param>
        public ContainerServiceNetworkProfile(string networkPlugin = default(string), string networkPolicy = default(string), string podCidr = default(string), string serviceCidr = default(string), string dnsServiceIP = default(string), string dockerBridgeCidr = default(string), string loadBalancerSku = default(string), ManagedClusterLoadBalancerProfile loadBalancerProfile = default(ManagedClusterLoadBalancerProfile))
        {
            NetworkPlugin = networkPlugin;
            NetworkPolicy = networkPolicy;
            PodCidr = podCidr;
            ServiceCidr = serviceCidr;
            DnsServiceIP = dnsServiceIP;
            DockerBridgeCidr = dockerBridgeCidr;
            LoadBalancerSku = loadBalancerSku;
            LoadBalancerProfile = loadBalancerProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets network plugin used for building Kubernetes network.
        /// Possible values include: 'azure', 'kubenet'
        /// </summary>
        [JsonProperty(PropertyName = "networkPlugin")]
        public string NetworkPlugin { get; set; }

        /// <summary>
        /// Gets or sets network policy used for building Kubernetes network.
        /// Possible values include: 'calico', 'azure'
        /// </summary>
        [JsonProperty(PropertyName = "networkPolicy")]
        public string NetworkPolicy { get; set; }

        /// <summary>
        /// Gets or sets a CIDR notation IP range from which to assign pod IPs
        /// when kubenet is used.
        /// </summary>
        [JsonProperty(PropertyName = "podCidr")]
        public string PodCidr { get; set; }

        /// <summary>
        /// Gets or sets a CIDR notation IP range from which to assign service
        /// cluster IPs. It must not overlap with any Subnet IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "serviceCidr")]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// Gets or sets an IP address assigned to the Kubernetes DNS service.
        /// It must be within the Kubernetes service address range specified in
        /// serviceCidr.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServiceIP")]
        public string DnsServiceIP { get; set; }

        /// <summary>
        /// Gets or sets a CIDR notation IP range assigned to the Docker bridge
        /// network. It must not overlap with any Subnet IP ranges or the
        /// Kubernetes service address range.
        /// </summary>
        [JsonProperty(PropertyName = "dockerBridgeCidr")]
        public string DockerBridgeCidr { get; set; }

        /// <summary>
        /// Gets or sets the load balancer sku for the managed cluster.
        /// Possible values include: 'standard', 'basic'
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerSku")]
        public string LoadBalancerSku { get; set; }

        /// <summary>
        /// Gets or sets profile of the cluster load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerProfile")]
        public ManagedClusterLoadBalancerProfile LoadBalancerProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LoadBalancerProfile != null)
            {
                LoadBalancerProfile.Validate();
            }
        }
    }
}
