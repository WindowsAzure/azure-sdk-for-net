// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Certificate configuration which consist of non-trusted intermediates
    /// and root certificates.
    /// </summary>
    public partial class CertificateConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the CertificateConfiguration class.
        /// </summary>
        public CertificateConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateConfiguration class.
        /// </summary>
        /// <param name="storeName">The
        /// System.Security.Cryptography.x509certificates.Storename certificate
        /// store location. Only Root and CertificateAuthority are valid
        /// locations. Possible values include: 'CertificateAuthority',
        /// 'Root'</param>
        /// <param name="encodedCertificate">Base64 Encoded
        /// certificate.</param>
        /// <param name="certificatePassword">Certificate Password.</param>
        /// <param name="certificate">Certificate information.</param>
        public CertificateConfiguration(string storeName, string encodedCertificate = default(string), string certificatePassword = default(string), CertificateInformation certificate = default(CertificateInformation))
        {
            EncodedCertificate = encodedCertificate;
            CertificatePassword = certificatePassword;
            StoreName = storeName;
            Certificate = certificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base64 Encoded certificate.
        /// </summary>
        [JsonProperty(PropertyName = "encodedCertificate")]
        public string EncodedCertificate { get; set; }

        /// <summary>
        /// Gets or sets certificate Password.
        /// </summary>
        [JsonProperty(PropertyName = "certificatePassword")]
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Gets or sets the
        /// System.Security.Cryptography.x509certificates.Storename certificate
        /// store location. Only Root and CertificateAuthority are valid
        /// locations. Possible values include: 'CertificateAuthority', 'Root'
        /// </summary>
        [JsonProperty(PropertyName = "storeName")]
        public string StoreName { get; set; }

        /// <summary>
        /// Gets certificate information.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public CertificateInformation Certificate { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StoreName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StoreName");
            }
            if (Certificate != null)
            {
                Certificate.Validate();
            }
        }
    }
}
