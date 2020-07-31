// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Messaging.EventGrid.Models;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> Job finished event data. </summary>
    public partial class MediaJobFinishedEventData : MediaJobStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobFinishedEventData. </summary>
        internal MediaJobFinishedEventData()
        {
            Outputs = new ChangeTrackingList<MediaJobOutput>();
        }

        /// <summary> Initializes a new instance of MediaJobFinishedEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="state"> The new state of the Job. </param>
        /// <param name="correlationData"> Gets the Job correlation data. </param>
        /// <param name="outputs"> Gets the Job outputs. </param>
        internal MediaJobFinishedEventData(MediaJobState? previousState, MediaJobState? state, IReadOnlyDictionary<string, string> correlationData, IReadOnlyList<MediaJobOutput> outputs) : base(previousState, state, correlationData)
        {
            Outputs = outputs;
        }

        /// <summary> Gets the Job outputs. </summary>
        public IReadOnlyList<MediaJobOutput> Outputs { get; }
    }
}
