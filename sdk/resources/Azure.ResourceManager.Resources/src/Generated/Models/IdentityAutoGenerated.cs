// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Identity for the resource. </summary>
    public partial class IdentityAutoGenerated
    {
        /// <summary> Initializes a new instance of IdentityAutoGenerated. </summary>
        public IdentityAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of IdentityAutoGenerated. </summary>
        /// <param name="principalId"> The principal ID of the resource identity. </param>
        /// <param name="tenantId"> The tenant ID of the resource identity. </param>
        /// <param name="type"> The identity type. This is the only required field when adding a system assigned identity to a resource. </param>
        internal IdentityAutoGenerated(string principalId, string tenantId, ResourceIdentityType? type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> The principal ID of the resource identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant ID of the resource identity. </summary>
        public string TenantId { get; }
        /// <summary> The identity type. This is the only required field when adding a system assigned identity to a resource. </summary>
        public ResourceIdentityType? Type { get; set; }
    }
}
