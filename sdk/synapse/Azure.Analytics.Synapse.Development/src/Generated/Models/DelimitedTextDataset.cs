// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Delimited text dataset. </summary>
    public partial class DelimitedTextDataset : Dataset
    {
        /// <summary> Initializes a new instance of DelimitedTextDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        public DelimitedTextDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "DelimitedText";
        }

        /// <summary> Initializes a new instance of DelimitedTextDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="location"> The location of the delimited text storage. </param>
        /// <param name="columnDelimiter"> The column delimiter. Type: string (or Expression with resultType string). </param>
        /// <param name="rowDelimiter"> The row delimiter. Type: string (or Expression with resultType string). </param>
        /// <param name="encodingName"> The code page name of the preferred encoding. If miss, the default value is UTF-8, unless BOM denotes another Unicode encoding. Refer to the name column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string). </param>
        /// <param name="compressionCodec"> . </param>
        /// <param name="compressionLevel"> The data compression method used for DelimitedText. </param>
        /// <param name="quoteChar"> The quote character. Type: string (or Expression with resultType string). </param>
        /// <param name="escapeChar"> The escape character. Type: string (or Expression with resultType string). </param>
        /// <param name="firstRowAsHeader"> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="nullValue"> The null value string. Type: string (or Expression with resultType string). </param>
        internal DelimitedTextDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, DatasetLocation location, object columnDelimiter, object rowDelimiter, object encodingName, DelimitedTextCompressionCodec? compressionCodec, DatasetCompressionLevel? compressionLevel, object quoteChar, object escapeChar, object firstRowAsHeader, object nullValue) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
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
            Type = type ?? "DelimitedText";
        }

        /// <summary> The location of the delimited text storage. </summary>
        public DatasetLocation Location { get; set; }
        /// <summary> The column delimiter. Type: string (or Expression with resultType string). </summary>
        public object ColumnDelimiter { get; set; }
        /// <summary> The row delimiter. Type: string (or Expression with resultType string). </summary>
        public object RowDelimiter { get; set; }
        /// <summary> The code page name of the preferred encoding. If miss, the default value is UTF-8, unless BOM denotes another Unicode encoding. Refer to the name column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string). </summary>
        public object EncodingName { get; set; }
        public DelimitedTextCompressionCodec? CompressionCodec { get; set; }
        /// <summary> The data compression method used for DelimitedText. </summary>
        public DatasetCompressionLevel? CompressionLevel { get; set; }
        /// <summary> The quote character. Type: string (or Expression with resultType string). </summary>
        public object QuoteChar { get; set; }
        /// <summary> The escape character. Type: string (or Expression with resultType string). </summary>
        public object EscapeChar { get; set; }
        /// <summary> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object FirstRowAsHeader { get; set; }
        /// <summary> The null value string. Type: string (or Expression with resultType string). </summary>
        public object NullValue { get; set; }
    }
}
