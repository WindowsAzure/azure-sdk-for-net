// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Teradata source.
    /// </summary>
    public partial class TeradataSource : TabularSource
    {
        /// <summary>
        /// Initializes a new instance of the TeradataSource class.
        /// </summary>
        public TeradataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeradataSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="disableMetricsCollection">If true, disable data store
        /// metrics collection. Default is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="queryTimeout">Query timeout. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects (or Expression with
        /// resultType array of objects).</param>
        /// <param name="query">Teradata query. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="partitionOption">The partition mechanism that will be
        /// used for teradata read in parallel. Possible values include:
        /// "None", "Hash", "DynamicRange".</param>
        /// <param name="partitionSettings">The settings that will be leveraged
        /// for teradata source partitioning.</param>
        public TeradataSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object queryTimeout = default(object), IList<AdditionalColumns> additionalColumns = default(IList<AdditionalColumns>), object query = default(object), object partitionOption = default(object), TeradataPartitionSettings partitionSettings = default(TeradataPartitionSettings))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, queryTimeout, additionalColumns)
        {
            Query = query;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets teradata query. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the partition mechanism that will be used for teradata
        /// read in parallel. Possible values include: "None", "Hash",
        /// "DynamicRange".
        /// </summary>
        [JsonProperty(PropertyName = "partitionOption")]
        public object PartitionOption { get; set; }

        /// <summary>
        /// Gets or sets the settings that will be leveraged for teradata
        /// source partitioning.
        /// </summary>
        [JsonProperty(PropertyName = "partitionSettings")]
        public TeradataPartitionSettings PartitionSettings { get; set; }

    }
}
