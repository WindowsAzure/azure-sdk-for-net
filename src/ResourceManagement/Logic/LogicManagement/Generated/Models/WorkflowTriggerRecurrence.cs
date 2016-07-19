// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class WorkflowTriggerRecurrence
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerRecurrence class.
        /// </summary>
        public WorkflowTriggerRecurrence() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerRecurrence class.
        /// </summary>
        public WorkflowTriggerRecurrence(RecurrenceFrequency? frequency = default(RecurrenceFrequency?), int? interval = default(int?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), string timeZone = default(string), RecurrenceSchedule schedule = default(RecurrenceSchedule))
        {
            Frequency = frequency;
            Interval = interval;
            StartTime = startTime;
            EndTime = endTime;
            TimeZone = timeZone;
            Schedule = schedule;
        }

        /// <summary>
        /// Gets or sets gets or sets the frequency. Possible values include:
        /// 'NotSpecified', 'Second', 'Minute', 'Hour', 'Day', 'Week',
        /// 'Month', 'Year'
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public RecurrenceFrequency? Frequency { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the interval.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the time zone.
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the recurrence schedule.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public RecurrenceSchedule Schedule { get; set; }

    }
}
