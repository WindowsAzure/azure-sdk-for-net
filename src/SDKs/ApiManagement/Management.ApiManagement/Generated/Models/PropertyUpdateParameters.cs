// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Property update Parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PropertyUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the PropertyUpdateParameters class.
        /// </summary>
        public PropertyUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PropertyUpdateParameters class.
        /// </summary>
        /// <param name="tags">Optional tags that when provided can be used to
        /// filter the property list.</param>
        /// <param name="secret">Determines whether the value is a secret and
        /// should be encrypted or not. Default value is false.</param>
        /// <param name="displayName">Unique name of Property. It may contain
        /// only letters, digits, period, dash, and underscore
        /// characters.</param>
        /// <param name="value">Value of the property. Can contain policy
        /// expressions. It may not be empty or consist only of
        /// whitespace.</param>
        public PropertyUpdateParameters(IList<string> tags = default(IList<string>), bool? secret = default(bool?), string displayName = default(string), string value = default(string))
        {
            Tags = tags;
            Secret = secret;
            DisplayName = displayName;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional tags that when provided can be used to filter
        /// the property list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets determines whether the value is a secret and should be
        /// encrypted or not. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secret")]
        public bool? Secret { get; set; }

        /// <summary>
        /// Gets or sets unique name of Property. It may contain only letters,
        /// digits, period, dash, and underscore characters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets value of the property. Can contain policy expressions.
        /// It may not be empty or consist only of whitespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tags != null)
            {
                if (Tags.Count > 32)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Tags", 32);
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(DisplayName, "^[A-Za-z0-9-._]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "DisplayName", "^[A-Za-z0-9-._]+$");
                }
            }
            if (Value != null)
            {
                if (Value.Length > 4096)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Value", 4096);
                }
                if (Value.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Value", 1);
                }
            }
        }
    }
}
