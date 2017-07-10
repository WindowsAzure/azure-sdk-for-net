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
    using System.Linq;

    /// <summary>
    /// Email Template update Parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EmailTemplateUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the EmailTemplateUpdateParameters
        /// class.
        /// </summary>
        public EmailTemplateUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailTemplateUpdateParameters
        /// class.
        /// </summary>
        /// <param name="subject">Subject of the Template.</param>
        /// <param name="body">Email Template Body. This should be a valid
        /// XDocument</param>
        public EmailTemplateUpdateParameters(string subject = default(string), string body = default(string))
        {
            Subject = subject;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subject of the Template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets email Template Body. This should be a valid XDocument
        /// </summary>
        [JsonProperty(PropertyName = "properties.body")]
        public string Body { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Subject != null)
            {
                if (Subject.Length > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Subject", 1000);
                }
                if (Subject.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Subject", 1);
                }
            }
            if (Body != null)
            {
                if (Body.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Body", 1);
                }
            }
        }
    }
}
