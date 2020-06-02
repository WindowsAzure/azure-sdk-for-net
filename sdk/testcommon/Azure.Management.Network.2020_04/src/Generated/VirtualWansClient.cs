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
    /// <summary> The VirtualWans service client. </summary>
    public partial class VirtualWansClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualWansRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VirtualWansClient for mocking. </summary>
        protected VirtualWansClient()
        {
        }
        /// <summary> Initializes a new instance of VirtualWansClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VirtualWansClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VirtualWansRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the details of a VirtualWAN. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualWAN>> GetAsync(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, virtualWANName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualWAN. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWAN> Get(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, virtualWANName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a VirtualWAN tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being updated. </param>
        /// <param name="wANParameters"> Parameters supplied to Update VirtualWAN tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualWAN>> UpdateTagsAsync(string resourceGroupName, string virtualWANName, TagsObject wANParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, virtualWANName, wANParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a VirtualWAN tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being updated. </param>
        /// <param name="wANParameters"> Parameters supplied to Update VirtualWAN tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWAN> UpdateTags(string resourceGroupName, string virtualWANName, TagsObject wANParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, virtualWANName, wANParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VirtualWAN> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<VirtualWAN>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWAN>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VirtualWAN> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<VirtualWAN> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWAN> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Lists all the VirtualWANs in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VirtualWAN> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualWAN>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWAN>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists all the VirtualWANs in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VirtualWAN> List(CancellationToken cancellationToken = default)
        {
            Page<VirtualWAN> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWAN> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
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

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualWansCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string virtualWANName, VirtualWAN wANParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, virtualWANName, wANParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualWansCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, virtualWANName, wANParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualWansCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string virtualWANName, VirtualWAN wANParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, virtualWANName, wANParameters, cancellationToken);
                return new VirtualWansCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, virtualWANName, wANParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VirtualWansDeleteOperation> StartDeleteAsync(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, virtualWANName, cancellationToken).ConfigureAwait(false);
                return new VirtualWansDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, virtualWANName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualWan. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualWansDeleteOperation StartDelete(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWansClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, virtualWANName, cancellationToken);
                return new VirtualWansDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, virtualWANName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
