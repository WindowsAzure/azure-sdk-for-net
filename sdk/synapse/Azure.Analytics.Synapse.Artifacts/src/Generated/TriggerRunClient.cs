// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The TriggerRun service client. </summary>
    public partial class TriggerRunClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TriggerRunRestClient RestClient { get; }

        /// <summary> Initializes a new instance of TriggerRunClient for mocking. </summary>
        protected TriggerRunClient()
        {
        }

        /// <summary> Initializes a new instance of TriggerRunClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal TriggerRunClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new TriggerRunRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Rerun single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RerunTriggerInstanceAsync(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerRunClient.RerunTriggerInstance");
            scope.Start();
            try
            {
                return await RestClient.RerunTriggerInstanceAsync(triggerName, runId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Rerun single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RerunTriggerInstance(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerRunClient.RerunTriggerInstance");
            scope.Start();
            try
            {
                return RestClient.RerunTriggerInstance(triggerName, runId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelTriggerInstanceAsync(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerRunClient.CancelTriggerInstance");
            scope.Start();
            try
            {
                return await RestClient.CancelTriggerInstanceAsync(triggerName, runId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelTriggerInstance(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerRunClient.CancelTriggerInstance");
            scope.Start();
            try
            {
                return RestClient.CancelTriggerInstance(triggerName, runId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query trigger runs. </summary>
        /// <param name="filterParameters"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TriggerRunsQueryResponse>> QueryTriggerRunsByWorkspaceAsync(RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerRunClient.QueryTriggerRunsByWorkspace");
            scope.Start();
            try
            {
                return await RestClient.QueryTriggerRunsByWorkspaceAsync(filterParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query trigger runs. </summary>
        /// <param name="filterParameters"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TriggerRunsQueryResponse> QueryTriggerRunsByWorkspace(RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerRunClient.QueryTriggerRunsByWorkspace");
            scope.Start();
            try
            {
                return RestClient.QueryTriggerRunsByWorkspace(filterParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
