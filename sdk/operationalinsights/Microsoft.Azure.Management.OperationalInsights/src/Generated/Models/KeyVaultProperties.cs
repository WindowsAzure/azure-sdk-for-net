// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The key vault properties.
    /// </summary>
    public partial class KeyVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultProperties class.
        /// </summary>
        public KeyVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultProperties class.
        /// </summary>
        /// <param name="keyVaultUri">The Key Vault uri which holds they key
        /// associated with the Log Analytics cluster.</param>
        /// <param name="keyName">The name of the key associated with the Log
        /// Analytics cluster.</param>
        /// <param name="keyVersion">The version of the key associated with the
        /// Log Analytics cluster.</param>
        /// <param name="keyRsaSize">Selected key minimum required
        /// size.</param>
        public KeyVaultProperties(string keyVaultUri = default(string), string keyName = default(string), string keyVersion = default(string), int? keyRsaSize = default(int?))
        {
            KeyVaultUri = keyVaultUri;
            KeyName = keyName;
            KeyVersion = keyVersion;
            KeyRsaSize = keyRsaSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Key Vault uri which holds they key associated with
        /// the Log Analytics cluster.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultUri")]
        public string KeyVaultUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the key associated with the Log Analytics
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Gets or sets the version of the key associated with the Log
        /// Analytics cluster.
        /// </summary>
        [JsonProperty(PropertyName = "keyVersion")]
        public string KeyVersion { get; set; }

        /// <summary>
        /// Gets or sets selected key minimum required size.
        /// </summary>
        [JsonProperty(PropertyName = "keyRsaSize")]
        public int? KeyRsaSize { get; set; }

    }
}
