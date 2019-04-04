// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object to represent monetary quantities.
    /// </summary>
    public partial class Amount
    {
        /// <summary>
        /// Initializes a new instance of the Amount class.
        /// </summary>
        public Amount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Amount class.
        /// </summary>
        /// <param name="currency">The currency for the amount value.</param>
        /// <param name="value">Amount value.</param>
        public Amount(string currency = default(string), double? value = default(double?))
        {
            Currency = currency;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the currency for the amount value.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets amount value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; private set; }

    }
}
