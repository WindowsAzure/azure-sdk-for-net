// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class FlavorData
    {
        /// <summary>
        /// Initializes a new instance of the FlavorData class.
        /// </summary>
        public FlavorData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlavorData class.
        /// </summary>
        public FlavorData(IDictionary<string, string> data = default(IDictionary<string, string>))
        {
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IDictionary<string, string> Data { get; set; }

    }
}
