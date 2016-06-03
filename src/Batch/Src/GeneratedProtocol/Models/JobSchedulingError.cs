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
    /// An error encountered by the Batch service when scheduling a job.
    /// </summary>
    public partial class JobSchedulingError
    {
        /// <summary>
        /// Initializes a new instance of the JobSchedulingError class.
        /// </summary>
        public JobSchedulingError() { }

        /// <summary>
        /// Initializes a new instance of the JobSchedulingError class.
        /// </summary>
        public JobSchedulingError(SchedulingErrorCategory category, string code = default(string), string message = default(string), IList<NameValuePair> details = default(IList<NameValuePair>))
        {
            Category = category;
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary>
        /// Gets or sets the category of the job scheduling error. Possible
        /// values include: 'usererror', 'servererror', 'unmapped'
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public SchedulingErrorCategory Category { get; set; }

        /// <summary>
        /// Gets or sets an identifier for the job scheduling error. Codes are
        /// invariant and are intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the job scheduling error,
        /// intended to be suitable for display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a list of additional error details related to the
        /// scheduling error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<NameValuePair> Details { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
