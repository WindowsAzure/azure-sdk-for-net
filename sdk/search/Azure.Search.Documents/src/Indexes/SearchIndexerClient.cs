﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using System.Collections.Generic;
using System.Linq;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents
{
    /// <summary>
    /// Azure Cognitive Search client that can be used to manage and query
    /// indexes and documents, as well as manage other resources, on a Search
    /// Service.
    /// </summary>
    public class SearchIndexerClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SearchClientOptions.ServiceVersion _version;

        private DataSourcesRestClient _dataSourcesClient;
        private IndexersRestClient _indexersClient;
        private SkillsetsRestClient _skillsetsClient;
        private string _serviceName;


        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIndexerClient"/> class for mocking.
        /// </summary>
        protected SearchIndexerClient() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIndexerClient"/> class.
        /// </summary>
        /// <param name="endpoint">Required. The URI endpoint of the Search service. This is likely to be similar to "https://{search_service}.search.windows.net". The URI must use HTTPS.</param>
        /// <param name="credential">
        /// Required. The API key credential used to authenticate requests against the Search service.
        /// You need to use an admin key to perform any operations on the SearchIndexerClient.
        /// See <see href="https://docs.microsoft.com/azure/search/search-security-api-keys"/> for more information about API keys in Azure Cognitive Search.
        /// </param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="endpoint"/> or <paramref name="credential"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="endpoint"/> is not using HTTPS.</exception>
        public SearchIndexerClient(Uri endpoint, AzureKeyCredential credential) :
            this(endpoint, credential, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIndexerClient"/> class.
        /// </summary>
        /// <param name="endpoint">Required. The URI endpoint of the Search service. This is likely to be similar to "https://{search_service}.search.windows.net". The URI must use HTTPS.</param>
        /// <param name="credential">
        /// Required. The API key credential used to authenticate requests against the Search service.
        /// You need to use an admin key to perform any operations on the SearchIndexerClient.
        /// See <see href="https://docs.microsoft.com/azure/search/search-security-api-keys"/> for more information about API keys in Azure Cognitive Search.
        /// </param>
        /// <param name="options">Client configuration options for connecting to Azure Cognitive Search.</param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="endpoint"/> or <paramref name="credential"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="endpoint"/> is not using HTTPS.</exception>
        public SearchIndexerClient(
            Uri endpoint,
            AzureKeyCredential credential,
            SearchClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            endpoint.AssertHttpsScheme(nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));

            options ??= new SearchClientOptions();
            Endpoint = endpoint;
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = options.Build(credential);
            _version = options.Version;
        }

        /// <summary>
        /// Gets the URI endpoint of the Search service.  This is likely
        /// to be similar to "https://{search_service}.search.windows.net".
        /// </summary>
        public virtual Uri Endpoint { get; }

        /// <summary>
        /// Gets the name of the Search service.
        /// </summary>
        public virtual string ServiceName =>
            _serviceName ??= Endpoint.GetSearchServiceName();

        /// <summary>
        /// Gets the generated <see cref="DataSourcesRestClient"/> to make requests.
        /// </summary>
        private DataSourcesRestClient DataSourcesClient => LazyInitializer.EnsureInitialized(ref _dataSourcesClient, () => new DataSourcesRestClient(
            _clientDiagnostics,
            _pipeline,
            Endpoint.ToString(),
            _version.ToVersionString())
        );

        /// <summary>
        /// Gets the generated <see cref="IndexersRestClient"/> to make requests.
        /// </summary>
        private IndexersRestClient IndexersClient => LazyInitializer.EnsureInitialized(ref _indexersClient, () => new IndexersRestClient(
            _clientDiagnostics,
            _pipeline,
            Endpoint.ToString(),
            _version.ToVersionString())
        );

        /// <summary>
        /// Gets the generated <see cref="SkillsetsRestClient"/> to make requests.
        /// </summary>
        private SkillsetsRestClient SkillsetsClient => LazyInitializer.EnsureInitialized(ref _skillsetsClient, () => new SkillsetsRestClient(
            _clientDiagnostics,
            _pipeline,
            Endpoint.ToString(),
            _version.ToVersionString())
        );

        #region Data Sources operations
        /// <summary>
        /// Creates a new data source.
        /// </summary>
        /// <param name="dataSource">Required. The <see cref="SearchIndexerDataSource"/> to create.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerDataSource"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSource"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerDataSource> CreateDataSource(
            SearchIndexerDataSource dataSource,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateDataSource)}");
            scope.Start();
            try
            {
                return DataSourcesClient.Create(
                    dataSource,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new data source.
        /// </summary>
        /// <param name="dataSource">Required. The <see cref="SearchIndexerDataSource"/> to create.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerDataSource"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSource"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerDataSource>> CreateDataSourceAsync(
            SearchIndexerDataSource dataSource,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateDataSource)}");
            scope.Start();
            try
            {
                return await DataSourcesClient.CreateAsync(
                    dataSource,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new data source or updates an existing data source.
        /// </summary>
        /// <param name="dataSource">Required. The <see cref="SearchIndexerDataSource"/> to create or update.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerDataSource.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerDataSource"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSource"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerDataSource> CreateOrUpdateDataSource(
            SearchIndexerDataSource dataSource,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateOrUpdateDataSource)}");
            scope.Start();
            try
            {
                return DataSourcesClient.CreateOrUpdate(
                    dataSource?.Name,
                    dataSource,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? dataSource?.ETag?.ToString() : null,
                    null,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new data source or updates an existing data source.
        /// </summary>
        /// <param name="dataSource">Required. The <see cref="SearchIndexerDataSource"/> to create or update.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerDataSource.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerDataSource"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSource"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerDataSource>> CreateOrUpdateDataSourceAsync(
            SearchIndexerDataSource dataSource,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateOrUpdateDataSource)}");
            scope.Start();
            try
            {
                return await DataSourcesClient.CreateOrUpdateAsync(
                    dataSource?.Name,
                    dataSource,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? dataSource?.ETag?.ToString() : null,
                    null,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a data source.
        /// </summary>
        /// <param name="dataSourceName">The name of the <see cref="SearchIndexerDataSource"/> to delete.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSourceName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response DeleteDataSource(
            string dataSourceName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => DeleteDataSource(
                dataSourceName,
                null,
                false,
                options,
                cancellationToken);

        /// <summary>
        /// Deletes a data source.
        /// </summary>
        /// <param name="dataSourceName">The name of the <see cref="SearchIndexerDataSource"/> to delete.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSourceName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> DeleteDataSourceAsync(
            string dataSourceName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => await DeleteDataSourceAsync(
                dataSourceName,
                null,
                false,
                options,
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// Deletes a data source.
        /// </summary>
        /// <param name="dataSource">The <see cref="SearchIndexerDataSource"/> to delete.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerDataSource.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSource"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response DeleteDataSource(
            SearchIndexerDataSource dataSource,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => DeleteDataSource(
                dataSource?.Name,
                dataSource?.ETag,
                onlyIfUnchanged,
                options,
                cancellationToken);

        /// <summary>
        /// Deletes a data source.
        /// </summary>
        /// <param name="dataSource">The <see cref="SearchIndexerDataSource"/> to delete.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerDataSource.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSource"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> DeleteDataSourceAsync(
            SearchIndexerDataSource dataSource,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => await DeleteDataSourceAsync(
                dataSource?.Name,
                dataSource?.ETag,
                onlyIfUnchanged,
                options,
                cancellationToken)
                .ConfigureAwait(false);

        private Response DeleteDataSource(
            string dataSourceName,
            ETag? etag,
            bool onlyIfUnchanged,
            SearchRequestOptions options,
            CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(DeleteDataSource)}");
            scope.Start();
            try
            {
                return DataSourcesClient.Delete(
                    dataSourceName,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? etag?.ToString() : null,
                    null,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        private async Task<Response> DeleteDataSourceAsync(
            string dataSourceName,
            ETag? etag,
            bool onlyIfUnchanged,
            SearchRequestOptions options,
            CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(DeleteDataSource)}");
            scope.Start();
            try
            {
                return await DataSourcesClient.DeleteAsync(
                    dataSourceName,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? etag?.ToString() : null,
                    null,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific <see cref="SearchIndexerDataSource"/>.
        /// </summary>
        /// <param name="dataSourceName">Required. The name of the <see cref="SearchIndexerDataSource"/> to get.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexerDataSource"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSourceName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerDataSource> GetDataSource(
            string dataSourceName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetDataSource)}");
            scope.Start();
            try
            {
                return DataSourcesClient.Get(
                    dataSourceName,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific <see cref="SearchIndexerDataSource"/>.
        /// </summary>
        /// <param name="dataSourceName">Required. The name of the <see cref="SearchIndexerDataSource"/> to get.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexerDataSource"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataSourceName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerDataSource>> GetDataSourceAsync(
            string dataSourceName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetDataSource)}");
            scope.Start();
            try
            {
                return await DataSourcesClient.GetAsync(
                    dataSourceName,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all data sources.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerDataSource"/>.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<IReadOnlyList<SearchIndexerDataSource>> GetDataSources(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetDataSources)}");
            scope.Start();
            try
            {
                Response<ListDataSourcesResult> result = DataSourcesClient.List(
                    Constants.All,
                    options?.ClientRequestId,
                    cancellationToken);

                return Response.FromValue(result.Value.DataSources, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all data sources.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerDataSource"/>.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<IReadOnlyList<SearchIndexerDataSource>>> GetDataSourcesAsync(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetDataSources)}");
            scope.Start();
            try
            {
                Response<ListDataSourcesResult> result = await DataSourcesClient.ListAsync(
                    Constants.All,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(result.Value.DataSources, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all data source names.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerDataSource"/> names.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<IReadOnlyList<string>> GetDataSourceNames(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetDataSourceNames)}");
            scope.Start();
            try
            {
                Response<ListDataSourcesResult> result = DataSourcesClient.List(
                    Constants.NameKey,
                    options?.ClientRequestId,
                    cancellationToken);

                IReadOnlyList<string> names = result.Value.DataSources.Select(value => value.Name).ToArray();
                return Response.FromValue(names, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all data source names.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerDataSource"/> names.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<IReadOnlyList<string>>> GetDataSourceNamesAsync(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetDataSourceNames)}");
            scope.Start();
            try
            {
                Response<ListDataSourcesResult> result = await DataSourcesClient.ListAsync(
                    Constants.NameKey,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);

                IReadOnlyList<string> names = result.Value.DataSources.Select(value => value.Name).ToArray();
                return Response.FromValue(names, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
        #endregion

        #region Indexer operations
        /// <summary>
        /// Creates a new indexer.
        /// </summary>
        /// <param name="indexer">Required. The <see cref="SearchIndex"/> to create.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexer"/> created.
        /// This may differ slightly from what was passed into the service.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexer"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexer> CreateIndexer(
            SearchIndexer indexer,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateIndexer)}");
            scope.Start();
            try
            {
                return IndexersClient.Create(
                    indexer,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new indexer.
        /// </summary>
        /// <param name="indexer">Required. The <see cref="SearchIndexer"/> to create.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexer"/> created.
        /// This may differ slightly from what was passed into the service.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexer"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexer>> CreateIndexerAsync(
            SearchIndexer indexer,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateIndexer)}");
            scope.Start();
            try
            {
                return await IndexersClient.CreateAsync(
                    indexer,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new indexer or updates an existing indexer.
        /// </summary>
        /// <param name="indexer">Required. The <see cref="SearchIndexer"/> to create or update.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexer.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexer"/> created.
        /// This may differ slightly from what was passed into the service.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexer"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexer> CreateOrUpdateIndexer(
            SearchIndexer indexer,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateOrUpdateIndexer)}");
            scope.Start();
            try
            {
                return IndexersClient.CreateOrUpdate(
                    indexer?.Name,
                    indexer,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? indexer?.ETag?.ToString() : null,
                    null,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new indexer or updates an existing indexer.
        /// </summary>
        /// <param name="indexer">Required. The <see cref="SearchIndexer"/> to create or update.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexer.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexer"/> created.
        /// This may differ slightly from what was passed into the service.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexer"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexer>> CreateOrUpdateIndexerAsync(
            SearchIndexer indexer,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateOrUpdateIndexer)}");
            scope.Start();
            try
            {
                return await IndexersClient.CreateOrUpdateAsync(
                    indexer?.Name,
                    indexer,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? indexer?.ETag?.ToString() : null,
                    null,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes an indexer.
        /// </summary>
        /// <param name="indexerName">The name of the <see cref="SearchIndexer"/> to delete.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response DeleteIndexer(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => DeleteIndexer(
                indexerName,
                null,
                false,
                options,
                cancellationToken);

        /// <summary>
        /// Deletes an indexer.
        /// </summary>
        /// <param name="indexerName">The name of the <see cref="SearchIndexer"/> to delete.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> DeleteIndexerAsync(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => await DeleteIndexerAsync(
                indexerName,
                null,
                false,
                options,
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// Deletes an indexer.
        /// </summary>
        /// <param name="indexer">The <see cref="SearchIndexer"/> to delete.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexer.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexer"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response DeleteIndexer(
            SearchIndexer indexer,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => DeleteIndexer(
                indexer?.Name,
                indexer?.ETag,
                onlyIfUnchanged,
                options,
                cancellationToken);

        /// <summary>
        /// Deletes an indexer.
        /// </summary>
        /// <param name="indexer">The <see cref="SearchIndexer"/> to delete.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexer.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexer"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> DeleteIndexerAsync(
            SearchIndexer indexer,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => await DeleteIndexerAsync(
                indexer?.Name,
                indexer?.ETag,
                onlyIfUnchanged,
                options,
                cancellationToken)
                .ConfigureAwait(false);

        private Response DeleteIndexer(
            string indexerName,
            ETag? etag,
            bool onlyIfUnchanged,
            SearchRequestOptions options,
            CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(DeleteIndexer)}");
            scope.Start();
            try
            {
                return IndexersClient.Delete(
                    indexerName,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? etag?.ToString() : null,
                    null,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        private async Task<Response> DeleteIndexerAsync(
            string indexerName,
            ETag? etag,
            bool onlyIfUnchanged,
            SearchRequestOptions options,
            CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(DeleteIndexer)}");
            scope.Start();
            try
            {
                return await IndexersClient.DeleteAsync(
                    indexerName,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? etag?.ToString() : null,
                    null,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific <see cref="SearchIndexer"/>.
        /// </summary>
        /// <param name="indexerName">Required. The name of the <see cref="SearchIndexer"/> to get.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexer"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexer> GetIndexer(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexer)}");
            scope.Start();
            try
            {
                return IndexersClient.Get(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific <see cref="SearchIndexer"/>.
        /// </summary>
        /// <param name="indexerName">Required. The name of the <see cref="SearchIndexer"/> to get.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexer"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexer>> GetIndexerAsync(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexer)}");
            scope.Start();
            try
            {
                return await IndexersClient.GetAsync(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all indexers.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexer"/>.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<IReadOnlyList<SearchIndexer>> GetIndexers(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexers)}");
            scope.Start();
            try
            {
                Response<ListIndexersResult> result = IndexersClient.List(
                    Constants.All,
                    options?.ClientRequestId,
                    cancellationToken);

                return Response.FromValue(result.Value.Indexers, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all indexers.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexer"/>.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<IReadOnlyList<SearchIndexer>>> GetIndexersAsync(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexers)}");
            scope.Start();
            try
            {
                Response<ListIndexersResult> result = await IndexersClient.ListAsync(
                    Constants.All,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(result.Value.Indexers, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all indexer names.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexer"/> names.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<IReadOnlyList<string>> GetIndexerNames(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexerNames)}");
            scope.Start();
            try
            {
                Response<ListIndexersResult> result = IndexersClient.List(
                    Constants.NameKey,
                    options?.ClientRequestId,
                    cancellationToken);

                IReadOnlyList<string> names = result.Value.Indexers.Select(value => value.Name).ToArray();
                return Response.FromValue(names, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all indexer names.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexer"/> names.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<IReadOnlyList<string>>> GetIndexerNamesAsync(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexerNames)}");
            scope.Start();
            try
            {
                Response<ListIndexersResult> result = await IndexersClient.ListAsync(
                    Constants.NameKey,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);

                IReadOnlyList<string> names = result.Value.Indexers.Select(value => value.Name).ToArray();
                return Response.FromValue(names, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the current status and execution history of an indexer.
        /// </summary>
        /// <param name="indexerName">Required. The name of the indexer for which to retrieve status.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexerStatus"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerStatus> GetIndexerStatus(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexerStatus)}");
            scope.Start();
            try
            {
                return IndexersClient.GetStatus(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the current status and execution history of an indexer.
        /// </summary>
        /// <param name="indexerName">Required. The name of the indexer for which to retrieve status.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexerStatus"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerStatus>> GetIndexerStatusAsync(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetIndexerStatus)}");
            scope.Start();
            try
            {
                return await IndexersClient.GetStatusAsync(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Resets the change tracking state associated with an indexer.
        /// </summary>
        /// <param name="indexerName">Required. The name of the indexer to reset.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response ResetIndexer(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(ResetIndexer)}");
            scope.Start();
            try
            {
                return IndexersClient.Reset(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Resets the change tracking state associated with an indexer.
        /// </summary>
        /// <param name="indexerName">Required. The name of the indexer to reset.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> ResetIndexerAsync(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(ResetIndexer)}");
            scope.Start();
            try
            {
                return await IndexersClient.ResetAsync(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Run an indexer now.
        /// </summary>
        /// <param name="indexerName">Required. The name of the indexer to run.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response RunIndexer(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(RunIndexer)}");
            scope.Start();
            try
            {
                return IndexersClient.Run(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Run an indexer now.
        /// </summary>
        /// <param name="indexerName">Required. The name of the indexer to run.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="indexerName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> RunIndexerAsync(
            string indexerName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(RunIndexer)}");
            scope.Start();
            try
            {
                return await IndexersClient.RunAsync(
                    indexerName,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
        #endregion

        #region Skillsets operations
        /// <summary>
        /// Creates a new skillset.
        /// </summary>
        /// <param name="skillset">Required. The <see cref="SearchIndexerSkillset"/> to create.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerSkillset"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillset"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerSkillset> CreateSkillset(
            SearchIndexerSkillset skillset,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateSkillset)}");
            scope.Start();
            try
            {
                return SkillsetsClient.Create(
                    skillset,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new skillset.
        /// </summary>
        /// <param name="skillset">Required. The <see cref="SearchIndexerSkillset"/> to create.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerSkillset"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillset"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerSkillset>> CreateSkillsetAsync(
            SearchIndexerSkillset skillset,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateSkillset)}");
            scope.Start();
            try
            {
                return await SkillsetsClient.CreateAsync(
                    skillset,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new skillset or updates an existing skillset.
        /// </summary>
        /// <param name="skillset">Required. The <see cref="SearchIndexerSkillset"/> to create or update.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerSkillset.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerSkillset"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillset"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerSkillset> CreateOrUpdateSkillset(
            SearchIndexerSkillset skillset,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateOrUpdateSkillset)}");
            scope.Start();
            try
            {
                return SkillsetsClient.CreateOrUpdate(
                    skillset?.Name,
                    skillset,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? skillset?.ETag?.ToString() : null,
                    null,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a new skillset or updates an existing skillset.
        /// </summary>
        /// <param name="skillset">Required. The <see cref="SearchIndexerSkillset"/> to create or update.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerSkillset.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Response{T}"/> from the server containing the <see cref="SearchIndexerSkillset"/> that was created.
        /// This may differ slightly from what was passed in since the service may return back properties set to their default values.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillset"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerSkillset>> CreateOrUpdateSkillsetAsync(
            SearchIndexerSkillset skillset,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(CreateOrUpdateSkillset)}");
            scope.Start();
            try
            {
                return await SkillsetsClient.CreateOrUpdateAsync(
                    skillset?.Name,
                    skillset,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? skillset?.ETag?.ToString() : null,
                    null,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a skillset.
        /// </summary>
        /// <param name="skillsetName">The name of the <see cref="SearchIndexerSkillset"/> to delete.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillsetName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response DeleteSkillset(
            string skillsetName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => DeleteSkillset(
                skillsetName,
                null,
                false,
                options,
                cancellationToken);

        /// <summary>
        /// Deletes a skillset.
        /// </summary>
        /// <param name="skillsetName">The name of the <see cref="SearchIndexerSkillset"/> to delete.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillsetName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> DeleteSkillsetAsync(
            string skillsetName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => await DeleteSkillsetAsync(
                skillsetName,
                null,
                false,
                options,
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// Deletes a skillset.
        /// </summary>
        /// <param name="skillset">The <see cref="SearchIndexerSkillset"/> to delete.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerSkillset.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillset"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response DeleteSkillset(
            SearchIndexerSkillset skillset,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => DeleteSkillset(
                skillset?.Name,
                skillset?.ETag,
                onlyIfUnchanged,
                options,
                cancellationToken);

        /// <summary>
        /// Deletes a skillset.
        /// </summary>
        /// <param name="skillset">The <see cref="SearchIndexerSkillset"/> to delete.</param>
        /// <param name="onlyIfUnchanged">
        /// True to throw a <see cref="RequestFailedException"/> if the <see cref="SearchIndexerSkillset.ETag"/> does not match the current service version;
        /// otherwise, the current service version will be overwritten.
        /// </param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response"/> from the server.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillset"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response> DeleteSkillsetAsync(
            SearchIndexerSkillset skillset,
            bool onlyIfUnchanged = false,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default) => await DeleteSkillsetAsync(
                skillset?.Name,
                skillset?.ETag,
                onlyIfUnchanged,
                options,
                cancellationToken)
                .ConfigureAwait(false);

        private Response DeleteSkillset(
            string skillsetName,
            ETag? etag,
            bool onlyIfUnchanged,
            SearchRequestOptions options,
            CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(DeleteSkillset)}");
            scope.Start();
            try
            {
                return SkillsetsClient.Delete(
                    skillsetName,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? etag?.ToString() : null,
                    null,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        private async Task<Response> DeleteSkillsetAsync(
            string skillsetName,
            ETag? etag,
            bool onlyIfUnchanged,
            SearchRequestOptions options,
            CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(DeleteSkillset)}");
            scope.Start();
            try
            {
                return await SkillsetsClient.DeleteAsync(
                    skillsetName,
                    options?.ClientRequestId,
                    onlyIfUnchanged ? etag?.ToString() : null,
                    null,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific <see cref="SearchIndexerSkillset"/>.
        /// </summary>
        /// <param name="skillsetName">Required. The name of the <see cref="SearchIndexerSkillset"/> to get.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexerSkillset"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillsetName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<SearchIndexerSkillset> GetSkillset(
            string skillsetName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetSkillset)}");
            scope.Start();
            try
            {
                return SkillsetsClient.Get(
                    skillsetName,
                    options?.ClientRequestId,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific <see cref="SearchIndexerSkillset"/>.
        /// </summary>
        /// <param name="skillsetName">Required. The name of the <see cref="SearchIndexerSkillset"/> to get.</param>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing the requested <see cref="SearchIndexerSkillset"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="skillsetName"/> is null.</exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<SearchIndexerSkillset>> GetSkillsetAsync(
            string skillsetName,
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetSkillset)}");
            scope.Start();
            try
            {
                return await SkillsetsClient.GetAsync(
                    skillsetName,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all skillsets.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerSkillset"/>.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<IReadOnlyList<SearchIndexerSkillset>> GetSkillsets(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetSkillsets)}");
            scope.Start();
            try
            {
                Response<ListSkillsetsResult> result = SkillsetsClient.List(
                    Constants.All,
                    options?.ClientRequestId,
                    cancellationToken);

                return Response.FromValue(result.Value.Skillsets, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all skillsets.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerSkillset"/>.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<IReadOnlyList<SearchIndexerSkillset>>> GetSkillsetsAsync(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetSkillsets)}");
            scope.Start();
            try
            {
                Response<ListSkillsetsResult> result = await SkillsetsClient.ListAsync(
                    Constants.All,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(result.Value.Skillsets, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all skillset names.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerSkillset"/> names.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual Response<IReadOnlyList<string>> GetSkillsetNames(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetSkillsetNames)}");
            scope.Start();
            try
            {
                Response<ListSkillsetsResult> result = SkillsetsClient.List(
                    Constants.NameKey,
                    options?.ClientRequestId,
                    cancellationToken);

                IReadOnlyList<string> names = result.Value.Skillsets.Select(value => value.Name).ToArray();
                return Response.FromValue(names, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all skillset names.
        /// </summary>
        /// <param name="options">Optional <see cref="SearchRequestOptions"/> to customize the operation's behavior.</param>
        /// <param name="cancellationToken">Optional <see cref="CancellationToken"/> to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Response{T}"/> from the server containing a list of <see cref="SearchIndexerSkillset"/> names.</returns>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Search service.</exception>
        public virtual async Task<Response<IReadOnlyList<string>>> GetSkillsetNamesAsync(
            SearchRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SearchIndexerClient)}.{nameof(GetSkillsetNames)}");
            scope.Start();
            try
            {
                Response<ListSkillsetsResult> result = await SkillsetsClient.ListAsync(
                    Constants.NameKey,
                    options?.ClientRequestId,
                    cancellationToken)
                    .ConfigureAwait(false);

                IReadOnlyList<string> names = result.Value.Skillsets.Select(value => value.Name).ToArray();
                return Response.FromValue(names, result.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
        #endregion
    }
}
