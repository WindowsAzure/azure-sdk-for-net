// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The SparkJobDefinition service client. </summary>
    public partial class SparkJobDefinitionClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SparkJobDefinitionRestClient RestClient { get; }

        /// <summary> Initializes a new instance of SparkJobDefinitionClient for mocking. </summary>
        protected SparkJobDefinitionClient()
        {
        }

        /// <summary> Initializes a new instance of SparkJobDefinitionClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal SparkJobDefinitionClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new SparkJobDefinitionRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="ifNoneMatch"> ETag of the Spark Job Definition entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SparkJobDefinitionResource>> GetSparkJobDefinitionAsync(string sparkJobDefinitionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.GetSparkJobDefinition");
            scope.Start();
            try
            {
                return await RestClient.GetSparkJobDefinitionAsync(sparkJobDefinitionName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="ifNoneMatch"> ETag of the Spark Job Definition entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SparkJobDefinitionResource> GetSparkJobDefinition(string sparkJobDefinitionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.GetSparkJobDefinition");
            scope.Start();
            try
            {
                return RestClient.GetSparkJobDefinition(sparkJobDefinitionName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists spark job definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SparkJobDefinitionResource> GetSparkJobDefinitionsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SparkJobDefinitionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.GetSparkJobDefinitionsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetSparkJobDefinitionsByWorkspaceAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SparkJobDefinitionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.GetSparkJobDefinitionsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetSparkJobDefinitionsByWorkspaceNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists spark job definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SparkJobDefinitionResource> GetSparkJobDefinitionsByWorkspace(CancellationToken cancellationToken = default)
        {
            Page<SparkJobDefinitionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.GetSparkJobDefinitionsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetSparkJobDefinitionsByWorkspace(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SparkJobDefinitionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.GetSparkJobDefinitionsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetSparkJobDefinitionsByWorkspaceNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="sparkJobDefinition"> Spark Job Definition resource definition. </param>
        /// <param name="ifMatch"> ETag of the Spark Job Definition entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="sparkJobDefinition"/> is null. </exception>
        public virtual async Task<SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation> StartCreateOrUpdateSparkJobDefinitionAsync(string sparkJobDefinitionName, SparkJobDefinitionResource sparkJobDefinition, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (sparkJobDefinition == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinition));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartCreateOrUpdateSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateSparkJobDefinitionAsync(sparkJobDefinitionName, sparkJobDefinition, ifMatch, cancellationToken).ConfigureAwait(false);
                return new SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateSparkJobDefinitionRequest(sparkJobDefinitionName, sparkJobDefinition, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="sparkJobDefinition"> Spark Job Definition resource definition. </param>
        /// <param name="ifMatch"> ETag of the Spark Job Definition entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="sparkJobDefinition"/> is null. </exception>
        public virtual SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation StartCreateOrUpdateSparkJobDefinition(string sparkJobDefinitionName, SparkJobDefinitionResource sparkJobDefinition, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (sparkJobDefinition == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinition));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartCreateOrUpdateSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateSparkJobDefinition(sparkJobDefinitionName, sparkJobDefinition, ifMatch, cancellationToken);
                return new SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateSparkJobDefinitionRequest(sparkJobDefinitionName, sparkJobDefinition, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public virtual async Task<SparkJobDefinitionDeleteSparkJobDefinitionOperation> StartDeleteSparkJobDefinitionAsync(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartDeleteSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteSparkJobDefinitionAsync(sparkJobDefinitionName, cancellationToken).ConfigureAwait(false);
                return new SparkJobDefinitionDeleteSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteSparkJobDefinitionRequest(sparkJobDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a Spark Job Definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public virtual SparkJobDefinitionDeleteSparkJobDefinitionOperation StartDeleteSparkJobDefinition(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartDeleteSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteSparkJobDefinition(sparkJobDefinitionName, cancellationToken);
                return new SparkJobDefinitionDeleteSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteSparkJobDefinitionRequest(sparkJobDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Executes the spark job definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public virtual async Task<SparkJobDefinitionExecuteSparkJobDefinitionOperation> StartExecuteSparkJobDefinitionAsync(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartExecuteSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ExecuteSparkJobDefinitionAsync(sparkJobDefinitionName, cancellationToken).ConfigureAwait(false);
                return new SparkJobDefinitionExecuteSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateExecuteSparkJobDefinitionRequest(sparkJobDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Executes the spark job definition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> is null. </exception>
        public virtual SparkJobDefinitionExecuteSparkJobDefinitionOperation StartExecuteSparkJobDefinition(string sparkJobDefinitionName, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartExecuteSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ExecuteSparkJobDefinition(sparkJobDefinitionName, cancellationToken);
                return new SparkJobDefinitionExecuteSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateExecuteSparkJobDefinitionRequest(sparkJobDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a sparkJobDefinition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="request"/> is null. </exception>
        public virtual async Task<SparkJobDefinitionRenameSparkJobDefinitionOperation> StartRenameSparkJobDefinitionAsync(string sparkJobDefinitionName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartRenameSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenameSparkJobDefinitionAsync(sparkJobDefinitionName, request, cancellationToken).ConfigureAwait(false);
                return new SparkJobDefinitionRenameSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameSparkJobDefinitionRequest(sparkJobDefinitionName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a sparkJobDefinition. </summary>
        /// <param name="sparkJobDefinitionName"> The spark job definition name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionName"/> or <paramref name="request"/> is null. </exception>
        public virtual SparkJobDefinitionRenameSparkJobDefinitionOperation StartRenameSparkJobDefinition(string sparkJobDefinitionName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartRenameSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RenameSparkJobDefinition(sparkJobDefinitionName, request, cancellationToken);
                return new SparkJobDefinitionRenameSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameSparkJobDefinitionRequest(sparkJobDefinitionName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Debug the spark job definition. </summary>
        /// <param name="sparkJobDefinitionAzureResource"> Spark Job Definition resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionAzureResource"/> is null. </exception>
        public virtual async Task<SparkJobDefinitionDebugSparkJobDefinitionOperation> StartDebugSparkJobDefinitionAsync(SparkJobDefinitionResource sparkJobDefinitionAzureResource, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionAzureResource == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionAzureResource));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartDebugSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DebugSparkJobDefinitionAsync(sparkJobDefinitionAzureResource, cancellationToken).ConfigureAwait(false);
                return new SparkJobDefinitionDebugSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateDebugSparkJobDefinitionRequest(sparkJobDefinitionAzureResource).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Debug the spark job definition. </summary>
        /// <param name="sparkJobDefinitionAzureResource"> Spark Job Definition resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkJobDefinitionAzureResource"/> is null. </exception>
        public virtual SparkJobDefinitionDebugSparkJobDefinitionOperation StartDebugSparkJobDefinition(SparkJobDefinitionResource sparkJobDefinitionAzureResource, CancellationToken cancellationToken = default)
        {
            if (sparkJobDefinitionAzureResource == null)
            {
                throw new ArgumentNullException(nameof(sparkJobDefinitionAzureResource));
            }

            using var scope = _clientDiagnostics.CreateScope("SparkJobDefinitionClient.StartDebugSparkJobDefinition");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DebugSparkJobDefinition(sparkJobDefinitionAzureResource, cancellationToken);
                return new SparkJobDefinitionDebugSparkJobDefinitionOperation(_clientDiagnostics, _pipeline, RestClient.CreateDebugSparkJobDefinitionRequest(sparkJobDefinitionAzureResource).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
