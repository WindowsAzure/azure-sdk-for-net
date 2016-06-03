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
    /// Result for a single task added as part of an add task collection
    /// operation.
    /// </summary>
    public partial class TaskAddResult
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddResult class.
        /// </summary>
        public TaskAddResult() { }

        /// <summary>
        /// Initializes a new instance of the TaskAddResult class.
        /// </summary>
        public TaskAddResult(TaskAddStatus status, string taskId, string eTag = default(string), DateTime? lastModified = default(DateTime?), string location = default(string), BatchError error = default(BatchError))
        {
            Status = status;
            TaskId = taskId;
            ETag = eTag;
            LastModified = lastModified;
            Location = location;
            Error = error;
        }

        /// <summary>
        /// Gets or sets the status of the add task request. Possible values
        /// include: 'success', 'clienterror', 'servererror', 'unmapped'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TaskAddStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the id of the task for which this is the result.
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the task, if the task was successfully
        /// added.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the task.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the URL of the task, if the task was successfully
        /// added.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the error encountered while attempting to add the
        /// task.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public BatchError Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaskId");
            }
        }
    }
}
