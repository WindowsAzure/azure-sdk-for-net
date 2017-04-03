// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metrics availability and retention.
    /// </summary>
    public partial class ResourceMetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricAvailability class.
        /// </summary>
        public ResourceMetricAvailability()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricAvailability class.
        /// </summary>
        /// <param name="timeGrain">Time grain .</param>
        /// <param name="retention">Retention period for the current time
        /// grain.</param>
        public ResourceMetricAvailability(string timeGrain = default(string), string retention = default(string))
        {
            TimeGrain = timeGrain;
            Retention = retention;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets time grain .
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; private set; }

        /// <summary>
        /// Gets retention period for the current time grain.
        /// </summary>
        [JsonProperty(PropertyName = "retention")]
        public string Retention { get; private set; }

    }
}
