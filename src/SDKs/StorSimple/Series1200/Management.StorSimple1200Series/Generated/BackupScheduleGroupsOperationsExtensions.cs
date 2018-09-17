// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupScheduleGroupsOperations.
    /// </summary>
    public static partial class BackupScheduleGroupsOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static IEnumerable<BackupScheduleGroup> ListByDevice(this IBackupScheduleGroupsOperations operations, string deviceName, string resourceGroupName, string managerName)
            {
                return operations.ListByDeviceAsync(deviceName, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
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
            public static async Task<IEnumerable<BackupScheduleGroup>> ListByDeviceAsync(this IBackupScheduleGroupsOperations operations, string deviceName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDeviceWithHttpMessagesAsync(deviceName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static BackupScheduleGroup Get(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, string resourceGroupName, string managerName)
            {
                return operations.GetAsync(deviceName, scheduleGroupName, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
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
            public static async Task<BackupScheduleGroup> GetAsync(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deviceName, scheduleGroupName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='scheduleGroup'>
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static BackupScheduleGroup CreateOrUpdate(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, BackupScheduleGroup scheduleGroup, string resourceGroupName, string managerName)
            {
                return operations.CreateOrUpdateAsync(deviceName, scheduleGroupName, scheduleGroup, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='scheduleGroup'>
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
            public static async Task<BackupScheduleGroup> CreateOrUpdateAsync(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, BackupScheduleGroup scheduleGroup, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(deviceName, scheduleGroupName, scheduleGroup, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static void Delete(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, string resourceGroupName, string managerName)
            {
                operations.DeleteAsync(deviceName, scheduleGroupName, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
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
            public static async Task DeleteAsync(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(deviceName, scheduleGroupName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='scheduleGroup'>
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static BackupScheduleGroup BeginCreateOrUpdate(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, BackupScheduleGroup scheduleGroup, string resourceGroupName, string managerName)
            {
                return operations.BeginCreateOrUpdateAsync(deviceName, scheduleGroupName, scheduleGroup, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='scheduleGroup'>
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
            public static async Task<BackupScheduleGroup> BeginCreateOrUpdateAsync(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, BackupScheduleGroup scheduleGroup, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(deviceName, scheduleGroupName, scheduleGroup, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name
            /// </param>
            /// <param name='managerName'>
            /// The manager name
            /// </param>
            public static void BeginDelete(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, string resourceGroupName, string managerName)
            {
                operations.BeginDeleteAsync(deviceName, scheduleGroupName, resourceGroupName, managerName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// </param>
            /// <param name='scheduleGroupName'>
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
            public static async Task BeginDeleteAsync(this IBackupScheduleGroupsOperations operations, string deviceName, string scheduleGroupName, string resourceGroupName, string managerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(deviceName, scheduleGroupName, resourceGroupName, managerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
