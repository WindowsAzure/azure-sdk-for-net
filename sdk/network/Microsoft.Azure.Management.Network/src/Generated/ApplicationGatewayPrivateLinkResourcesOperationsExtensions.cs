// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationGatewayPrivateLinkResourcesOperations.
    /// </summary>
    public static partial class ApplicationGatewayPrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Lists all private link resources on an application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static IPage<ApplicationGatewayPrivateLinkResource> List(this IApplicationGatewayPrivateLinkResourcesOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                return operations.ListAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all private link resources on an application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationGatewayPrivateLinkResource>> ListAsync(this IApplicationGatewayPrivateLinkResourcesOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all private link resources on an application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationGatewayPrivateLinkResource> ListNext(this IApplicationGatewayPrivateLinkResourcesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all private link resources on an application gateway.
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
            public static async Task<IPage<ApplicationGatewayPrivateLinkResource>> ListNextAsync(this IApplicationGatewayPrivateLinkResourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
