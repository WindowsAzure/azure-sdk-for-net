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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The FirewallPolicies service client. </summary>
    public partial class FirewallPoliciesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FirewallPoliciesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of FirewallPoliciesOperations for mocking. </summary>
        protected FirewallPoliciesOperations()
        {
        }

        /// <summary> Initializes a new instance of FirewallPoliciesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal FirewallPoliciesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new FirewallPoliciesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified Firewall Policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallPolicy>> GetAsync(string resourceGroupName, string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, firewallPolicyName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Firewall Policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallPolicy> Get(string resourceGroupName, string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, firewallPolicyName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Firewall Policies in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<FirewallPolicy> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<FirewallPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists all Firewall Policies in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<FirewallPolicy> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<FirewallPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Gets all the Firewall Policies in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<FirewallPolicy> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FirewallPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the Firewall Policies in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<FirewallPolicy> ListAll(CancellationToken cancellationToken = default)
        {
            Page<FirewallPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
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

        /// <summary> Deletes the specified Firewall Policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual async Task<FirewallPoliciesDeleteOperation> StartDeleteAsync(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, firewallPolicyName, cancellationToken).ConfigureAwait(false);
                return new FirewallPoliciesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Firewall Policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual FirewallPoliciesDeleteOperation StartDelete(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, firewallPolicyName, cancellationToken);
                return new FirewallPoliciesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Firewall Policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Firewall Policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<FirewallPoliciesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string firewallPolicyName, FirewallPolicy parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, firewallPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                return new FirewallPoliciesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Firewall Policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Firewall Policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual FirewallPoliciesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string firewallPolicyName, FirewallPolicy parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPoliciesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, firewallPolicyName, parameters, cancellationToken);
                return new FirewallPoliciesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
