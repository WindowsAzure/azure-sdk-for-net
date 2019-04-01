// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageSyncServicesOperations.
    /// </summary>
    public static partial class StorageSyncServicesOperationsExtensions
    {
            /// <summary>
            /// Check the give namespace name availability.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The desired region for the name check.
            /// </param>
            /// <param name='name'>
            /// The name to check for availability
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IStorageSyncServicesOperations operations, string locationName, string name)
            {
                return operations.CheckNameAvailabilityAsync(locationName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the give namespace name availability.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The desired region for the name check.
            /// </param>
            /// <param name='name'>
            /// The name to check for availability
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IStorageSyncServicesOperations operations, string locationName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(locationName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='parameters'>
            /// Storage Sync Service resource name.
            /// </param>
            public static StorageSyncService Create(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, storageSyncServiceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='parameters'>
            /// Storage Sync Service resource name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageSyncService> CreateAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a given StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            public static StorageSyncService Get(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName)
            {
                return operations.GetAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a given StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageSyncService> GetAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch a given StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='parameters'>
            /// Storage Sync Service resource.
            /// </param>
            public static StorageSyncService Update(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceUpdateParameters parameters = default(StorageSyncServiceUpdateParameters))
            {
                return operations.UpdateAsync(resourceGroupName, storageSyncServiceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch a given StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='parameters'>
            /// Storage Sync Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageSyncService> UpdateAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceUpdateParameters parameters = default(StorageSyncServiceUpdateParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a given StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            public static StorageSyncServicesDeleteHeaders Delete(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName)
            {
                return operations.DeleteAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a given StorageSyncService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageSyncServicesDeleteHeaders> DeleteAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Get a StorageSyncService list by Resource group name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IEnumerable<StorageSyncService> ListByResourceGroup(this IStorageSyncServicesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a StorageSyncService list by Resource group name.
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
            public static async Task<IEnumerable<StorageSyncService>> ListByResourceGroupAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a StorageSyncService list by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<StorageSyncService> ListBySubscription(this IStorageSyncServicesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a StorageSyncService list by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<StorageSyncService>> ListBySubscriptionAsync(this IStorageSyncServicesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
