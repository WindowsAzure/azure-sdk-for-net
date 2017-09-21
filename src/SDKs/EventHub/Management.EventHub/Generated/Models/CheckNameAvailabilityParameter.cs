// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventHub;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameter supplied to check Namespace name availability operation
    /// </summary>
    public partial class CheckNameAvailabilityParameter
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityParameter
        /// class.
        /// </summary>
        public CheckNameAvailabilityParameter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityParameter
        /// class.
        /// </summary>
        /// <param name="name">Name to check the namespace name
        /// availability</param>
        public CheckNameAvailabilityParameter(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name to check the namespace name availability
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
