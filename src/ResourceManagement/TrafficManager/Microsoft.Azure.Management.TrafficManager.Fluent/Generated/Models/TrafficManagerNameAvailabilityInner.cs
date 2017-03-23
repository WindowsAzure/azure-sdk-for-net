// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Azure.Management.TrafficManager.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing a Traffic Manager Name Availability response.
    /// </summary>
    public partial class TrafficManagerNameAvailabilityInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TrafficManagerNameAvailabilityInner class.
        /// </summary>
        public TrafficManagerNameAvailabilityInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TrafficManagerNameAvailabilityInner class.
        /// </summary>
        /// <param name="name">The relative name.</param>
        /// <param name="type">Traffic Manager profile resource type.</param>
        /// <param name="nameAvailable">Describes whether the relative name is
        /// available or not.</param>
        /// <param name="reason">The reason why the name is not available, when
        /// applicable.</param>
        /// <param name="message">Descriptive message that explains why the
        /// name is not available, when applicable.</param>
        public TrafficManagerNameAvailabilityInner(string name = default(string), string type = default(string), bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            Name = name;
            Type = type;
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relative name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets traffic Manager profile resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets describes whether the relative name is available or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets the reason why the name is not available, when
        /// applicable.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets descriptive message that explains why the name is not
        /// available, when applicable.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
