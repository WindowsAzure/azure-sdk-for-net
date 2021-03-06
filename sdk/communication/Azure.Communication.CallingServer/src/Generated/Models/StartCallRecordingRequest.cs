// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload start call recording operation. </summary>
    internal partial class StartCallRecordingRequest
    {
        /// <summary> Initializes a new instance of StartCallRecordingRequest. </summary>
        public StartCallRecordingRequest()
        {
        }

        /// <summary> The uri to send notifications to. </summary>
        public string RecordingStateCallbackUri { get; set; }
    }
}
