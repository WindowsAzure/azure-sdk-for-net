// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update variable operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VariableCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the VariableCreateOrUpdateParameters
        /// class.
        /// </summary>
        public VariableCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VariableCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the variable.</param>
        /// <param name="value">Gets or sets the value of the variable.</param>
        /// <param name="description">Gets or sets the description of the
        /// variable.</param>
        /// <param name="isEncrypted">Gets or sets the encrypted flag of the
        /// variable.</param>
        public VariableCreateOrUpdateParameters(string name, string value = default(string), string description = default(string), bool? isEncrypted = default(bool?))
        {
            Name = name;
            Value = value;
            Description = description;
            IsEncrypted = isEncrypted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the description of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the encrypted flag of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEncrypted")]
        public bool? IsEncrypted { get; set; }

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
