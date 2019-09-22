// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IotSecuritySolutionsAnalyticsAggregatedAlertOperations.
    /// </summary>
    public static partial class IotSecuritySolutionsAnalyticsAggregatedAlertOperationsExtensions
    {
            /// <summary>
            /// Use this method to get the aggregated alert list of yours IoT Security
            /// solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='top'>
            /// Number of results to retrieve.
            /// </param>
            public static IPage<IoTSecurityAggregatedAlert> List(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string resourceGroupName, string solutionName, int? top = default(int?))
            {
                return operations.ListAsync(resourceGroupName, solutionName, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Use this method to get the aggregated alert list of yours IoT Security
            /// solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='top'>
            /// Number of results to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IoTSecurityAggregatedAlert>> ListAsync(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string resourceGroupName, string solutionName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, solutionName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Use this method to get a single the aggregated alert of yours IoT Security
            /// solution. This aggregation is performed by alert name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='aggregatedAlertName'>
            /// Identifier of the aggregated alert.
            /// </param>
            public static IoTSecurityAggregatedAlert Get(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string resourceGroupName, string solutionName, string aggregatedAlertName)
            {
                return operations.GetAsync(resourceGroupName, solutionName, aggregatedAlertName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Use this method to get a single the aggregated alert of yours IoT Security
            /// solution. This aggregation is performed by alert name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='aggregatedAlertName'>
            /// Identifier of the aggregated alert.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IoTSecurityAggregatedAlert> GetAsync(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string resourceGroupName, string solutionName, string aggregatedAlertName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, solutionName, aggregatedAlertName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Use this method to dismiss an aggregated IoT Security Solution Alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='aggregatedAlertName'>
            /// Identifier of the aggregated alert.
            /// </param>
            public static void Dismiss(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string resourceGroupName, string solutionName, string aggregatedAlertName)
            {
                operations.DismissAsync(resourceGroupName, solutionName, aggregatedAlertName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Use this method to dismiss an aggregated IoT Security Solution Alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='aggregatedAlertName'>
            /// Identifier of the aggregated alert.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DismissAsync(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string resourceGroupName, string solutionName, string aggregatedAlertName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DismissWithHttpMessagesAsync(resourceGroupName, solutionName, aggregatedAlertName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Use this method to get the aggregated alert list of yours IoT Security
            /// solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IoTSecurityAggregatedAlert> ListNext(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Use this method to get the aggregated alert list of yours IoT Security
            /// solution.
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
            public static async Task<IPage<IoTSecurityAggregatedAlert>> ListNextAsync(this IIotSecuritySolutionsAnalyticsAggregatedAlertOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
