// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Setting indicating whether the service has a managed identity
    /// associated with it.
    /// </summary>
    public partial class ResourceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ResourceIdentity class.
        /// </summary>
        public ResourceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceIdentity class.
        /// </summary>
        /// <param name="type">Type of identity being specified, currently
        /// SystemAssigned and None are allowed. Possible values include:
        /// 'SystemAssigned', 'None'</param>
        public ResourceIdentity(string type = default(string))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of identity being specified, currently
        /// SystemAssigned and None are allowed. Possible values include:
        /// 'SystemAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
