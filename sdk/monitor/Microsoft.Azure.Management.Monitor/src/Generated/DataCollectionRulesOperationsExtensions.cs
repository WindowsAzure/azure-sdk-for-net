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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataCollectionRulesOperations.
    /// </summary>
    public static partial class DataCollectionRulesOperationsExtensions
    {
            /// <summary>
            /// Lists all data collection rules in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<DataCollectionRuleResource> ListByResourceGroup(this IDataCollectionRulesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all data collection rules in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataCollectionRuleResource>> ListByResourceGroupAsync(this IDataCollectionRulesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all data collection rules in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DataCollectionRuleResource> ListBySubscription(this IDataCollectionRulesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all data collection rules in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataCollectionRuleResource>> ListBySubscriptionAsync(this IDataCollectionRulesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            public static DataCollectionRuleResource Get(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName)
            {
                return operations.GetAsync(resourceGroupName, dataCollectionRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataCollectionRuleResource> GetAsync(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            /// <param name='body'>
            /// The payload
            /// </param>
            public static DataCollectionRuleResource Create(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName, DataCollectionRuleResource body = default(DataCollectionRuleResource))
            {
                return operations.CreateAsync(resourceGroupName, dataCollectionRuleName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            /// <param name='body'>
            /// The payload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataCollectionRuleResource> CreateAsync(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName, DataCollectionRuleResource body = default(DataCollectionRuleResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates part of a data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static DataCollectionRuleResource Update(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, dataCollectionRuleName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates part of a data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataCollectionRuleResource> UpdateAsync(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            public static void Delete(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName)
            {
                operations.DeleteAsync(resourceGroupName, dataCollectionRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a data collection rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dataCollectionRuleName'>
            /// The name of the data collection rule. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDataCollectionRulesOperations operations, string resourceGroupName, string dataCollectionRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all data collection rules in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataCollectionRuleResource> ListByResourceGroupNext(this IDataCollectionRulesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all data collection rules in the specified resource group.
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
            public static async Task<IPage<DataCollectionRuleResource>> ListByResourceGroupNextAsync(this IDataCollectionRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all data collection rules in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataCollectionRuleResource> ListBySubscriptionNext(this IDataCollectionRulesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all data collection rules in the specified subscription.
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
            public static async Task<IPage<DataCollectionRuleResource>> ListBySubscriptionNextAsync(this IDataCollectionRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
