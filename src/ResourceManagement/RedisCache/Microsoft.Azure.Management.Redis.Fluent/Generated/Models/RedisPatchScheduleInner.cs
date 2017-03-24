// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Redis;
    using Microsoft.Azure.Management.Redis.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response to put/get patch schedules for Redis cache.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RedisPatchScheduleInner
    {
        /// <summary>
        /// Initializes a new instance of the RedisPatchScheduleInner class.
        /// </summary>
        public RedisPatchScheduleInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisPatchScheduleInner class.
        /// </summary>
        /// <param name="scheduleEntriesProperty">List of patch schedules for a
        /// Redis cache.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        public RedisPatchScheduleInner(IList<ScheduleEntryInner> scheduleEntriesProperty, string id = default(string), string name = default(string), string type = default(string), string location = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            ScheduleEntriesProperty = scheduleEntriesProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets list of patch schedules for a Redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scheduleEntries")]
        public IList<ScheduleEntryInner> ScheduleEntriesProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScheduleEntriesProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScheduleEntriesProperty");
            }
            if (ScheduleEntriesProperty != null)
            {
                foreach (var element in ScheduleEntriesProperty)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
