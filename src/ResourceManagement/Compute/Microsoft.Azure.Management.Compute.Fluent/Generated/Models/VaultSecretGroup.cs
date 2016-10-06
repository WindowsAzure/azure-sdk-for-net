// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a set of certificates which are all in the same Key Vault.
    /// </summary>
    public partial class VaultSecretGroup
    {
        /// <summary>
        /// Initializes a new instance of the VaultSecretGroup class.
        /// </summary>
        public VaultSecretGroup() { }

        /// <summary>
        /// Initializes a new instance of the VaultSecretGroup class.
        /// </summary>
        /// <param name="sourceVault">the Relative URL of the Key Vault
        /// containing all of the certificates in VaultCertificates.</param>
        /// <param name="vaultCertificates">the list of key vault references
        /// in SourceVault which contain certificates</param>
        public VaultSecretGroup(Microsoft.Azure.Management.Resource.Fluent.SubResource sourceVault = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), System.Collections.Generic.IList<VaultCertificate> vaultCertificates = default(System.Collections.Generic.IList<VaultCertificate>))
        {
            SourceVault = sourceVault;
            VaultCertificates = vaultCertificates;
        }

        /// <summary>
        /// Gets or sets the Relative URL of the Key Vault containing all of
        /// the certificates in VaultCertificates.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceVault")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource SourceVault { get; set; }

        /// <summary>
        /// Gets or sets the list of key vault references in SourceVault which
        /// contain certificates
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vaultCertificates")]
        public System.Collections.Generic.IList<VaultCertificate> VaultCertificates { get; set; }

    }
}
