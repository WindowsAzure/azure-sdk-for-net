// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quantum.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of check name availability request body.
    /// </summary>
    public partial class CheckNameAvailabilityParameters
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityParameters
        /// class.
        /// </summary>
        public CheckNameAvailabilityParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityParameters
        /// class.
        /// </summary>
        /// <param name="name">Name for checking availability.</param>
        /// <param name="type">The resource type of Quantum Workspace.</param>
        public CheckNameAvailabilityParameters(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name for checking availability.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the resource type of Quantum Workspace.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
