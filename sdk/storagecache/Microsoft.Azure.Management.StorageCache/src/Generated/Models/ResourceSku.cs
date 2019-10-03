// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A resource SKU
    /// </summary>
    public partial class ResourceSku
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        public ResourceSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        /// <param name="resourceType">The type of resource the sku applies
        /// to.</param>
        /// <param name="capabilities">A list of capabilities of this SKU, such
        /// as throughput or ops/sec</param>
        /// <param name="locations">The set of locations that the SKU is
        /// available. This will be supported and registered Azure Geo Regions
        /// (e.g. West US, East US, Southeast Asia, etc.).</param>
        /// <param name="locationInfo">The set of locations that the SKU is
        /// available.</param>
        /// <param name="name">The name of this sku.</param>
        /// <param name="restrictions">The restrictions because of which SKU
        /// cannot be used. This is empty if there are no restrictions.</param>
        public ResourceSku(string resourceType = default(string), IList<ResourceSkuCapabilities> capabilities = default(IList<ResourceSkuCapabilities>), IList<string> locations = default(IList<string>), IList<ResourceSkuLocationInfo> locationInfo = default(IList<ResourceSkuLocationInfo>), string name = default(string), IList<Restriction> restrictions = default(IList<Restriction>))
        {
            ResourceType = resourceType;
            Capabilities = capabilities;
            Locations = locations;
            LocationInfo = locationInfo;
            Name = name;
            Restrictions = restrictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of resource the sku applies to.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets or sets a list of capabilities of this SKU, such as throughput
        /// or ops/sec
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<ResourceSkuCapabilities> Capabilities { get; set; }

        /// <summary>
        /// Gets the set of locations that the SKU is available. This will be
        /// supported and registered Azure Geo Regions (e.g. West US, East US,
        /// Southeast Asia, etc.).
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; private set; }

        /// <summary>
        /// Gets or sets the set of locations that the SKU is available.
        /// </summary>
        [JsonProperty(PropertyName = "locationInfo")]
        public IList<ResourceSkuLocationInfo> LocationInfo { get; set; }

        /// <summary>
        /// Gets or sets the name of this sku.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the restrictions because of which SKU cannot be used.
        /// This is empty if there are no restrictions.
        /// </summary>
        [JsonProperty(PropertyName = "restrictions")]
        public IList<Restriction> Restrictions { get; set; }

    }
}
