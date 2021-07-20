// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Weather.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CurrentConditionsResponse
    {
        /// <summary>
        /// Initializes a new instance of the CurrentConditionsResponse class.
        /// </summary>
        public CurrentConditionsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CurrentConditionsResponse class.
        /// </summary>
        /// <param name="results">Detailed current weather conditions.</param>
        public CurrentConditionsResponse(IList<CurrentConditions> results = default(IList<CurrentConditions>))
        {
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets detailed current weather conditions.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<CurrentConditions> Results { get; set; }

    }
}
