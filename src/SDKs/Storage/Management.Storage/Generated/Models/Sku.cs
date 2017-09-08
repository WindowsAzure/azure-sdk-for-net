// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Storage;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The SKU of the storage account.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Gets or sets the sku name. Required for account
        /// creation; optional for update. Note that in older versions, sku
        /// name was called accountType. Possible values include:
        /// 'Standard_LRS', 'Standard_GRS', 'Standard_RAGRS', 'Standard_ZRS',
        /// 'Premium_LRS'</param>
        /// <param name="tier">Gets the sku tier. This is based on the SKU
        /// name. Possible values include: 'Standard', 'Premium'</param>
        /// <param name="resourceType">The type of the resource, usually it is
        /// 'storageAccounts'.</param>
        /// <param name="kind">Indicates the type of storage account. Possible
        /// values include: 'Storage', 'BlobStorage'</param>
        /// <param name="locations">The set of locations that the SKU is
        /// available. This will be supported and registered Azure Geo Regions
        /// (e.g. West US, East US, Southeast Asia, etc.).</param>
        /// <param name="capabilities">The capability information in the
        /// specified sku, including file encryption, network acls, change
        /// notification, etc.</param>
        /// <param name="restrictions">The restrictions because of which SKU
        /// cannot be used. This is empty if there are no restrictions.</param>
        public Sku(SkuName name, SkuTier? tier = default(SkuTier?), string resourceType = default(string), Kind? kind = default(Kind?), IList<string> locations = default(IList<string>), IList<SKUCapability> capabilities = default(IList<SKUCapability>), IList<Restriction> restrictions = default(IList<Restriction>))
        {
            Name = name;
            Tier = tier;
            ResourceType = resourceType;
            Kind = kind;
            Locations = locations;
            Capabilities = capabilities;
            Restrictions = restrictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name. Required for account creation; optional
        /// for update. Note that in older versions, sku name was called
        /// accountType. Possible values include: 'Standard_LRS',
        /// 'Standard_GRS', 'Standard_RAGRS', 'Standard_ZRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SkuName Name { get; set; }

        /// <summary>
        /// Gets the sku tier. This is based on the SKU name. Possible values
        /// include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; private set; }

        /// <summary>
        /// Gets the type of the resource, usually it is 'storageAccounts'.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets indicates the type of storage account. Possible values
        /// include: 'Storage', 'BlobStorage'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind? Kind { get; private set; }

        /// <summary>
        /// Gets the set of locations that the SKU is available. This will be
        /// supported and registered Azure Geo Regions (e.g. West US, East US,
        /// Southeast Asia, etc.).
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; private set; }

        /// <summary>
        /// Gets the capability information in the specified sku, including
        /// file encryption, network acls, change notification, etc.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<SKUCapability> Capabilities { get; private set; }

        /// <summary>
        /// Gets or sets the restrictions because of which SKU cannot be used.
        /// This is empty if there are no restrictions.
        /// </summary>
        [JsonProperty(PropertyName = "restrictions")]
        public IList<Restriction> Restrictions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
