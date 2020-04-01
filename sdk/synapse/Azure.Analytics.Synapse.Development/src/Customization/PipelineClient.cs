﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Development
{
    public partial class PipelineClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClient"/>.
        /// </summary>
        public PipelineClient(Uri endpoint, TokenCredential credential)
            : this(endpoint, credential, DevelopmentClientOptions.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClient"/>.
        /// </summary>
        public PipelineClient(Uri endpoint, TokenCredential credential, DevelopmentClientOptions options)
            : this(new ClientDiagnostics(options),
                  SynapseClientPipeline.Build(options, credential),
                  endpoint.ToString(),
                  options.VersionString)
        {
        }
    }
}
