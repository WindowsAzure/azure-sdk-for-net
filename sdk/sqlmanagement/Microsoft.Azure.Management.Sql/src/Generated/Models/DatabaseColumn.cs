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
    using System.Linq;

    /// <summary>
    /// A database column resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseColumn : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseColumn class.
        /// </summary>
        public DatabaseColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseColumn class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="columnType">The column data type. Possible values
        /// include: 'image', 'text', 'uniqueidentifier', 'date', 'time',
        /// 'datetime2', 'datetimeoffset', 'tinyint', 'smallint', 'int',
        /// 'smalldatetime', 'real', 'money', 'datetime', 'float',
        /// 'sql_variant', 'ntext', 'bit', 'decimal', 'numeric', 'smallmoney',
        /// 'bigint', 'hierarchyid', 'geometry', 'geography', 'varbinary',
        /// 'varchar', 'binary', 'char', 'timestamp', 'nvarchar', 'nchar',
        /// 'xml', 'sysname'</param>
        /// <param name="temporalType">The table temporal type. Possible values
        /// include: 'NonTemporalTable', 'HistoryTable',
        /// 'SystemVersionedTemporalTable'</param>
        /// <param name="memoryOptimized">Whether or not the column belongs to
        /// a memory optimized table.</param>
        /// <param name="isComputed">Whether or not the column is
        /// computed.</param>
        public DatabaseColumn(string id = default(string), string name = default(string), string type = default(string), string columnType = default(string), string temporalType = default(string), bool? memoryOptimized = default(bool?), bool? isComputed = default(bool?))
            : base(id, name, type)
        {
            ColumnType = columnType;
            TemporalType = temporalType;
            MemoryOptimized = memoryOptimized;
            IsComputed = isComputed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the column data type. Possible values include:
        /// 'image', 'text', 'uniqueidentifier', 'date', 'time', 'datetime2',
        /// 'datetimeoffset', 'tinyint', 'smallint', 'int', 'smalldatetime',
        /// 'real', 'money', 'datetime', 'float', 'sql_variant', 'ntext',
        /// 'bit', 'decimal', 'numeric', 'smallmoney', 'bigint', 'hierarchyid',
        /// 'geometry', 'geography', 'varbinary', 'varchar', 'binary', 'char',
        /// 'timestamp', 'nvarchar', 'nchar', 'xml', 'sysname'
        /// </summary>
        [JsonProperty(PropertyName = "properties.columnType")]
        public string ColumnType { get; set; }

        /// <summary>
        /// Gets or sets the table temporal type. Possible values include:
        /// 'NonTemporalTable', 'HistoryTable', 'SystemVersionedTemporalTable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.temporalType")]
        public string TemporalType { get; set; }

        /// <summary>
        /// Gets or sets whether or not the column belongs to a memory
        /// optimized table.
        /// </summary>
        [JsonProperty(PropertyName = "properties.memoryOptimized")]
        public bool? MemoryOptimized { get; set; }

        /// <summary>
        /// Gets or sets whether or not the column is computed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isComputed")]
        public bool? IsComputed { get; set; }

    }
}
