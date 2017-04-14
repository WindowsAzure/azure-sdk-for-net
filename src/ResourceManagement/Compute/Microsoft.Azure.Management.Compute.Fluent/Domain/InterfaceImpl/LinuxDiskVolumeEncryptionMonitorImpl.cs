// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using System.Collections.Generic;

    internal partial class LinuxDiskVolumeEncryptionMonitorImpl 
    {
        /// <summary>
        /// Refreshes the resource to sync with Azure.
        /// </summary>
        /// <return>The refreshed resource.</return>
        Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor>.Refresh()
        {
            return this.Refresh() as Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor;
        }

        /// <summary>
        /// Gets operating system disk encryption status.
        /// </summary>
        Microsoft.Azure.Management.Compute.Fluent.EncryptionStatus Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor.OSDiskStatus
        {
            get
            {
                return this.OsDiskStatus() as Microsoft.Azure.Management.Compute.Fluent.EncryptionStatus;
            }
        }

        /// <remarks>
        /// Gets (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in
        /// future releases, including removal, regardless of any compatibility expectations set by the containing library
        /// version number.).
        /// </remarks>
        /// <summary>
        /// Gets observable that emits encryption status once the refresh is done.
        /// </summary>
        async Task<Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor> Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<IDiskVolumeEncryptionMonitor>.RefreshAsync(CancellationToken cancellationToken)
        {
            return await this.RefreshAsync(cancellationToken);
        }

        /// <summary>
        /// Gets data disks encryption status.
        /// </summary>
        Microsoft.Azure.Management.Compute.Fluent.EncryptionStatus Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor.DataDiskStatus
        {
            get
            {
                return this.DataDiskStatus() as Microsoft.Azure.Management.Compute.Fluent.EncryptionStatus;
            }
        }

        /// <summary>
        /// Gets the encryption progress message.
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor.ProgressMessage
        {
            get
            {
                return this.ProgressMessage();
            }
        }

        /// <summary>
        /// Gets operating system type of the virtual machine.
        /// </summary>
        Models.OperatingSystemTypes Microsoft.Azure.Management.Compute.Fluent.IDiskVolumeEncryptionMonitor.OSType
        {
            get
            {
                return this.OsType();
            }
        }
    }
}