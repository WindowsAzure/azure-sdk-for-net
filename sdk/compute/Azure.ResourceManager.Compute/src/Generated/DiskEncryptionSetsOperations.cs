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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> The DiskEncryptionSets service client. </summary>
    public partial class DiskEncryptionSetsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DiskEncryptionSetsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of DiskEncryptionSetsOperations for mocking. </summary>
        protected DiskEncryptionSetsOperations()
        {
        }

        /// <summary> Initializes a new instance of DiskEncryptionSetsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal DiskEncryptionSetsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new DiskEncryptionSetsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets information about a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiskEncryptionSet>> GetAsync(string resourceGroupName, string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, diskEncryptionSetName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiskEncryptionSet> Get(string resourceGroupName, string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, diskEncryptionSetName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the disk encryption sets under a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<DiskEncryptionSet> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<DiskEncryptionSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.ListByResourceGroup");
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
            async Task<Page<DiskEncryptionSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.ListByResourceGroup");
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

        /// <summary> Lists all the disk encryption sets under a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<DiskEncryptionSet> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<DiskEncryptionSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.ListByResourceGroup");
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
            Page<DiskEncryptionSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.ListByResourceGroup");
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

        /// <summary> Lists all the disk encryption sets under a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DiskEncryptionSet> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskEncryptionSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.List");
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
            async Task<Page<DiskEncryptionSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.List");
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

        /// <summary> Lists all the disk encryption sets under a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DiskEncryptionSet> List(CancellationToken cancellationToken = default)
        {
            Page<DiskEncryptionSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.List");
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
            Page<DiskEncryptionSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.List");
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

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="diskEncryptionSetName"/>, or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual async Task<DiskEncryptionSetsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string diskEncryptionSetName, DiskEncryptionSet diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken).ConfigureAwait(false);
                return new DiskEncryptionSetsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="diskEncryptionSetName"/>, or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual DiskEncryptionSetsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string diskEncryptionSetName, DiskEncryptionSet diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken);
                return new DiskEncryptionSetsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates (patches) a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Patch disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="diskEncryptionSetName"/>, or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual async Task<DiskEncryptionSetsUpdateOperation> StartUpdateAsync(string resourceGroupName, string diskEncryptionSetName, DiskEncryptionSetUpdate diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken).ConfigureAwait(false);
                return new DiskEncryptionSetsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates (patches) a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Patch disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="diskEncryptionSetName"/>, or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual DiskEncryptionSetsUpdateOperation StartUpdate(string resourceGroupName, string diskEncryptionSetName, DiskEncryptionSetUpdate diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken);
                return new DiskEncryptionSetsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual async Task<DiskEncryptionSetsDeleteOperation> StartDeleteAsync(string resourceGroupName, string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, diskEncryptionSetName, cancellationToken).ConfigureAwait(false);
                return new DiskEncryptionSetsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, diskEncryptionSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a disk encryption set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual DiskEncryptionSetsDeleteOperation StartDelete(string resourceGroupName, string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (diskEncryptionSetName == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DiskEncryptionSetsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, diskEncryptionSetName, cancellationToken);
                return new DiskEncryptionSetsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, diskEncryptionSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
