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
    /// Represents an Azure SQL Database.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Database : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        public Database() { }

        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="collation">The collation of the Azure SQL
        /// Database.</param>
        /// <param name="creationDate">The creation date of the Azure SQL
        /// Database (ISO8601 format).</param>
        /// <param name="containmentState">The containment state of the Azure
        /// SQL Database.</param>
        /// <param name="currentServiceObjectiveId">The current Service Level
        /// Objective Id of the Azure SQL Database. This is the Id of the
        /// Service Level Objective that is currently active.</param>
        /// <param name="databaseId">The Id of the Azure SQL Database.</param>
        /// <param name="earliestRestoreDate">The recovery period start date
        /// of the Azure SQL Database. This records the start date and time
        /// when recovery is available for this Azure SQL Database (ISO8601
        /// format).</param>
        /// <param name="createMode">Specifies the type of database to create.
        /// Possible values include: 'Copy', 'Default',
        /// 'NonReadableSecondary', 'OnlineSecondary', 'PointInTimeRestore',
        /// 'Recovery', 'Restore'</param>
        /// <param name="sourceDatabaseId">Conditional.  Specifies the
        /// resource Id of the source database.  If createMode is not set to
        /// Default, then this value must be specified.</param>
        /// <param name="edition">The edition of the Azure SQL Database.  The
        /// DatabaseEditions enumeration contains all the valid editions.
        /// Possible values include: 'Web', 'Business', 'Basic', 'Standard',
        /// 'Premium', 'Free', 'Stretch', 'DataWarehouse'</param>
        /// <param name="maxSizeBytes">The max size of the Azure SQL Database
        /// expressed in bytes. Note: Only the following sizes are supported
        /// (in addition to limitations being placed on each edition): { 100
        /// MB | 500 MB |1 GB | 5 GB | 10 GB | 20 GB | 30 GB … 150 GB | 200
        /// GB … 500 GB }</param>
        /// <param name="requestedServiceObjectiveId">The configured Service
        /// Level Objective Id of the Azure SQL Database. This is the Service
        /// Level Objective that is in the process of being applied to the
        /// Azure SQL Database.  Once successfully updated, it will match the
        /// value of currentServiceObjectiveId property.</param>
        /// <param name="requestedServiceObjectiveName">The name of the
        /// configured Service Level Objective of the Azure SQL Database.
        /// This is the Service Level Objective that is in the process of
        /// being applied to the Azure SQL Database.  Once successfully
        /// updated, it will match the value of serviceLevelObjective
        /// property. Possible values include: 'Basic', 'S0', 'S1', 'S2',
        /// 'S3', 'P1', 'P2', 'P3'</param>
        /// <param name="serviceLevelObjective">The current Service Level
        /// Objective of the Azure SQL Database. Possible values include:
        /// 'Basic', 'S0', 'S1', 'S2', 'S3', 'P1', 'P2', 'P3'</param>
        /// <param name="status">The status of the Azure SQL Database.</param>
        /// <param name="elasticPoolName">The name of the Azure SQL Elastic
        /// Pool the database is in.</param>
        /// <param name="defaultSecondaryLocation">The default secondary
        /// region for this database.</param>
        /// <param name="serviceTierAdvisors">The list of service tier
        /// advisors for this database. Expanded property</param>
        /// <param name="upgradeHint">The upgrade hint for this
        /// database.</param>
        /// <param name="schemas">The schemas from this database.</param>
        /// <param name="transparentDataEncryption">The transparent data
        /// encryption info for this database.</param>
        /// <param name="recommendedIndex">The recommended indices for this
        /// database.</param>
        public Database(string location, string name = default(string), string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string collation = default(string), System.DateTime? creationDate = default(System.DateTime?), long? containmentState = default(long?), System.Guid? currentServiceObjectiveId = default(System.Guid?), string databaseId = default(string), System.DateTime? earliestRestoreDate = default(System.DateTime?), string createMode = default(string), string sourceDatabaseId = default(string), string edition = default(string), string maxSizeBytes = default(string), System.Guid? requestedServiceObjectiveId = default(System.Guid?), string requestedServiceObjectiveName = default(string), string serviceLevelObjective = default(string), string status = default(string), string elasticPoolName = default(string), string defaultSecondaryLocation = default(string), System.Collections.Generic.IList<ServiceTierAdvisor> serviceTierAdvisors = default(System.Collections.Generic.IList<ServiceTierAdvisor>), UpgradeHint upgradeHint = default(UpgradeHint), System.Collections.Generic.IList<Schema> schemas = default(System.Collections.Generic.IList<Schema>), System.Collections.Generic.IList<TransparentDataEncryption> transparentDataEncryption = default(System.Collections.Generic.IList<TransparentDataEncryption>), System.Collections.Generic.IList<RecommendedIndex> recommendedIndex = default(System.Collections.Generic.IList<RecommendedIndex>))
            : base(location, name, id, type, tags)
        {
            Collation = collation;
            CreationDate = creationDate;
            ContainmentState = containmentState;
            CurrentServiceObjectiveId = currentServiceObjectiveId;
            DatabaseId = databaseId;
            EarliestRestoreDate = earliestRestoreDate;
            CreateMode = createMode;
            SourceDatabaseId = sourceDatabaseId;
            Edition = edition;
            MaxSizeBytes = maxSizeBytes;
            RequestedServiceObjectiveId = requestedServiceObjectiveId;
            RequestedServiceObjectiveName = requestedServiceObjectiveName;
            ServiceLevelObjective = serviceLevelObjective;
            Status = status;
            ElasticPoolName = elasticPoolName;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            ServiceTierAdvisors = serviceTierAdvisors;
            UpgradeHint = upgradeHint;
            Schemas = schemas;
            TransparentDataEncryption = transparentDataEncryption;
            RecommendedIndex = recommendedIndex;
        }

        /// <summary>
        /// Gets or sets the collation of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets the creation date of the Azure SQL Database (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the containment state of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.containmentState")]
        public long? ContainmentState { get; private set; }

        /// <summary>
        /// Gets the current Service Level Objective Id of the Azure SQL
        /// Database. This is the Id of the Service Level Objective that is
        /// currently active.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.currentServiceObjectiveId")]
        public System.Guid? CurrentServiceObjectiveId { get; private set; }

        /// <summary>
        /// Gets the Id of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseId")]
        public string DatabaseId { get; private set; }

        /// <summary>
        /// Gets the recovery period start date of the Azure SQL Database.
        /// This records the start date and time when recovery is available
        /// for this Azure SQL Database (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; private set; }

        /// <summary>
        /// Gets or sets specifies the type of database to create. Possible
        /// values include: 'Copy', 'Default', 'NonReadableSecondary',
        /// 'OnlineSecondary', 'PointInTimeRestore', 'Recovery', 'Restore'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets conditional.  Specifies the resource Id of the source
        /// database.  If createMode is not set to Default, then this value
        /// must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets the edition of the Azure SQL Database.  The
        /// DatabaseEditions enumeration contains all the valid editions.
        /// Possible values include: 'Web', 'Business', 'Basic', 'Standard',
        /// 'Premium', 'Free', 'Stretch', 'DataWarehouse'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the max size of the Azure SQL Database expressed in
        /// bytes. Note: Only the following sizes are supported (in addition
        /// to limitations being placed on each edition): { 100 MB | 500 MB
        /// |1 GB | 5 GB | 10 GB | 20 GB | 30 GB … 150 GB | 200 GB … 500 GB }
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public string MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the configured Service Level Objective Id of the
        /// Azure SQL Database. This is the Service Level Objective that is
        /// in the process of being applied to the Azure SQL Database.  Once
        /// successfully updated, it will match the value of
        /// currentServiceObjectiveId property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestedServiceObjectiveId")]
        public System.Guid? RequestedServiceObjectiveId { get; set; }

        /// <summary>
        /// Gets or sets the name of the configured Service Level Objective of
        /// the Azure SQL Database. This is the Service Level Objective that
        /// is in the process of being applied to the Azure SQL Database.
        /// Once successfully updated, it will match the value of
        /// serviceLevelObjective property. Possible values include: 'Basic',
        /// 'S0', 'S1', 'S2', 'S3', 'P1', 'P2', 'P3'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestedServiceObjectiveName")]
        public string RequestedServiceObjectiveName { get; set; }

        /// <summary>
        /// Gets the current Service Level Objective of the Azure SQL
        /// Database. Possible values include: 'Basic', 'S0', 'S1', 'S2',
        /// 'S3', 'P1', 'P2', 'P3'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceLevelObjective")]
        public string ServiceLevelObjective { get; private set; }

        /// <summary>
        /// Gets the status of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets the name of the Azure SQL Elastic Pool the database
        /// is in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.elasticPoolName")]
        public string ElasticPoolName { get; set; }

        /// <summary>
        /// Gets the default secondary region for this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.defaultSecondaryLocation")]
        public string DefaultSecondaryLocation { get; private set; }

        /// <summary>
        /// Gets the list of service tier advisors for this database. Expanded
        /// property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceTierAdvisors")]
        public System.Collections.Generic.IList<ServiceTierAdvisor> ServiceTierAdvisors { get; private set; }

        /// <summary>
        /// Gets the upgrade hint for this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.upgradeHint")]
        public UpgradeHint UpgradeHint { get; private set; }

        /// <summary>
        /// Gets the schemas from this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.schemas")]
        public System.Collections.Generic.IList<Schema> Schemas { get; private set; }

        /// <summary>
        /// Gets the transparent data encryption info for this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.transparentDataEncryption")]
        public System.Collections.Generic.IList<TransparentDataEncryption> TransparentDataEncryption { get; private set; }

        /// <summary>
        /// Gets the recommended indices for this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.recommendedIndex")]
        public System.Collections.Generic.IList<RecommendedIndex> RecommendedIndex { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.UpgradeHint != null)
            {
                this.UpgradeHint.Validate();
            }
            if (this.Schemas != null)
            {
                foreach (var element in this.Schemas)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.RecommendedIndex != null)
            {
                foreach (var element1 in this.RecommendedIndex)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
