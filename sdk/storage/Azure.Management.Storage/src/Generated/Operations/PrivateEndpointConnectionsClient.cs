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
    public partial class PrivateEndpointConnectionsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal PrivateEndpointConnectionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PrivateEndpointConnectionsClient. </summary>
        internal PrivateEndpointConnectionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com", string ApiVersion = "2019-06-01")
        {
            RestClient = new PrivateEndpointConnectionsRestClient(clientDiagnostics, pipeline, subscriptionId, host, ApiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Gets the specified private endpoint connection associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<PrivateEndpointConnection>> GetAsync(string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, accountName, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Gets the specified private endpoint connection associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateEndpointConnection> Get(string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, accountName, privateEndpointConnectionName, cancellationToken);
        }
        /// <summary> Update the state of specified private endpoint connection associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<PrivateEndpointConnection>> PutAsync(string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutAsync(resourceGroupName, accountName, privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Update the state of specified private endpoint connection associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateEndpointConnection> Put(string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default)
        {
            return RestClient.Put(resourceGroupName, accountName, privateEndpointConnectionName, properties, cancellationToken);
        }
        /// <summary> Deletes the specified private endpoint connection associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(resourceGroupName, accountName, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Deletes the specified private endpoint connection associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(resourceGroupName, accountName, privateEndpointConnectionName, cancellationToken);
        }
    }
}
