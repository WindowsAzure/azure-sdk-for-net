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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// InMageRcm fabric provider specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcm")]
    public partial class InMageRcmFabricCreationInput : FabricSpecificCreationInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmFabricCreationInput
        /// class.
        /// </summary>
        public InMageRcmFabricCreationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmFabricCreationInput
        /// class.
        /// </summary>
        /// <param name="vmwareSiteId">The ARM Id of the VMware site.</param>
        /// <param name="physicalSiteId">The ARM Id of the physical
        /// site.</param>
        /// <param name="sourceAgentIdentity">The identity provider input for
        /// source agent authentication.</param>
        public InMageRcmFabricCreationInput(string vmwareSiteId, string physicalSiteId, IdentityProviderInput sourceAgentIdentity)
        {
            VmwareSiteId = vmwareSiteId;
            PhysicalSiteId = physicalSiteId;
            SourceAgentIdentity = sourceAgentIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM Id of the VMware site.
        /// </summary>
        [JsonProperty(PropertyName = "vmwareSiteId")]
        public string VmwareSiteId { get; set; }

        /// <summary>
        /// Gets or sets the ARM Id of the physical site.
        /// </summary>
        [JsonProperty(PropertyName = "physicalSiteId")]
        public string PhysicalSiteId { get; set; }

        /// <summary>
        /// Gets or sets the identity provider input for source agent
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAgentIdentity")]
        public IdentityProviderInput SourceAgentIdentity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VmwareSiteId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmwareSiteId");
            }
            if (PhysicalSiteId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PhysicalSiteId");
            }
            if (SourceAgentIdentity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceAgentIdentity");
            }
            if (SourceAgentIdentity != null)
            {
                SourceAgentIdentity.Validate();
            }
        }
    }
}
