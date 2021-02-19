// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for data flow preview data. </summary>
    public partial class DataFlowDebugPreviewDataRequest
    {

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; }
        /// <summary> The data flow which contains the debug session. </summary>
        public string DataFlowName { get; }
        /// <summary> The output stream name. </summary>
        public string StreamName { get; }
        /// <summary> The row limit for preview request. </summary>
        public int? RowLimits { get; }
    }
}
