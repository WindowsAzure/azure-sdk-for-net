// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Route Filter Resource. </summary>
    public partial class RouteFilter : Resource
    {
        /// <summary> Initializes a new instance of RouteFilter. </summary>
        public RouteFilter()
        {
            Rules = new ChangeTrackingList<RouteFilterRule>();
            Peerings = new ChangeTrackingList<ExpressRouteCircuitPeering>();
            Ipv6Peerings = new ChangeTrackingList<ExpressRouteCircuitPeering>();
        }

        /// <summary> Initializes a new instance of RouteFilter. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rules"> Collection of RouteFilterRules contained within a route filter. </param>
        /// <param name="peerings"> A collection of references to express route circuit peerings. </param>
        /// <param name="ipv6Peerings"> A collection of references to express route circuit ipv6 peerings. </param>
        /// <param name="provisioningState"> The provisioning state of the route filter resource. </param>
        internal RouteFilter(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<RouteFilterRule> rules, IList<ExpressRouteCircuitPeering> peerings, IList<ExpressRouteCircuitPeering> ipv6Peerings, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Rules = rules;
            Peerings = peerings;
            Ipv6Peerings = ipv6Peerings;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Collection of RouteFilterRules contained within a route filter. </summary>
        public IList<RouteFilterRule> Rules { get; }
        /// <summary> A collection of references to express route circuit peerings. </summary>
        public IList<ExpressRouteCircuitPeering> Peerings { get; }
        /// <summary> A collection of references to express route circuit ipv6 peerings. </summary>
        public IList<ExpressRouteCircuitPeering> Ipv6Peerings { get; }
        /// <summary> The provisioning state of the route filter resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
