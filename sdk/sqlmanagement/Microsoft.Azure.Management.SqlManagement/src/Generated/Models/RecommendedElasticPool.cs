// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a recommended elastic pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecommendedElasticPool : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPool class.
        /// </summary>
        public RecommendedElasticPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPool class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="databaseEdition">The edition of the recommended
        /// elastic pool. The ElasticPoolEdition enumeration contains all the
        /// valid editions. Possible values include: 'Basic', 'Standard',
        /// 'Premium', 'GeneralPurpose', 'BusinessCritical'</param>
        /// <param name="dtu">The DTU for the recommended elastic pool.</param>
        /// <param name="databaseDtuMin">The minimum DTU for the
        /// database.</param>
        /// <param name="databaseDtuMax">The maximum DTU for the
        /// database.</param>
        /// <param name="storageMB">Gets storage size in megabytes.</param>
        /// <param name="observationPeriodStart">The observation period start
        /// (ISO8601 format).</param>
        /// <param name="observationPeriodEnd">The observation period start
        /// (ISO8601 format).</param>
        /// <param name="maxObservedDtu">Gets maximum observed DTU.</param>
        /// <param name="maxObservedStorageMB">Gets maximum observed storage in
        /// megabytes.</param>
        /// <param name="databases">The list of databases in this pool.
        /// Expanded property</param>
        /// <param name="metrics">The list of databases housed in the server.
        /// Expanded property</param>
        public RecommendedElasticPool(string id = default(string), string name = default(string), string type = default(string), ElasticPoolEdition? databaseEdition = default(ElasticPoolEdition?), double? dtu = default(double?), double? databaseDtuMin = default(double?), double? databaseDtuMax = default(double?), double? storageMB = default(double?), System.DateTime? observationPeriodStart = default(System.DateTime?), System.DateTime? observationPeriodEnd = default(System.DateTime?), double? maxObservedDtu = default(double?), double? maxObservedStorageMB = default(double?), IList<TrackedResource> databases = default(IList<TrackedResource>), IList<RecommendedElasticPoolMetric> metrics = default(IList<RecommendedElasticPoolMetric>))
            : base(id, name, type)
        {
            DatabaseEdition = databaseEdition;
            Dtu = dtu;
            DatabaseDtuMin = databaseDtuMin;
            DatabaseDtuMax = databaseDtuMax;
            StorageMB = storageMB;
            ObservationPeriodStart = observationPeriodStart;
            ObservationPeriodEnd = observationPeriodEnd;
            MaxObservedDtu = maxObservedDtu;
            MaxObservedStorageMB = maxObservedStorageMB;
            Databases = databases;
            Metrics = metrics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the edition of the recommended elastic pool. The
        /// ElasticPoolEdition enumeration contains all the valid editions.
        /// Possible values include: 'Basic', 'Standard', 'Premium',
        /// 'GeneralPurpose', 'BusinessCritical'
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseEdition")]
        public ElasticPoolEdition? DatabaseEdition { get; private set; }

        /// <summary>
        /// Gets or sets the DTU for the recommended elastic pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dtu")]
        public double? Dtu { get; set; }

        /// <summary>
        /// Gets or sets the minimum DTU for the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseDtuMin")]
        public double? DatabaseDtuMin { get; set; }

        /// <summary>
        /// Gets or sets the maximum DTU for the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseDtuMax")]
        public double? DatabaseDtuMax { get; set; }

        /// <summary>
        /// Gets storage size in megabytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageMB")]
        public double? StorageMB { get; set; }

        /// <summary>
        /// Gets the observation period start (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.observationPeriodStart")]
        public System.DateTime? ObservationPeriodStart { get; private set; }

        /// <summary>
        /// Gets the observation period start (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.observationPeriodEnd")]
        public System.DateTime? ObservationPeriodEnd { get; private set; }

        /// <summary>
        /// Gets maximum observed DTU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxObservedDtu")]
        public double? MaxObservedDtu { get; private set; }

        /// <summary>
        /// Gets maximum observed storage in megabytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxObservedStorageMB")]
        public double? MaxObservedStorageMB { get; private set; }

        /// <summary>
        /// Gets the list of databases in this pool. Expanded property
        /// </summary>
        [JsonProperty(PropertyName = "properties.databases")]
        public IList<TrackedResource> Databases { get; private set; }

        /// <summary>
        /// Gets the list of databases housed in the server. Expanded property
        /// </summary>
        [JsonProperty(PropertyName = "properties.metrics")]
        public IList<RecommendedElasticPoolMetric> Metrics { get; private set; }

    }
}
