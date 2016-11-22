// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database table.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class TableInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the TableInner class.
        /// </summary>
        public TableInner() { }

        /// <summary>
        /// Initializes a new instance of the TableInner class.
        /// </summary>
        /// <param name="tableType">The type of Azure SQL Database table.
        /// Possible values include: 'BaseTable', 'View'</param>
        /// <param name="columns">The columns from this table.</param>
        /// <param name="recommendedIndexes">The recommended indices for this
        /// table.</param>
        public TableInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), TableType? tableType = default(TableType?), System.Collections.Generic.IList<ColumnInner> columns = default(System.Collections.Generic.IList<ColumnInner>), System.Collections.Generic.IList<RecommendedIndexInner> recommendedIndexes = default(System.Collections.Generic.IList<RecommendedIndexInner>))
            : base(location, id, name, type, tags)
        {
            TableType = tableType;
            Columns = columns;
            RecommendedIndexes = recommendedIndexes;
        }

        /// <summary>
        /// Gets the type of Azure SQL Database table. Possible values
        /// include: 'BaseTable', 'View'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tableType")]
        public TableType? TableType { get; private set; }

        /// <summary>
        /// Gets the columns from this table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columns")]
        public System.Collections.Generic.IList<ColumnInner> Columns { get; private set; }

        /// <summary>
        /// Gets the recommended indices for this table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.recommendedIndexes")]
        public System.Collections.Generic.IList<RecommendedIndexInner> RecommendedIndexes { get; private set; }

    }
}
