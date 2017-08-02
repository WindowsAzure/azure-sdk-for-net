// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Usage Names.
    /// </summary>
    public partial class UsageName
    {
        /// <summary>
        /// Initializes a new instance of the UsageName class.
        /// </summary>
        public UsageName()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageName class.
        /// </summary>
        /// <param name="value">The name of the resource.</param>
        /// <param name="localizedValue">The localized name of the
        /// resource.</param>
        public UsageName(string value = default(string), string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the localized name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; set; }

    }
}
