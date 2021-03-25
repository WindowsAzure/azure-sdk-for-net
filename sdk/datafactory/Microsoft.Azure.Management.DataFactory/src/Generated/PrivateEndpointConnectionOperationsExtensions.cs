// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionOperationsExtensions
    {
            /// <summary>
            /// Approves or rejects a private endpoint connection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The private endpoint connection name.
            /// </param>
            /// <param name='privateEndpointWrapper'>
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the private endpoint connection entity.  Should only be specified
            /// for update, for which it should match existing entity or can be * for
            /// unconditional update.
            /// </param>
            public static PrivateEndpointConnectionResource CreateOrUpdate(this IPrivateEndpointConnectionOperations operations, string resourceGroupName, string factoryName, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, factoryName, privateEndpointConnectionName, privateEndpointWrapper, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approves or rejects a private endpoint connection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The private endpoint connection name.
            /// </param>
            /// <param name='privateEndpointWrapper'>
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the private endpoint connection entity.  Should only be specified
            /// for update, for which it should match existing entity or can be * for
            /// unconditional update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnectionResource> CreateOrUpdateAsync(this IPrivateEndpointConnectionOperations operations, string resourceGroupName, string factoryName, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, factoryName, privateEndpointConnectionName, privateEndpointWrapper, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a private endpoint connection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The private endpoint connection name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the private endpoint connection entity. Should only be specified
            /// for get. If the ETag matches the existing entity tag, or if * was provided,
            /// then no content will be returned.
            /// </param>
            public static PrivateEndpointConnectionResource Get(this IPrivateEndpointConnectionOperations operations, string resourceGroupName, string factoryName, string privateEndpointConnectionName, string ifNoneMatch = default(string))
            {
                return operations.GetAsync(resourceGroupName, factoryName, privateEndpointConnectionName, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a private endpoint connection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The private endpoint connection name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the private endpoint connection entity. Should only be specified
            /// for get. If the ETag matches the existing entity tag, or if * was provided,
            /// then no content will be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnectionResource> GetAsync(this IPrivateEndpointConnectionOperations operations, string resourceGroupName, string factoryName, string privateEndpointConnectionName, string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, factoryName, privateEndpointConnectionName, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The private endpoint connection name.
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionOperations operations, string resourceGroupName, string factoryName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, factoryName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The private endpoint connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionOperations operations, string resourceGroupName, string factoryName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, factoryName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
