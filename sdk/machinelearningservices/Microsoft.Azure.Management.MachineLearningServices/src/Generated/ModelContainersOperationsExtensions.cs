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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ModelContainersOperations.
    /// </summary>
    public static partial class ModelContainersOperationsExtensions
    {
            /// <summary>
            /// List model containers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='skip'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='count'>
            /// Maximum number of results to return.
            /// </param>
            public static IPage<ModelContainerResource> List(this IModelContainersOperations operations, string resourceGroupName, string workspaceName, string skip = default(string), int? count = default(int?))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List model containers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='skip'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='count'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ModelContainerResource>> ListAsync(this IModelContainersOperations operations, string resourceGroupName, string workspaceName, string skip = default(string), int? count = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete container.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Container name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            public static void Delete(this IModelContainersOperations operations, string name, string resourceGroupName, string workspaceName)
            {
                operations.DeleteAsync(name, resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete container.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Container name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IModelContainersOperations operations, string name, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(name, resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get container.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Container name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            public static ModelContainerResource Get(this IModelContainersOperations operations, string name, string resourceGroupName, string workspaceName)
            {
                return operations.GetAsync(name, resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get container.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Container name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ModelContainerResource> GetAsync(this IModelContainersOperations operations, string name, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(name, resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update container.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Container name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='body'>
            /// Container entity to create or update.
            /// </param>
            public static ModelContainerResource CreateOrUpdate(this IModelContainersOperations operations, string name, string resourceGroupName, string workspaceName, ModelContainerResource body)
            {
                return operations.CreateOrUpdateAsync(name, resourceGroupName, workspaceName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update container.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Container name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='body'>
            /// Container entity to create or update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ModelContainerResource> CreateOrUpdateAsync(this IModelContainersOperations operations, string name, string resourceGroupName, string workspaceName, ModelContainerResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(name, resourceGroupName, workspaceName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List model containers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ModelContainerResource> ListNext(this IModelContainersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List model containers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ModelContainerResource>> ListNextAsync(this IModelContainersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
