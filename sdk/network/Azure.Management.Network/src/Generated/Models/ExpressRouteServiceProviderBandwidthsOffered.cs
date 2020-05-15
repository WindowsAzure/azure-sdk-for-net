// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Contains bandwidths offered in ExpressRouteServiceProvider resources. </summary>
    public partial class ExpressRouteServiceProviderBandwidthsOffered
    {
        /// <summary> Initializes a new instance of ExpressRouteServiceProviderBandwidthsOffered. </summary>
        public ExpressRouteServiceProviderBandwidthsOffered()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteServiceProviderBandwidthsOffered. </summary>
        /// <param name="offerName"> The OfferName. </param>
        /// <param name="valueInMbps"> The ValueInMbps. </param>
        internal ExpressRouteServiceProviderBandwidthsOffered(string offerName, int? valueInMbps)
        {
            OfferName = offerName;
            ValueInMbps = valueInMbps;
        }

        /// <summary> The OfferName. </summary>
        public string OfferName { get; set; }
        /// <summary> The ValueInMbps. </summary>
        public int? ValueInMbps { get; set; }
    }
}
