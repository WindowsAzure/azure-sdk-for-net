// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schedule-based autoscale request parameters
    /// </summary>
    public partial class AutoscaleRecurrence
    {
        /// <summary>
        /// Initializes a new instance of the AutoscaleRecurrence class.
        /// </summary>
        public AutoscaleRecurrence()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoscaleRecurrence class.
        /// </summary>
        /// <param name="timeZone">The time zone for the autoscale schedule
        /// times</param>
        /// <param name="schedule">Array of schedule-based autoscale
        /// rules</param>
        public AutoscaleRecurrence(string timeZone = default(string), IList<AutoscaleSchedule> schedule = default(IList<AutoscaleSchedule>))
        {
            TimeZone = timeZone;
            Schedule = schedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time zone for the autoscale schedule times
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets array of schedule-based autoscale rules
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public IList<AutoscaleSchedule> Schedule { get; set; }

    }
}
