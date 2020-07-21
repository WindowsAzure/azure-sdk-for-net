// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of the disk. </summary>
    public partial class DiskInstanceView
    {
        /// <summary> Initializes a new instance of DiskInstanceView. </summary>
        public DiskInstanceView()
        {
            EncryptionSettings = new ChangeTrackingList<DiskEncryptionSettings>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of DiskInstanceView. </summary>
        /// <param name="name"> The disk name. </param>
        /// <param name="encryptionSettings"> Specifies the encryption settings for the OS Disk. &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal DiskInstanceView(string name, IList<DiskEncryptionSettings> encryptionSettings, IList<InstanceViewStatus> statuses)
        {
            Name = name;
            EncryptionSettings = encryptionSettings;
            Statuses = statuses;
        }

        /// <summary> The disk name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the encryption settings for the OS Disk. &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public IList<DiskEncryptionSettings> EncryptionSettings { get; }
        /// <summary> The resource status information. </summary>
        public IList<InstanceViewStatus> Statuses { get; }
    }
}
