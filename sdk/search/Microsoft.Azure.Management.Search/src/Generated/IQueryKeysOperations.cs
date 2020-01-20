// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QueryKeysOperations operations.
    /// </summary>
    public partial interface IQueryKeysOperations
    {
        /// <summary>
        /// Generates a new query key for the specified Search service. You can
        /// create up to 50 query keys per service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the new query API key.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<QueryKey>> CreateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the list of query API keys for the given Azure Cognitive
        /// Search service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<QueryKey>>> ListBySearchServiceWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified query key. Unlike admin keys, query keys are
        /// not regenerated. The process for regenerating a query key is to
        /// delete and then recreate it.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='key'>
        /// The query key to be deleted. Query keys are identified by value,
        /// not by name.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string key, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
