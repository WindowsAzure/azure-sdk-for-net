// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Caches.
    /// </summary>
    public static partial class CachesExtensions
    {
            /// <summary>
            /// Returns all Caches the user has access to under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static CachesListResult List(this ICaches operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all Caches the user has access to under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CachesListResult> ListAsync(this ICaches operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all Caches the user has access to under a resource group and
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            public static CachesListResult ListByResourceGroup(this ICaches operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all Caches the user has access to under a resource group and
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CachesListResult> ListByResourceGroupAsync(this ICaches operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Schedules a Cache for deletion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            public static object Delete(this ICaches operations, string resourceGroupName, string cacheName)
            {
                return operations.DeleteAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Schedules a Cache for deletion.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this ICaches operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a Cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            public static Cache Get(this ICaches operations, string resourceGroupName, string cacheName)
            {
                return operations.GetAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a Cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cache> GetAsync(this ICaches operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create/update a Cache instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cache'>
            /// Object containing the user selectable properties of the new cache.  If
            /// read-only properties are included, they must match the existing values of
            /// those properties.
            /// </param>
            public static Cache Create(this ICaches operations, string resourceGroupName, string cacheName, Cache cache = default(Cache))
            {
                return operations.CreateAsync(resourceGroupName, cacheName, cache).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create/update a Cache instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cache'>
            /// Object containing the user selectable properties of the new cache.  If
            /// read-only properties are included, they must match the existing values of
            /// those properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cache> CreateAsync(this ICaches operations, string resourceGroupName, string cacheName, Cache cache = default(Cache), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, cacheName, cache, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Cache instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cache'>
            /// Object containing the user selectable properties of the new cache.  If
            /// read-only properties are included, they must match the existing values of
            /// those properties.
            /// </param>
            public static Cache Update(this ICaches operations, string resourceGroupName, string cacheName, Cache cache = default(Cache))
            {
                return operations.UpdateAsync(resourceGroupName, cacheName, cache).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Cache instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cache'>
            /// Object containing the user selectable properties of the new cache.  If
            /// read-only properties are included, they must match the existing values of
            /// those properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cache> UpdateAsync(this ICaches operations, string resourceGroupName, string cacheName, Cache cache = default(Cache), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, cacheName, cache, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Tells a cache to write all dirty data to the StorageTarget(s).  During the
            /// flush, clients will see errors returned until the flush is complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            public static object Flush(this ICaches operations, string resourceGroupName, string cacheName)
            {
                return operations.FlushAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tells a cache to write all dirty data to the StorageTarget(s).  During the
            /// flush, clients will see errors returned until the flush is complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> FlushAsync(this ICaches operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FlushWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Tells a Stopped state cache to transition to Active state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            public static object Start(this ICaches operations, string resourceGroupName, string cacheName)
            {
                return operations.StartAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tells a Stopped state cache to transition to Active state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> StartAsync(this ICaches operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Tells an Active cache to transition to Stopped state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            public static object Stop(this ICaches operations, string resourceGroupName, string cacheName)
            {
                return operations.StopAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tells an Active cache to transition to Stopped state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> StopAsync(this ICaches operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StopWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Tells a cache to upgrade its firmware.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            public static object UpgradeFirmware(this ICaches operations, string resourceGroupName, string cacheName)
            {
                return operations.UpgradeFirmwareAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tells a cache to upgrade its firmware.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Target resource group.
            /// </param>
            /// <param name='cacheName'>
            /// Name of cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpgradeFirmwareAsync(this ICaches operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpgradeFirmwareWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
