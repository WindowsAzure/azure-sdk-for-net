// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Information about a start task running on a compute node.
    /// </summary>
    public partial class StartTaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the StartTaskInformation class.
        /// </summary>
        public StartTaskInformation() { }

        /// <summary>
        /// Initializes a new instance of the StartTaskInformation class.
        /// </summary>
        public StartTaskInformation(StartTaskState state, DateTime startTime, int retryCount, DateTime? endTime = default(DateTime?), int? exitCode = default(int?), TaskSchedulingError schedulingError = default(TaskSchedulingError), DateTime? lastRetryTime = default(DateTime?))
        {
            State = state;
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            SchedulingError = schedulingError;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
        }

        /// <summary>
        /// Gets or sets the state of the start task on the compute node.
        /// Possible values include: 'running', 'completed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public StartTaskState State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the start task started running.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the start task stopped running.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the start task.
        /// </summary>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets any error encountered scheduling the start task.
        /// </summary>
        [JsonProperty(PropertyName = "schedulingError")]
        public TaskSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets the number of times the task has been retried by the
        /// Batch service.
        /// </summary>
        [JsonProperty(PropertyName = "retryCount")]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which a retry of the task
        /// started running.
        /// </summary>
        [JsonProperty(PropertyName = "lastRetryTime")]
        public DateTime? LastRetryTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}
