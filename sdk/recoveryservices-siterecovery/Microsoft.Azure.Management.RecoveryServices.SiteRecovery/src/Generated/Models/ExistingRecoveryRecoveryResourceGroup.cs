// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Existing recovery resource group input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Existing")]
    public partial class ExistingRecoveryRecoveryResourceGroup : RecoveryResourceGroupCustomDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExistingRecoveryRecoveryResourceGroup class.
        /// </summary>
        public ExistingRecoveryRecoveryResourceGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExistingRecoveryRecoveryResourceGroup class.
        /// </summary>
        /// <param name="recoveryResourceGroupId">The recovery resource group
        /// Id. Valid for V2 scenarios.</param>
        public ExistingRecoveryRecoveryResourceGroup(string recoveryResourceGroupId = default(string))
        {
            RecoveryResourceGroupId = recoveryResourceGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery resource group Id. Valid for V2
        /// scenarios.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId { get; set; }

    }
}
