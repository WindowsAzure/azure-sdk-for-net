// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Latest available balance on Monetary Credit PI.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AvailableBalance : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AvailableBalance class.
        /// </summary>
        public AvailableBalance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableBalance class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="amount">Balance Amount.</param>
        public AvailableBalance(string id = default(string), string name = default(string), string type = default(string), Amount amount = default(Amount))
            : base(id, name, type)
        {
            Amount = amount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets balance Amount.
        /// </summary>
        [JsonProperty(PropertyName = "properties.amount")]
        public Amount Amount { get; private set; }

    }
}
