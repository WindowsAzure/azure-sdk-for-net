// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InfraRolesOperations.
    /// </summary>
    public static partial class InfraRolesOperationsExtensions
    {
            /// <summary>
            /// Returns the requested infrastructure role description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='infraRole'>
            /// Infrastructure role name.
            /// </param>
            public static InfraRole Get(this IInfraRolesOperations operations, string resourceGroupName, string location, string infraRole)
            {
                return operations.GetAsync(resourceGroupName, location, infraRole).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the requested infrastructure role description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='infraRole'>
            /// Infrastructure role name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InfraRole> GetAsync(this IInfraRolesOperations operations, string resourceGroupName, string location, string infraRole, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, location, infraRole, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of all infrastructure roles at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<InfraRole> List(this IInfraRolesOperations operations, string resourceGroupName, string location, ODataQuery<InfraRole> odataQuery = default(ODataQuery<InfraRole>))
            {
                return operations.ListAsync(resourceGroupName, location, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of all infrastructure roles at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<InfraRole>> ListAsync(this IInfraRolesOperations operations, string resourceGroupName, string location, ODataQuery<InfraRole> odataQuery = default(ODataQuery<InfraRole>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, location, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts the requested infrastructure role.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='infraRole'>
            /// Infrastructure role name.
            /// </param>
            public static void Restart(this IInfraRolesOperations operations, string resourceGroupName, string location, string infraRole)
            {
                operations.RestartAsync(resourceGroupName, location, infraRole).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts the requested infrastructure role.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='infraRole'>
            /// Infrastructure role name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestartAsync(this IInfraRolesOperations operations, string resourceGroupName, string location, string infraRole, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestartWithHttpMessagesAsync(resourceGroupName, location, infraRole, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Restarts the requested infrastructure role.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='infraRole'>
            /// Infrastructure role name.
            /// </param>
            public static void BeginRestart(this IInfraRolesOperations operations, string resourceGroupName, string location, string infraRole)
            {
                operations.BeginRestartAsync(resourceGroupName, location, infraRole).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts the requested infrastructure role.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='infraRole'>
            /// Infrastructure role name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestartAsync(this IInfraRolesOperations operations, string resourceGroupName, string location, string infraRole, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, location, infraRole, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of all infrastructure roles at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<InfraRole> ListNext(this IInfraRolesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of all infrastructure roles at a location.
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
            public static async Task<IPage<InfraRole>> ListNextAsync(this IInfraRolesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
