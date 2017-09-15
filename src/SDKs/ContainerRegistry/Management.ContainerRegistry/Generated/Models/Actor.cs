// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerRegistry;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The agent that initiated the event. For most situations, this could be
    /// from the authorization context of the request.
    /// </summary>
    public partial class Actor
    {
        /// <summary>
        /// Initializes a new instance of the Actor class.
        /// </summary>
        public Actor()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Actor class.
        /// </summary>
        /// <param name="name">The subject or username associated with the
        /// request context that generated the event.</param>
        public Actor(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subject or username associated with the request
        /// context that generated the event.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
