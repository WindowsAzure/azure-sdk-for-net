// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Sql pool usages.
    /// </summary>
    public partial class SqlPoolUsage
    {
        /// <summary>
        /// Initializes a new instance of the SqlPoolUsage class.
        /// </summary>
        public SqlPoolUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlPoolUsage class.
        /// </summary>
        /// <param name="name">The name of the usage metric.</param>
        /// <param name="resourceName">The name of the resource.</param>
        /// <param name="displayName">The usage metric display name.</param>
        /// <param name="currentValue">The current value of the usage
        /// metric.</param>
        /// <param name="limit">The current limit of the usage metric.</param>
        /// <param name="unit">The units of the usage metric.</param>
        /// <param name="nextResetTime">The next reset time for the usage
        /// metric (ISO8601 format).</param>
        public SqlPoolUsage(string name = default(string), string resourceName = default(string), string displayName = default(string), double? currentValue = default(double?), double? limit = default(double?), string unit = default(string), System.DateTime? nextResetTime = default(System.DateTime?))
        {
            Name = name;
            ResourceName = resourceName;
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            NextResetTime = nextResetTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; private set; }

        /// <summary>
        /// Gets the usage metric display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the current value of the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; private set; }

        /// <summary>
        /// Gets the current limit of the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; private set; }

        /// <summary>
        /// Gets the units of the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the next reset time for the usage metric (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "nextResetTime")]
        public System.DateTime? NextResetTime { get; private set; }

    }
}
