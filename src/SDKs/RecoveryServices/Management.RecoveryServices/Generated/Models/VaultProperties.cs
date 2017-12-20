// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the vault.
    /// </summary>
    public partial class VaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the VaultProperties class.
        /// </summary>
        public VaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultProperties class.
        /// </summary>
        /// <param name="provisioningState">Provisioning State.</param>
        public VaultProperties(string provisioningState = default(string), UpgradeDetails upgradeDetails = default(UpgradeDetails))
        {
            ProvisioningState = provisioningState;
            UpgradeDetails = upgradeDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning State.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgradeDetails")]
        public UpgradeDetails UpgradeDetails { get; set; }

    }
}
