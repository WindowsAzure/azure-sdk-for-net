// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity excel source. </summary>
    public partial class ExcelSource : CopySource
    {
        /// <summary> Initializes a new instance of ExcelSource. </summary>
        public ExcelSource()
        {
            AdditionalColumns = new ChangeTrackingList<AdditionalColumns>();
            Type = "ExcelSource";
        }

        /// <summary> Initializes a new instance of ExcelSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="storeSettings"> Excel store settings. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </param>
        internal ExcelSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, StoreReadSettings storeSettings, IList<AdditionalColumns> additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            StoreSettings = storeSettings;
            AdditionalColumns = additionalColumns;
            Type = type ?? "ExcelSource";
        }

        /// <summary> Excel store settings. </summary>
        public StoreReadSettings StoreSettings { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </summary>
        public IList<AdditionalColumns> AdditionalColumns { get; }
    }
}
