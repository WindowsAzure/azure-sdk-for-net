// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageDomains.
    /// </summary>
    public static partial class StorageDomainsExtensions
    {
            /// <summary>
            /// Retrieves all the storage domains in a manager.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static StorageDomainList ListByManager(this IStorageDomains operations, string resourceGroupName, string managerName)
            {
                return operations.ListByManagerAsync(resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves all the storage domains in a manager.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageDomainList> ListByManagerAsync(this IStorageDomains operations, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagerWithHttpMessagesAsync(resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the properties of the specified storage domain name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='storageDomainName'>
            /// The storage domain name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static StorageDomain Get(this IStorageDomains operations, string storageDomainName, string resourceGroupName, string managerName)
            {
                return operations.GetAsync(storageDomainName, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the properties of the specified storage domain name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='storageDomainName'>
            /// The storage domain name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageDomain> GetAsync(this IStorageDomains operations, string storageDomainName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(storageDomainName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the storage domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='storageDomainName'>
            /// The storage domain name.
            /// </param>
            /// <param name='storageDomain'>
            /// The storageDomain.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static StorageDomain CreateOrUpdate(this IStorageDomains operations, string storageDomainName, StorageDomain storageDomain, string resourceGroupName, string managerName)
            {
                return operations.CreateOrUpdateAsync(storageDomainName, storageDomain, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the storage domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='storageDomainName'>
            /// The storage domain name.
            /// </param>
            /// <param name='storageDomain'>
            /// The storageDomain.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageDomain> CreateOrUpdateAsync(this IStorageDomains operations, string storageDomainName, StorageDomain storageDomain, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(storageDomainName, storageDomain, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the storage domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='storageDomainName'>
            /// The storage domain name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static void Delete(this IStorageDomains operations, string storageDomainName, string resourceGroupName, string managerName)
            {
                operations.DeleteAsync(storageDomainName, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the storage domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='storageDomainName'>
            /// The storage domain name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IStorageDomains operations, string storageDomainName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(storageDomainName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
