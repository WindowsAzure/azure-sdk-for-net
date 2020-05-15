// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The AvailableServiceAliases service client. </summary>
    public partial class AvailableServiceAliasesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AvailableServiceAliasesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of AvailableServiceAliasesClient for mocking. </summary>
        protected AvailableServiceAliasesClient()
        {
        }
        /// <summary> Initializes a new instance of AvailableServiceAliasesClient. </summary>
        internal AvailableServiceAliasesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new AvailableServiceAliasesRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets all available service aliases for this subscription in this region. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<AvailableServiceAlias> ListAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<AvailableServiceAlias>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(location, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailableServiceAlias>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, location, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all available service aliases for this subscription in this region. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<AvailableServiceAlias> List(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<AvailableServiceAlias> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(location, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailableServiceAlias> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, location, cancellationToken);
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

        /// <summary> Gets all available service aliases for this resource group in this region. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<AvailableServiceAlias> ListByResourceGroupAsync(string resourceGroupName, string location, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<AvailableServiceAlias>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, location, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailableServiceAlias>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, location, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all available service aliases for this resource group in this region. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<AvailableServiceAlias> ListByResourceGroup(string resourceGroupName, string location, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<AvailableServiceAlias> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, location, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailableServiceAlias> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailableServiceAliasesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, location, cancellationToken);
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
