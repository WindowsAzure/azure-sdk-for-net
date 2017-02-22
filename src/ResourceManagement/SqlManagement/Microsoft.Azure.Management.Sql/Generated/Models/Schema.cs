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
    /// Represents an Azure SQL Database schema.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Schema : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        public Schema() { }

        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource ID</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="tables">The tables from this database.</param>
        public Schema(string location, string name = default(string), string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IList<Table> tables = default(System.Collections.Generic.IList<Table>))
            : base(location, name, id, type, tags)
        {
            Tables = tables;
        }

        /// <summary>
        /// Gets the tables from this database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tables")]
        public System.Collections.Generic.IList<Table> Tables { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Tables != null)
            {
                foreach (var element in this.Tables)
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
