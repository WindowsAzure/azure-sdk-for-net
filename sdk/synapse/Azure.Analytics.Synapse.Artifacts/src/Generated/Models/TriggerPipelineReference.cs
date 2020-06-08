// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Pipeline that needs to be triggered with the given parameters. </summary>
    public partial class TriggerPipelineReference
    {
        /// <summary> Initializes a new instance of TriggerPipelineReference. </summary>
        public TriggerPipelineReference()
        {
        }

        /// <summary> Initializes a new instance of TriggerPipelineReference. </summary>
        /// <param name="pipelineReference"> Pipeline reference. </param>
        /// <param name="parameters"> Pipeline parameters. </param>
        internal TriggerPipelineReference(PipelineReference pipelineReference, IDictionary<string, object> parameters)
        {
            PipelineReference = pipelineReference;
            Parameters = parameters;
        }

        /// <summary> Pipeline reference. </summary>
        public PipelineReference PipelineReference { get; set; }
        /// <summary> Pipeline parameters. </summary>
        public IDictionary<string, object> Parameters { get; set; }
    }
}
