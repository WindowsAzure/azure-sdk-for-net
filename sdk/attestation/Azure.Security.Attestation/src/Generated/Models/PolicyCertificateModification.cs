// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.Attestation.Models
{
    /// <summary> The body of the JWT used for the PolicyCertificates APIs. </summary>
    public partial class PolicyCertificateModification
    {
        /// <summary> Initializes a new instance of PolicyCertificateModification. </summary>
        public PolicyCertificateModification()
        {
        }

        /// <summary> Initializes a new instance of PolicyCertificateModification. </summary>
        /// <param name="internalPolicyCertificate"> RFC 7517 Json Web Key describing the certificate. </param>
        internal PolicyCertificateModification(JsonWebKey internalPolicyCertificate)
        {
            InternalPolicyCertificate = internalPolicyCertificate;
        }
    }
}
