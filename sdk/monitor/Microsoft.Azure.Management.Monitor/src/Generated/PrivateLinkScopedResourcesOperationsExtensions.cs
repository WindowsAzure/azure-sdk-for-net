// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkScopedResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkScopedResourcesOperationsExtensions
    {
            /// <summary>
            /// Gets a scoped resource in a private link scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            public static ScopedResource Get(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name)
            {
                return operations.GetAsync(resourceGroupName, scopeName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a scoped resource in a private link scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScopedResource> GetAsync(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, scopeName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static ScopedResource CreateOrUpdate(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, ScopedResource parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, scopeName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScopedResource> CreateOrUpdateAsync(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, ScopedResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, scopeName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            public static void Delete(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name)
            {
                operations.DeleteAsync(resourceGroupName, scopeName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, scopeName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all private endpoint connections on a private link scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            public static IPage<ScopedResource> ListByPrivateLinkScope(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName)
            {
                return operations.ListByPrivateLinkScopeAsync(resourceGroupName, scopeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoint connections on a private link scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ScopedResource>> ListByPrivateLinkScopeAsync(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPrivateLinkScopeWithHttpMessagesAsync(resourceGroupName, scopeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static ScopedResource BeginCreateOrUpdate(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, ScopedResource parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, scopeName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScopedResource> BeginCreateOrUpdateAsync(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, ScopedResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, scopeName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            public static void BeginDelete(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name)
            {
                operations.BeginDeleteAsync(resourceGroupName, scopeName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scopeName'>
            /// Name of the Azure Monitor PrivateLinkScope that will contain the datasource
            /// </param>
            /// <param name='name'>
            /// The name of the scoped resource object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateLinkScopedResourcesOperations operations, string resourceGroupName, string scopeName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, scopeName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all private endpoint connections on a private link scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ScopedResource> ListByPrivateLinkScopeNext(this IPrivateLinkScopedResourcesOperations operations, string nextPageLink)
            {
                return operations.ListByPrivateLinkScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoint connections on a private link scope.
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
            public static async Task<IPage<ScopedResource>> ListByPrivateLinkScopeNextAsync(this IPrivateLinkScopedResourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPrivateLinkScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
