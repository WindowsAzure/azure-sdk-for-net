// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters of a managed disk.
    /// </summary>
    public partial class ManagedDiskParameters : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedDiskParameters class.
        /// </summary>
        public ManagedDiskParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedDiskParameters class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="storageAccountType">Specifies the storage account type
        /// for the managed disk. NOTE: UltraSSD_LRS can only be used with data
        /// disks, it cannot be used with OS Disk. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS',
        /// 'UltraSSD_LRS'</param>
        /// <param name="diskEncryptionSet">Specifies the customer managed disk
        /// encryption set resource id for the managed disk.</param>
        public ManagedDiskParameters(string id = default(string), string storageAccountType = default(string), DiskEncryptionSet diskEncryptionSet = default(DiskEncryptionSet))
            : base(id)
        {
            StorageAccountType = storageAccountType;
            DiskEncryptionSet = diskEncryptionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the storage account type for the managed
        /// disk. NOTE: UltraSSD_LRS can only be used with data disks, it
        /// cannot be used with OS Disk. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS', 'UltraSSD_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountType")]
        public string StorageAccountType { get; set; }

        /// <summary>
        /// Gets or sets specifies the customer managed disk encryption set
        /// resource id for the managed disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSet")]
        public DiskEncryptionSet DiskEncryptionSet { get; set; }

    }
}
