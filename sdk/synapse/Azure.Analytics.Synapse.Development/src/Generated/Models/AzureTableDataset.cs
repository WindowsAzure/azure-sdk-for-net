// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> The Azure Table storage dataset. </summary>
    public partial class AzureTableDataset : Dataset
    {
        /// <summary> Initializes a new instance of AzureTableDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="tableName"> The table name of the Azure Table storage. Type: string (or Expression with resultType string). </param>
        public AzureTableDataset(LinkedServiceReference linkedServiceName, object tableName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            TableName = tableName;
            Type = "AzureTable";
        }

        /// <summary> Initializes a new instance of AzureTableDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="tableName"> The table name of the Azure Table storage. Type: string (or Expression with resultType string). </param>
        internal AzureTableDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object tableName) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            TableName = tableName;
            Type = type ?? "AzureTable";
        }

        /// <summary> The table name of the Azure Table storage. Type: string (or Expression with resultType string). </summary>
        public object TableName { get; set; }
    }
}
