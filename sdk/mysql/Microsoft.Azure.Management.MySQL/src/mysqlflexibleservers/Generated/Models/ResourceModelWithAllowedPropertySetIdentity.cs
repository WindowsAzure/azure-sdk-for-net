// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using System.Linq;

    public partial class ResourceModelWithAllowedPropertySetIdentity : Identity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySetIdentity class.
        /// </summary>
        public ResourceModelWithAllowedPropertySetIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySetIdentity class.
        /// </summary>
        /// <param name="principalId">The principal ID of resource
        /// identity.</param>
        /// <param name="tenantId">The tenant ID of resource.</param>
        /// <param name="type">The identity type. Possible values include:
        /// 'SystemAssigned'</param>
        public ResourceModelWithAllowedPropertySetIdentity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?))
            : base(principalId, tenantId, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
