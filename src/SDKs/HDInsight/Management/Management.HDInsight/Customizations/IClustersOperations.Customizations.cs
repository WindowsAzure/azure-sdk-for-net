﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.HDInsight
{
    using Microsoft.Rest.Azure;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ClustersOperations operations.
    /// </summary>
    public partial interface IClustersOperations
    {
        /// <summary>
        /// Creates a new HDInsight cluster with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='parameters'>
        /// The cluster create request parameters.
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
        Task<AzureOperationResponse<Cluster>> CreateWithHttpMessagesAsync(string resourceGroupName, string clusterName, ClusterCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Resizes the specified HDInsight cluster to the specified size.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='targetInstanceCount'>
        /// The size to which to resize the cluster.
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
        Task<AzureOperationResponse> ResizeAsync(string resourceGroupName, string clusterName, int targetInstanceCount, CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// Executes script actions on the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='scriptActions'>
        /// The script actions to execute.
        /// </param>
        /// <param name="persistOnSuccess">
        /// Whether or not to persist the script action on success.
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
        Task<AzureOperationResponse> ExecuteScriptActionsAsync(string resourceGroupName, string clusterName, IList<RuntimeScriptAction> scriptActions,
            bool persistOnSuccess, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Begins creating a new HDInsight cluster with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='parameters'>
        /// The cluster create request parameters.
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
        Task<AzureOperationResponse<Cluster>> BeginCreatingAsync(string resourceGroupName, string clusterName, ClusterCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// Begins resizing the specified HDInsight cluster to the specified size.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='targetInstanceCount'>
        /// The size to which to resize the cluster.
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
        Task<AzureOperationResponse> BeginResizingAsync(string resourceGroupName, string clusterName, int targetInstanceCount, CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// Begins executing script actions on the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='scriptActions'>
        /// The script actions to execute.
        /// </param>
        /// <param name="persistOnSuccess">
        /// Whether or not to persist the script action on success.
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
        Task<AzureOperationResponse> BeginExecuteScriptActionsAsync(string resourceGroupName, string clusterName, IList<RuntimeScriptAction> scriptActions,
            bool persistOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
    }
}
