// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes metadata for retrieving price info.
    /// </summary>
    public partial class ResourceSkuCosts
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuCosts class.
        /// </summary>
        public ResourceSkuCosts() { }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuCosts class.
        /// </summary>
        /// <param name="meterID">Used for querying price from
        /// commerce.</param>
        /// <param name="quantity">The multiplier is needed to extend the base
        /// metered cost.</param>
        /// <param name="extendedUnit">An invariant to show the extended
        /// unit.</param>
        public ResourceSkuCosts(string meterID = default(string), long? quantity = default(long?), string extendedUnit = default(string))
        {
            MeterID = meterID;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
        }

        /// <summary>
        /// Gets used for querying price from commerce.
        /// </summary>
        [JsonProperty(PropertyName = "meterID")]
        public string MeterID { get; protected set; }

        /// <summary>
        /// Gets the multiplier is needed to extend the base metered cost.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; protected set; }

        /// <summary>
        /// Gets an invariant to show the extended unit.
        /// </summary>
        [JsonProperty(PropertyName = "extendedUnit")]
        public string ExtendedUnit { get; protected set; }

    }
}

