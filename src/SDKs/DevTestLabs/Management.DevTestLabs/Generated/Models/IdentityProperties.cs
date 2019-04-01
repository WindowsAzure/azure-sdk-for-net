// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a managed identity
    /// </summary>
    public partial class IdentityProperties
    {
        /// <summary>
        /// Initializes a new instance of the IdentityProperties class.
        /// </summary>
        public IdentityProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityProperties class.
        /// </summary>
        /// <param name="type">Managed identity.</param>
        /// <param name="principalId">The principal id of resource
        /// identity.</param>
        /// <param name="tenantId">The tenant identifier of resource.</param>
        /// <param name="clientSecretUrl">The client secret URL of the
        /// identity.</param>
        public IdentityProperties(string type = default(string), string principalId = default(string), string tenantId = default(string), string clientSecretUrl = default(string))
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            ClientSecretUrl = clientSecretUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets managed identity.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the principal id of resource identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier of resource.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the client secret URL of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "clientSecretUrl")]
        public string ClientSecretUrl { get; set; }

    }
}
