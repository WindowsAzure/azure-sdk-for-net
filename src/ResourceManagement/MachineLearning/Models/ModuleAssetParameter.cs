// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameter definition for a module asset.
    /// </summary>
    public partial class ModuleAssetParameter
    {
        /// <summary>
        /// Initializes a new instance of the ModuleAssetParameter class.
        /// </summary>
        public ModuleAssetParameter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModuleAssetParameter class.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="parameterType">Parameter type.</param>
        /// <param name="modeValuesInfo">Definitions for nested interface
        /// parameters if this is a complex module parameter.</param>
        public ModuleAssetParameter(string name = default(string), string parameterType = default(string), IDictionary<string, ModeValueInfo> modeValuesInfo = default(IDictionary<string, ModeValueInfo>))
        {
            Name = name;
            ParameterType = parameterType;
            ModeValuesInfo = modeValuesInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parameter type.
        /// </summary>
        [JsonProperty(PropertyName = "parameterType")]
        public string ParameterType { get; set; }

        /// <summary>
        /// Gets or sets definitions for nested interface parameters if this is
        /// a complex module parameter.
        /// </summary>
        [JsonProperty(PropertyName = "modeValuesInfo")]
        public IDictionary<string, ModeValueInfo> ModeValuesInfo { get; set; }

    }
}
