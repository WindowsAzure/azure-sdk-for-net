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
using Azure.Management.EventHub.Models;

namespace Azure.Management.EventHub
{
    /// <summary> The Configuration service client. </summary>
    public partial class ConfigurationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ConfigurationRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ConfigurationClient for mocking. </summary>
        protected ConfigurationClient()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationClient. </summary>
        public ConfigurationClient(string subscriptionId, TokenCredential tokenCredential, EventHubManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of ConfigurationClient. </summary>
        public ConfigurationClient(string subscriptionId, string host, TokenCredential tokenCredential, EventHubManagementClientOptions options = null)
        {
            options ??= new EventHubManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new ConfigurationRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Replace all specified Event Hubs Cluster settings with those contained in the request body. Leaves the settings not specified in the request body unmodified. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating an Event Hubs Cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ClusterQuotaConfigurationProperties>> PatchAsync(string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Patch");
            scope.Start();
            try
            {
                return await RestClient.PatchAsync(resourceGroupName, clusterName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace all specified Event Hubs Cluster settings with those contained in the request body. Leaves the settings not specified in the request body unmodified. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating an Event Hubs Cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ClusterQuotaConfigurationProperties> Patch(string resourceGroupName, string clusterName, ClusterQuotaConfigurationProperties parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Patch");
            scope.Start();
            try
            {
                return RestClient.Patch(resourceGroupName, clusterName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all Event Hubs Cluster settings - a collection of key/value pairs which represent the quotas and settings imposed on the cluster. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ClusterQuotaConfigurationProperties>> GetAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all Event Hubs Cluster settings - a collection of key/value pairs which represent the quotas and settings imposed on the cluster. </summary>
        /// <param name="resourceGroupName"> Name of the resource group within the azure subscription. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ClusterQuotaConfigurationProperties> Get(string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, clusterName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
