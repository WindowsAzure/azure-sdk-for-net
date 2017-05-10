// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Insights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric availability specifies the time grain (aggregation interval or
    /// frequency) and the retention period for that time grain.
    /// </summary>
    public partial class MetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        public MetricAvailability() { }

        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        /// <param name="timeGrain">the time grain specifies the aggregation
        /// interval for the metric. Expressed as a duration 'PT1M', 'P1D',
        /// etc.</param>
        /// <param name="retention">the retention period for the metric at the
        /// specified timegrain.  Expressed as a duration 'PT1M', 'P1D',
        /// etc.</param>
        public MetricAvailability(System.TimeSpan? timeGrain = default(System.TimeSpan?), System.TimeSpan? retention = default(System.TimeSpan?))
        {
            TimeGrain = timeGrain;
            Retention = retention;
        }

        /// <summary>
        /// Gets or sets the time grain specifies the aggregation interval for
        /// the metric. Expressed as a duration 'PT1M', 'P1D', etc.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public System.TimeSpan? TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets the retention period for the metric at the specified
        /// timegrain.  Expressed as a duration 'PT1M', 'P1D', etc.
        /// </summary>
        [JsonProperty(PropertyName = "retention")]
        public System.TimeSpan? Retention { get; set; }

    }
}
