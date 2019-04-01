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
    /// Extension methods for DefaultSecurityRulesOperations.
    /// </summary>
    public static partial class DefaultSecurityRulesOperationsExtensions
    {
            /// <summary>
            /// Gets all default security rules in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            public static IPage<SecurityRule> List(this IDefaultSecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName)
            {
                return operations.ListAsync(resourceGroupName, networkSecurityGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all default security rules in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecurityRule>> ListAsync(this IDefaultSecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified default network security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='defaultSecurityRuleName'>
            /// The name of the default security rule.
            /// </param>
            public static SecurityRule Get(this IDefaultSecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string defaultSecurityRuleName)
            {
                return operations.GetAsync(resourceGroupName, networkSecurityGroupName, defaultSecurityRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified default network security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='defaultSecurityRuleName'>
            /// The name of the default security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityRule> GetAsync(this IDefaultSecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string defaultSecurityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, defaultSecurityRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all default security rules in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecurityRule> ListNext(this IDefaultSecurityRulesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all default security rules in a network security group.
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
            public static async Task<IPage<SecurityRule>> ListNextAsync(this IDefaultSecurityRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
