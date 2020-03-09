// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;

namespace Azure.Management.Storage
{
    public partial class PrivateLinkResourcesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal PrivateLinkResourcesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PrivateLinkResourcesClient. </summary>
        internal PrivateLinkResourcesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com", string ApiVersion = "2019-06-01")
        {
            RestClient = new PrivateLinkResourcesRestClient(clientDiagnostics, pipeline, subscriptionId, host, ApiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Gets the private link resources that need to be created for a storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<PrivateLinkResourceListResult>> ListByStorageAccountAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListByStorageAccountAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Gets the private link resources that need to be created for a storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateLinkResourceListResult> ListByStorageAccount(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            return RestClient.ListByStorageAccount(resourceGroupName, accountName, cancellationToken);
        }
    }
}
