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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Delimited text dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DelimitedText")]
    [Rest.Serialization.JsonTransformation]
    public partial class DelimitedTextDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the DelimitedTextDataset class.
        /// </summary>
        public DelimitedTextDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelimitedTextDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="location">The location of the delimited text
        /// storage.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="schema">Columns that define the physical type schema
        /// of the dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetSchemaDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="folder">The folder that this Dataset is in. If not
        /// specified, Dataset will appear at the root level.</param>
        /// <param name="columnDelimiter">The column delimiter. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="rowDelimiter">The row delimiter. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="encodingName">The code page name of the preferred
        /// encoding. If miss, the default value is UTF-8, unless BOM denotes
        /// another Unicode encoding. Refer to the name column of the table in
        /// the following link to set supported values:
        /// https://msdn.microsoft.com/library/system.text.encoding.aspx. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="compressionLevel">The data compression method used for
        /// DelimitedText.</param>
        /// <param name="quoteChar">The quote character. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="escapeChar">The escape character. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="firstRowAsHeader">When used as input, treat the first
        /// row of data as headers. When used as output,write the headers into
        /// the output as the first row of data. The default value is false.
        /// Type: boolean (or Expression with resultType boolean).</param>
        /// <param name="nullValue">The null value string. Type: string (or
        /// Expression with resultType string).</param>
        public DelimitedTextDataset(LinkedServiceReference linkedServiceName, DatasetLocation location, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), object structure = default(object), object schema = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), DatasetFolder folder = default(DatasetFolder), object columnDelimiter = default(object), object rowDelimiter = default(object), object encodingName = default(object), object compressionCodec = default(object), object compressionLevel = default(object), object quoteChar = default(object), object escapeChar = default(object), object firstRowAsHeader = default(object), object nullValue = default(object))
            : base(linkedServiceName, additionalProperties, description, structure, schema, parameters, annotations, folder)
        {
            Location = location;
            ColumnDelimiter = columnDelimiter;
            RowDelimiter = rowDelimiter;
            EncodingName = encodingName;
            CompressionCodec = compressionCodec;
            CompressionLevel = compressionLevel;
            QuoteChar = quoteChar;
            EscapeChar = escapeChar;
            FirstRowAsHeader = firstRowAsHeader;
            NullValue = nullValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the delimited text storage.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.location")]
        public DatasetLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the column delimiter. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.columnDelimiter")]
        public object ColumnDelimiter { get; set; }

        /// <summary>
        /// Gets or sets the row delimiter. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.rowDelimiter")]
        public object RowDelimiter { get; set; }

        /// <summary>
        /// Gets or sets the code page name of the preferred encoding. If miss,
        /// the default value is UTF-8, unless BOM denotes another Unicode
        /// encoding. Refer to the name column of the table in the following
        /// link to set supported values:
        /// https://msdn.microsoft.com/library/system.text.encoding.aspx. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encodingName")]
        public object EncodingName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compressionCodec")]
        public object CompressionCodec { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used for DelimitedText.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compressionLevel")]
        public object CompressionLevel { get; set; }

        /// <summary>
        /// Gets or sets the quote character. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.quoteChar")]
        public object QuoteChar { get; set; }

        /// <summary>
        /// Gets or sets the escape character. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.escapeChar")]
        public object EscapeChar { get; set; }

        /// <summary>
        /// Gets or sets when used as input, treat the first row of data as
        /// headers. When used as output,write the headers into the output as
        /// the first row of data. The default value is false. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.firstRowAsHeader")]
        public object FirstRowAsHeader { get; set; }

        /// <summary>
        /// Gets or sets the null value string. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.nullValue")]
        public object NullValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Location != null)
            {
                Location.Validate();
            }
        }
    }
}
