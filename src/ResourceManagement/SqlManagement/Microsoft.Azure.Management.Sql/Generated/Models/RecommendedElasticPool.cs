// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Recommended Elastic Pool.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RecommendedElasticPool : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPool class.
        /// </summary>
        public RecommendedElasticPool() { }

        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPool class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource ID</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="databaseEdition">The edition of the Azure SQL
        /// Recommended Elastic Pool. The ElasticPoolEditions enumeration
        /// contains all the valid editions. Possible values include:
        /// 'Basic', 'Standard', 'Premium'</param>
        /// <param name="dtu">The DTU for the Azure Sql Recommended Elastic
        /// Pool.</param>
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
        /// <param name="maxObservedStorageMB">Gets maximum observed storage
        /// in megabytes.</param>
        /// <param name="databases">The list of Azure SQL Databases in this
        /// pool. Expanded property</param>
        /// <param name="metrics">The list of Azure SQL Databases housed in
        /// the server. Expanded property</param>
        public RecommendedElasticPool(string location, string name = default(string), string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string databaseEdition = default(string), double? dtu = default(double?), double? databaseDtuMin = default(double?), double? databaseDtuMax = default(double?), double? storageMB = default(double?), System.DateTime? observationPeriodStart = default(System.DateTime?), System.DateTime? observationPeriodEnd = default(System.DateTime?), double? maxObservedDtu = default(double?), double? maxObservedStorageMB = default(double?), System.Collections.Generic.IList<Database> databases = default(System.Collections.Generic.IList<Database>), System.Collections.Generic.IList<RecommendedElasticPoolMetric> metrics = default(System.Collections.Generic.IList<RecommendedElasticPoolMetric>))
            : base(location, name, id, type, tags)
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
        }

        /// <summary>
        /// Gets the edition of the Azure SQL Recommended Elastic Pool. The
        /// ElasticPoolEditions enumeration contains all the valid editions.
        /// Possible values include: 'Basic', 'Standard', 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseEdition")]
        public string DatabaseEdition { get; private set; }

        /// <summary>
        /// Gets or sets the DTU for the Azure Sql Recommended Elastic Pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dtu")]
        public double? Dtu { get; set; }

        /// <summary>
        /// Gets or sets the minimum DTU for the database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseDtuMin")]
        public double? DatabaseDtuMin { get; set; }

        /// <summary>
        /// Gets or sets the maximum DTU for the database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseDtuMax")]
        public double? DatabaseDtuMax { get; set; }

        /// <summary>
        /// Gets storage size in megabytes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageMB")]
        public double? StorageMB { get; set; }

        /// <summary>
        /// Gets the observation period start (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.observationPeriodStart")]
        public System.DateTime? ObservationPeriodStart { get; private set; }

        /// <summary>
        /// Gets the observation period start (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.observationPeriodEnd")]
        public System.DateTime? ObservationPeriodEnd { get; private set; }

        /// <summary>
        /// Gets maximum observed DTU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.maxObservedDtu")]
        public double? MaxObservedDtu { get; private set; }

        /// <summary>
        /// Gets maximum observed storage in megabytes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.maxObservedStorageMB")]
        public double? MaxObservedStorageMB { get; private set; }

        /// <summary>
        /// Gets the list of Azure SQL Databases in this pool. Expanded
        /// property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databases")]
        public System.Collections.Generic.IList<Database> Databases { get; private set; }

        /// <summary>
        /// Gets the list of Azure SQL Databases housed in the server.
        /// Expanded property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.metrics")]
        public System.Collections.Generic.IList<RecommendedElasticPoolMetric> Metrics { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Databases != null)
            {
                foreach (var element in this.Databases)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
