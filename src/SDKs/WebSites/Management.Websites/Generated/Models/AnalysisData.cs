// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class Representing Detector Evidence used for analysis
    /// </summary>
    public partial class AnalysisData
    {
        /// <summary>
        /// Initializes a new instance of the AnalysisData class.
        /// </summary>
        public AnalysisData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnalysisData class.
        /// </summary>
        /// <param name="source">Name of the Detector</param>
        /// <param name="detectorDefinition">Detector Definition</param>
        /// <param name="metrics">Source Metrics</param>
        /// <param name="data">Additional Source Data</param>
        /// <param name="detectorMetaData">Detector Meta Data</param>
        public AnalysisData(string source = default(string), DetectorDefinition detectorDefinition = default(DetectorDefinition), IList<DiagnosticMetricSet> metrics = default(IList<DiagnosticMetricSet>), IList<IList<NameValuePair>> data = default(IList<IList<NameValuePair>>), ResponseMetaData detectorMetaData = default(ResponseMetaData))
        {
            Source = source;
            DetectorDefinition = detectorDefinition;
            Metrics = metrics;
            Data = data;
            DetectorMetaData = detectorMetaData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Detector
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets detector Definition
        /// </summary>
        [JsonProperty(PropertyName = "detectorDefinition")]
        public DetectorDefinition DetectorDefinition { get; set; }

        /// <summary>
        /// Gets or sets source Metrics
        /// </summary>
        [JsonProperty(PropertyName = "metrics")]
        public IList<DiagnosticMetricSet> Metrics { get; set; }

        /// <summary>
        /// Gets or sets additional Source Data
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<IList<NameValuePair>> Data { get; set; }

        /// <summary>
        /// Gets or sets detector Meta Data
        /// </summary>
        [JsonProperty(PropertyName = "detectorMetaData")]
        public ResponseMetaData DetectorMetaData { get; set; }

    }
}
