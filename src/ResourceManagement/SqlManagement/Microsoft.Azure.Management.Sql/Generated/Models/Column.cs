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
    /// Represents an Azure SQL Database table column.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Column : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Column class.
        /// </summary>
        public Column() { }

        /// <summary>
        /// Initializes a new instance of the Column class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource ID</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="columnType">The type of Azure SQL Database table
        /// column.</param>
        public Column(string location, string name = default(string), string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string columnType = default(string))
            : base(location, name, id, type, tags)
        {
            ColumnType = columnType;
        }

        /// <summary>
        /// Gets the type of Azure SQL Database table column.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columnType")]
        public string ColumnType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
