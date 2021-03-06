// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input of the secret to be validated.
    /// </summary>
    public partial class ValidateSecretInput
    {
        /// <summary>
        /// Initializes a new instance of the ValidateSecretInput class.
        /// </summary>
        public ValidateSecretInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateSecretInput class.
        /// </summary>
        /// <param name="secretSource">The secret source.</param>
        /// <param name="secretType">The secret type. Possible values include:
        /// 'UrlSigningKey', 'ManagedCertificate',
        /// 'CustomerCertificate'</param>
        public ValidateSecretInput(ResourceReference secretSource, string secretType)
        {
            SecretSource = secretSource;
            SecretType = secretType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the secret source.
        /// </summary>
        [JsonProperty(PropertyName = "secretSource")]
        public ResourceReference SecretSource { get; set; }

        /// <summary>
        /// Gets or sets the secret type. Possible values include:
        /// 'UrlSigningKey', 'ManagedCertificate', 'CustomerCertificate'
        /// </summary>
        [JsonProperty(PropertyName = "secretType")]
        public string SecretType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SecretSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretSource");
            }
            if (SecretType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretType");
            }
        }
    }
}
