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
    /// Extension methods for PrivateLinkResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Gets the private link resources that need to be created for a Azure Monitor
            /// PrivateLinkScope.
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
            public static IPage<PrivateLinkResource> ListByPrivateLinkScope(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string scopeName)
            {
                return operations.ListByPrivateLinkScopeAsync(resourceGroupName, scopeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a Azure Monitor
            /// PrivateLinkScope.
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
            public static async Task<IPage<PrivateLinkResource>> ListByPrivateLinkScopeAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string scopeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPrivateLinkScopeWithHttpMessagesAsync(resourceGroupName, scopeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a Azure Monitor
            /// PrivateLinkScope.
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
            /// <param name='groupName'>
            /// The name of the private link resource.
            /// </param>
            public static PrivateLinkResource Get(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string scopeName, string groupName)
            {
                return operations.GetAsync(resourceGroupName, scopeName, groupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a Azure Monitor
            /// PrivateLinkScope.
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
            /// <param name='groupName'>
            /// The name of the private link resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResource> GetAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string scopeName, string groupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, scopeName, groupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a Azure Monitor
            /// PrivateLinkScope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkResource> ListByPrivateLinkScopeNext(this IPrivateLinkResourcesOperations operations, string nextPageLink)
            {
                return operations.ListByPrivateLinkScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a Azure Monitor
            /// PrivateLinkScope.
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
            public static async Task<IPage<PrivateLinkResource>> ListByPrivateLinkScopeNextAsync(this IPrivateLinkResourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPrivateLinkScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
