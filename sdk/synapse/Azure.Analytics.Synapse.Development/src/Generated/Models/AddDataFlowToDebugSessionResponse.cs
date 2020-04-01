// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Response body structure for starting data flow debug session. </summary>
    public partial class AddDataFlowToDebugSessionResponse
    {
        /// <summary> Initializes a new instance of AddDataFlowToDebugSessionResponse. </summary>
        internal AddDataFlowToDebugSessionResponse()
        {
        }

        /// <summary> Initializes a new instance of AddDataFlowToDebugSessionResponse. </summary>
        /// <param name="jobVersion"> The ID of data flow debug job version. </param>
        internal AddDataFlowToDebugSessionResponse(string jobVersion)
        {
            JobVersion = jobVersion;
        }

        /// <summary> The ID of data flow debug job version. </summary>
        public string JobVersion { get; }
    }
}
