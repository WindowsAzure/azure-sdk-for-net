// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operations health status in a location.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OperationsHealth : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the OperationsHealth class.
        /// </summary>
        public OperationsHealth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationsHealth class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="operationsHealthName">Operation name for the
        /// service</param>
        /// <param name="health">Operation health status of the
        /// service.</param>
        /// <param name="description">Health status description.</param>
        public OperationsHealth(string id = default(string), string name = default(string), string type = default(string), string operationsHealthName = default(string), string health = default(string), string description = default(string))
            : base(id, name, type)
        {
            OperationsHealthName = operationsHealthName;
            Health = health;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets operation name for the service
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string OperationsHealthName { get; private set; }

        /// <summary>
        /// Gets operation health status of the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.health")]
        public string Health { get; private set; }

        /// <summary>
        /// Gets health status description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

    }
}
