// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MixedReality
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SpatialAnchorsAccountsOperations.
    /// </summary>
    public static partial class SpatialAnchorsAccountsOperationsExtensions
    {
            /// <summary>
            /// List Spatial Anchors Accounts by Subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SpatialAnchorsAccount> ListBySubscription(this ISpatialAnchorsAccountsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Spatial Anchors Accounts by Subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SpatialAnchorsAccount>> ListBySubscriptionAsync(this ISpatialAnchorsAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Resources by Resource Group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            public static IPage<SpatialAnchorsAccount> ListByResourceGroup(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Resources by Resource Group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SpatialAnchorsAccount>> ListByResourceGroupAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Spatial Anchors Account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            public static void Delete(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Spatial Anchors Account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a Spatial Anchors Account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            public static SpatialAnchorsAccount Get(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a Spatial Anchors Account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SpatialAnchorsAccount> GetAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updating a Spatial Anchors Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='spatialAnchorsAccount'>
            /// Spatial Anchors Account parameter.
            /// </param>
            public static SpatialAnchorsAccount Update(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, SpatialAnchorsAccount spatialAnchorsAccount)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, spatialAnchorsAccount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updating a Spatial Anchors Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='spatialAnchorsAccount'>
            /// Spatial Anchors Account parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SpatialAnchorsAccount> UpdateAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, SpatialAnchorsAccount spatialAnchorsAccount, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, spatialAnchorsAccount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creating or Updating a Spatial Anchors Account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='spatialAnchorsAccount'>
            /// Spatial Anchors Account parameter.
            /// </param>
            public static SpatialAnchorsAccount Create(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, SpatialAnchorsAccount spatialAnchorsAccount)
            {
                return operations.CreateAsync(resourceGroupName, accountName, spatialAnchorsAccount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creating or Updating a Spatial Anchors Account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='spatialAnchorsAccount'>
            /// Spatial Anchors Account parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SpatialAnchorsAccount> CreateAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, SpatialAnchorsAccount spatialAnchorsAccount, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, spatialAnchorsAccount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Both of the 2 Keys of a Spatial Anchors Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            public static AccountKeys ListKeys(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Both of the 2 Keys of a Spatial Anchors Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccountKeys> ListKeysAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate specified Key of a Spatial Anchors Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='serial'>
            /// Serial of key to be regenerated
            /// </param>
            public static AccountKeys RegenerateKeys(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, int? serial = 1)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, accountName, serial).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate specified Key of a Spatial Anchors Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Name of an Mixed Reality Account.
            /// </param>
            /// <param name='serial'>
            /// Serial of key to be regenerated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccountKeys> RegenerateKeysAsync(this ISpatialAnchorsAccountsOperations operations, string resourceGroupName, string accountName, int? serial = 1, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, accountName, serial, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Spatial Anchors Accounts by Subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SpatialAnchorsAccount> ListBySubscriptionNext(this ISpatialAnchorsAccountsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Spatial Anchors Accounts by Subscription
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
            public static async Task<IPage<SpatialAnchorsAccount>> ListBySubscriptionNextAsync(this ISpatialAnchorsAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Resources by Resource Group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SpatialAnchorsAccount> ListByResourceGroupNext(this ISpatialAnchorsAccountsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Resources by Resource Group
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
            public static async Task<IPage<SpatialAnchorsAccount>> ListByResourceGroupNextAsync(this ISpatialAnchorsAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
