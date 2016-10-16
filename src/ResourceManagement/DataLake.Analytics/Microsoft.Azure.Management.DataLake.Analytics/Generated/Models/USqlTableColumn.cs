// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL table column item.
    /// </summary>
    public partial class USqlTableColumn
    {
        /// <summary>
        /// Initializes a new instance of the USqlTableColumn class.
        /// </summary>
        public USqlTableColumn() { }

        /// <summary>
        /// Initializes a new instance of the USqlTableColumn class.
        /// </summary>
        /// <param name="name">the name of the column in the table.</param>
        /// <param name="type">the object type of the specified column (such
        /// as System.String).</param>
        public USqlTableColumn(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Gets or sets the name of the column in the table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the object type of the specified column (such as
        /// System.String).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
