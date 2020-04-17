// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PartnerTopicEventSubscriptionsOperations.
    /// </summary>
    public static partial class PartnerTopicEventSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Get an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Get an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be found. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static EventSubscription Get(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName)
            {
                return operations.GetAsync(resourceGroupName, partnerTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Get an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be found. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> GetAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription of a partner topic
            /// with the specified parameters. Existing event subscriptions will be updated
            /// with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            public static EventSubscription CreateOrUpdate(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription of a partner topic
            /// with the specified parameters. Existing event subscriptions will be updated
            /// with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> CreateOrUpdateAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Delete an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static void Delete(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName)
            {
                operations.DeleteAsync(resourceGroupName, partnerTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Delete an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Update event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            public static EventSubscription Update(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Update event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> UpdateAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get full URL of an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Get the full endpoint URL for an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static EventSubscriptionFullUrl GetFullUrl(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName)
            {
                return operations.GetFullUrlAsync(resourceGroupName, partnerTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get full URL of an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Get the full endpoint URL for an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscriptionFullUrl> GetFullUrlAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFullUrlWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List event subscriptions of a partner topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            public static IPage<EventSubscription> ListByPartnerTopic(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListByPartnerTopicAsync(resourceGroupName, partnerTopicName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List event subscriptions of a partner topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventSubscription>> ListByPartnerTopicAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPartnerTopicWithHttpMessagesAsync(resourceGroupName, partnerTopicName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription of a partner topic
            /// with the specified parameters. Existing event subscriptions will be updated
            /// with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            public static EventSubscription BeginCreateOrUpdate(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates an event subscription of a partner topic
            /// with the specified parameters. Existing event subscriptions will be updated
            /// with this API.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionInfo'>
            /// Event subscription properties containing the destination and filter
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> BeginCreateOrUpdateAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Delete an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            public static void BeginDelete(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, partnerTopicName, eventSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Delete an event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Update event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            public static EventSubscription BeginUpdate(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update event subscription of a partner topic.
            /// </summary>
            /// <remarks>
            /// Update event subscription of a partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerTopicName'>
            /// Name of the partner topic.
            /// </param>
            /// <param name='eventSubscriptionName'>
            /// Name of the event subscription to be created. Event subscription names must
            /// be between 3 and 100 characters in length and use alphanumeric letters
            /// only.
            /// </param>
            /// <param name='eventSubscriptionUpdateParameters'>
            /// Updated event subscription information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventSubscription> BeginUpdateAsync(this IPartnerTopicEventSubscriptionsOperations operations, string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, partnerTopicName, eventSubscriptionName, eventSubscriptionUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List event subscriptions of a partner topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventSubscription> ListByPartnerTopicNext(this IPartnerTopicEventSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByPartnerTopicNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List event subscriptions of a partner topic.
            /// </summary>
            /// <remarks>
            /// List event subscriptions that belong to a specific partner topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventSubscription>> ListByPartnerTopicNextAsync(this IPartnerTopicEventSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPartnerTopicNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
