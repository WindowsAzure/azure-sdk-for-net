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
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The ScheduledQueryRules service client. </summary>
    public partial class ScheduledQueryRulesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ScheduledQueryRulesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ScheduledQueryRulesOperations for mocking. </summary>
        protected ScheduledQueryRulesOperations()
        {
        }

        /// <summary> Initializes a new instance of ScheduledQueryRulesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ScheduledQueryRulesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ScheduledQueryRulesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates or updates an log search rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogSearchRuleResource>> CreateOrUpdateAsync(string resourceGroupName, string ruleName, LogSearchRuleResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, ruleName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an log search rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogSearchRuleResource> CreateOrUpdate(string resourceGroupName, string ruleName, LogSearchRuleResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, ruleName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an Log Search rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogSearchRuleResource>> GetAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an Log Search rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogSearchRuleResource> Get(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, ruleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update log search Rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogSearchRuleResource>> UpdateAsync(string resourceGroupName, string ruleName, LogSearchRuleResourcePatch parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, ruleName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update log search Rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogSearchRuleResource> Update(string resourceGroupName, string ruleName, LogSearchRuleResourcePatch parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, ruleName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a Log Search rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a Log Search rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, ruleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List the Log Search rules within a subscription group. </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://msdn.microsoft.com/en-us/library/azure/dn931934.aspx. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<LogSearchRuleResource> ListBySubscriptionAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<LogSearchRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> List the Log Search rules within a subscription group. </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://msdn.microsoft.com/en-us/library/azure/dn931934.aspx. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<LogSearchRuleResource> ListBySubscription(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<LogSearchRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> List the Log Search rules within a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://msdn.microsoft.com/en-us/library/azure/dn931934.aspx. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<LogSearchRuleResource> ListByResourceGroupAsync(string resourceGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<LogSearchRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> List the Log Search rules within a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://msdn.microsoft.com/en-us/library/azure/dn931934.aspx. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<LogSearchRuleResource> ListByResourceGroup(string resourceGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<LogSearchRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ScheduledQueryRulesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
