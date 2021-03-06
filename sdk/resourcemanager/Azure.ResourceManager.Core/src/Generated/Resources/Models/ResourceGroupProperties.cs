// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Core
{
    /// <summary> The resource group properties. </summary>
    public partial class ResourceGroupProperties
    {
        /// <summary> Initializes a new instance of ResourceGroupProperties. </summary>
        public ResourceGroupProperties()
        {
        }

        /// <summary> Initializes a new instance of ResourceGroupProperties. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        internal ResourceGroupProperties(string provisioningState)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
