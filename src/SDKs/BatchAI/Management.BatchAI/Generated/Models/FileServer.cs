// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about the File Server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FileServer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FileServer class.
        /// </summary>
        public FileServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileServer class.
        /// </summary>
        /// <param name="id">The ID of the resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource</param>
        /// <param name="location">The location of the resource</param>
        /// <param name="tags">The tags of the resource</param>
        /// <param name="vmSize">The size of the virtual machine of the File
        /// Server.</param>
        /// <param name="sshConfiguration">SSH settings for the File
        /// Server.</param>
        /// <param name="dataDisks">Settings for the data disk which would be
        /// created for the File Server.</param>
        /// <param name="subnet">Specifies the identifier of the
        /// subnet.</param>
        /// <param name="mountSettings">Details of the File Server.</param>
        /// <param name="provisioningStateTransitionTime">Time when the status
        /// was changed.</param>
        /// <param name="creationTime">Time when the FileServer was
        /// created.</param>
        /// <param name="provisioningState">Specifies the provisioning state of
        /// the File Server.</param>
        public FileServer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string vmSize = default(string), SshConfiguration sshConfiguration = default(SshConfiguration), DataDisks dataDisks = default(DataDisks), ResourceId subnet = default(ResourceId), MountSettings mountSettings = default(MountSettings), System.DateTime? provisioningStateTransitionTime = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), FileServerProvisioningState provisioningState = default(FileServerProvisioningState))
            : base(id, name, type, location, tags)
        {
            VmSize = vmSize;
            SshConfiguration = sshConfiguration;
            DataDisks = dataDisks;
            Subnet = subnet;
            MountSettings = mountSettings;
            ProvisioningStateTransitionTime = provisioningStateTransitionTime;
            CreationTime = creationTime;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the size of the virtual machine of the File Server.
        /// </summary>
        /// <remarks>
        /// For information about available VM sizes for File Server from the
        /// Virtual Machines Marketplace, see Sizes for Virtual Machines
        /// (Linux).
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets SSH settings for the File Server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sshConfiguration")]
        public SshConfiguration SshConfiguration { get; set; }

        /// <summary>
        /// Gets or sets settings for the data disk which would be created for
        /// the File Server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataDisks")]
        public DataDisks DataDisks { get; set; }

        /// <summary>
        /// Gets or sets specifies the identifier of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public ResourceId Subnet { get; set; }

        /// <summary>
        /// Gets details of the File Server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mountSettings")]
        public MountSettings MountSettings { get; private set; }

        /// <summary>
        /// Gets time when the status was changed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningStateTransitionTime")]
        public System.DateTime? ProvisioningStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets time when the FileServer was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets specifies the provisioning state of the File Server.
        /// </summary>
        /// <remarks>
        /// Possible values: creating - The File Server is getting created.
        /// updating - The File Server creation has been accepted and it is
        /// getting updated. deleting - The user has requested that the File
        /// Server be deleted, and it is in the process of being deleted.
        /// failed - The File Server creation has failed with the specified
        /// errorCode. Details about the error code are specified in the
        /// message field. succeeded - The File Server creation has succeeded.
        /// Possible values include: 'creating', 'updating', 'deleting',
        /// 'succeeded', 'failed'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public FileServerProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SshConfiguration != null)
            {
                SshConfiguration.Validate();
            }
            if (DataDisks != null)
            {
                DataDisks.Validate();
            }
            if (Subnet != null)
            {
                Subnet.Validate();
            }
        }
    }
}
