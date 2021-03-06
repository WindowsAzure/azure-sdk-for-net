// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class DscNodeUpdateParametersProperties
    {
        /// <summary>
        /// Initializes a new instance of the DscNodeUpdateParametersProperties
        /// class.
        /// </summary>
        public DscNodeUpdateParametersProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscNodeUpdateParametersProperties
        /// class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the dsc node
        /// configuration.</param>
        public DscNodeUpdateParametersProperties(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the dsc node configuration.
        /// </summary>
        [JsonProperty(PropertyName = "nodeConfiguration.name")]
        public string Name { get; set; }

    }
}
