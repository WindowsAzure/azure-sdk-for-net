// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints
{
    /// <summary> The ManagedPrivateEndpoints service client. </summary>
    public partial class ManagedPrivateEndpointsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedPrivateEndpointsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ManagedPrivateEndpointsClient for mocking. </summary>
        protected ManagedPrivateEndpointsClient()
        {
        }

        /// <summary> Initializes a new instance of ManagedPrivateEndpointsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ManagedPrivateEndpointsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new ManagedPrivateEndpointsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedPrivateEndpoint>> GetAsync(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(managedPrivateEndpointName, managedVirtualNetworkName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedPrivateEndpoint> Get(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(managedPrivateEndpointName, managedVirtualNetworkName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedPrivateEndpoint"> Managed private endpoint properties. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedPrivateEndpoint>> CreateAsync(string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(managedPrivateEndpointName, managedPrivateEndpoint, managedVirtualNetworkName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedPrivateEndpoint"> Managed private endpoint properties. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedPrivateEndpoint> Create(string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(managedPrivateEndpointName, managedPrivateEndpoint, managedVirtualNetworkName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(managedPrivateEndpointName, managedVirtualNetworkName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(managedPrivateEndpointName, managedVirtualNetworkName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public virtual AsyncPageable<ManagedPrivateEndpoint> ListAsync(string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            async Task<Page<ManagedPrivateEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(managedVirtualNetworkName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedPrivateEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, managedVirtualNetworkName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public virtual Pageable<ManagedPrivateEndpoint> List(string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            Page<ManagedPrivateEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(managedVirtualNetworkName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedPrivateEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedPrivateEndpointsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, managedVirtualNetworkName, cancellationToken);
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
    }
}
