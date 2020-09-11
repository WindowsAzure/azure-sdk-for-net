// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// WorkspaceConnectionsOperations operations.
    /// </summary>
    public partial interface IWorkspaceConnectionsOperations
    {
        /// <summary>
        /// List all connections under a AML workspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which workspace is located.
        /// </param>
        /// <param name='workspaceName'>
        /// Name of Azure Machine Learning workspace.
        /// </param>
        /// <param name='target'>
        /// Target of the workspace connection.
        /// </param>
        /// <param name='category'>
        /// Category of the workspace connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="MachineLearningServiceErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<WorkspaceConnection>>> ListWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string target = default(string), string category = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a new workspace connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which workspace is located.
        /// </param>
        /// <param name='workspaceName'>
        /// Name of Azure Machine Learning workspace.
        /// </param>
        /// <param name='connectionName'>
        /// Friendly name of the workspace connection
        /// </param>
        /// <param name='parameters'>
        /// The object for creating or updating a new workspace connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="MachineLearningServiceErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WorkspaceConnection>> CreateWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string connectionName, WorkspaceConnectionDto parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the detail of a workspace connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which workspace is located.
        /// </param>
        /// <param name='workspaceName'>
        /// Name of Azure Machine Learning workspace.
        /// </param>
        /// <param name='connectionName'>
        /// Friendly name of the workspace connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="MachineLearningServiceErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WorkspaceConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string connectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a workspace connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which workspace is located.
        /// </param>
        /// <param name='workspaceName'>
        /// Name of Azure Machine Learning workspace.
        /// </param>
        /// <param name='connectionName'>
        /// Friendly name of the workspace connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="MachineLearningServiceErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string connectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
