// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Updates network mappings input.
    /// </summary>
    [JsonObject("AzureToAzure")]
    public partial class AzureToAzureUpdateNetworkMappingInput : FabricSpecificUpdateNetworkMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureToAzureUpdateNetworkMappingInput class.
        /// </summary>
        public AzureToAzureUpdateNetworkMappingInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureToAzureUpdateNetworkMappingInput class.
        /// </summary>
        public AzureToAzureUpdateNetworkMappingInput(string primaryNetworkId = default(string))
        {
            PrimaryNetworkId = primaryNetworkId;
        }

        /// <summary>
        /// The primary azure vnet Id.
        /// </summary>
        [JsonProperty(PropertyName = "primaryNetworkId")]
        public string PrimaryNetworkId { get; set; }

    }
}
