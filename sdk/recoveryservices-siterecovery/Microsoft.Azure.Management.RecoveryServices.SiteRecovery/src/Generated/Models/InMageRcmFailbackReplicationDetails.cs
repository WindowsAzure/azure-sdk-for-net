// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMageRcmFailback provider specific details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcmFailback")]
    public partial class InMageRcmFailbackReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageRcmFailbackReplicationDetails class.
        /// </summary>
        public InMageRcmFailbackReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageRcmFailbackReplicationDetails class.
        /// </summary>
        /// <param name="internalIdentifier">The virtual machine internal
        /// identifier.</param>
        /// <param name="azureVirtualMachineId">The ARM Id of the azure
        /// VM.</param>
        /// <param name="multiVmGroupName">The multi VM group name.</param>
        /// <param name="reprotectAgentId">The reprotect agent Id.</param>
        /// <param name="reprotectAgentName">The reprotect agent name.</param>
        /// <param name="osType">The type of the OS on the VM.</param>
        /// <param name="logStorageAccountId">The log storage account ARM
        /// Id.</param>
        /// <param name="targetvCenterId">The target vCenter Id.</param>
        /// <param name="targetDataStoreName">The target datastore
        /// name.</param>
        /// <param name="targetVmName">The target VM name.</param>
        /// <param name="initialReplicationProgressPercentage">The initial
        /// replication progress percentage.</param>
        /// <param name="initialReplicationProcessedBytes">The initial
        /// replication processed bytes. This includes sum of total bytes
        /// transferred and matched bytes on all selected disks in source
        /// VM.</param>
        /// <param name="initialReplicationTransferredBytes">The initial
        /// replication transferred bytes from source VM to target for all
        /// selected disks on source VM.</param>
        /// <param name="initialReplicationProgressHealth">The initial
        /// replication progress health. Possible values include: 'None',
        /// 'InProgress', 'SlowProgress', 'NoProgress'</param>
        /// <param name="resyncProgressPercentage">The resync progress
        /// percentage.</param>
        /// <param name="resyncProcessedBytes">The resync processed bytes. This
        /// includes sum of total bytes transferred and matched bytes on all
        /// selected disks in source VM.</param>
        /// <param name="resyncTransferredBytes">The resync transferred bytes
        /// from source VM to target for all selected disks on source
        /// VM.</param>
        /// <param name="resyncProgressHealth">The resync progress health.
        /// Possible values include: 'None', 'InProgress', 'SlowProgress',
        /// 'NoProgress'</param>
        /// <param name="resyncRequired">A value indicating whether resync is
        /// required.</param>
        /// <param name="resyncState">The resync state. Possible values
        /// include: 'None', 'PreparedForResynchronization',
        /// 'StartedResynchronization'</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="mobilityAgentDetails">The mobility agent
        /// information.</param>
        /// <param name="vmNics">The network details.</param>
        public InMageRcmFailbackReplicationDetails(string internalIdentifier = default(string), string azureVirtualMachineId = default(string), string multiVmGroupName = default(string), string reprotectAgentId = default(string), string reprotectAgentName = default(string), string osType = default(string), string logStorageAccountId = default(string), string targetvCenterId = default(string), string targetDataStoreName = default(string), string targetVmName = default(string), int? initialReplicationProgressPercentage = default(int?), long? initialReplicationProcessedBytes = default(long?), long? initialReplicationTransferredBytes = default(long?), string initialReplicationProgressHealth = default(string), int? resyncProgressPercentage = default(int?), long? resyncProcessedBytes = default(long?), long? resyncTransferredBytes = default(long?), string resyncProgressHealth = default(string), string resyncRequired = default(string), string resyncState = default(string), IList<InMageRcmFailbackProtectedDiskDetails> protectedDisks = default(IList<InMageRcmFailbackProtectedDiskDetails>), InMageRcmFailbackMobilityAgentDetails mobilityAgentDetails = default(InMageRcmFailbackMobilityAgentDetails), IList<InMageRcmFailbackNicDetails> vmNics = default(IList<InMageRcmFailbackNicDetails>))
        {
            InternalIdentifier = internalIdentifier;
            AzureVirtualMachineId = azureVirtualMachineId;
            MultiVmGroupName = multiVmGroupName;
            ReprotectAgentId = reprotectAgentId;
            ReprotectAgentName = reprotectAgentName;
            OsType = osType;
            LogStorageAccountId = logStorageAccountId;
            TargetvCenterId = targetvCenterId;
            TargetDataStoreName = targetDataStoreName;
            TargetVmName = targetVmName;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
            InitialReplicationProcessedBytes = initialReplicationProcessedBytes;
            InitialReplicationTransferredBytes = initialReplicationTransferredBytes;
            InitialReplicationProgressHealth = initialReplicationProgressHealth;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncProcessedBytes = resyncProcessedBytes;
            ResyncTransferredBytes = resyncTransferredBytes;
            ResyncProgressHealth = resyncProgressHealth;
            ResyncRequired = resyncRequired;
            ResyncState = resyncState;
            ProtectedDisks = protectedDisks;
            MobilityAgentDetails = mobilityAgentDetails;
            VmNics = vmNics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual machine internal identifier.
        /// </summary>
        [JsonProperty(PropertyName = "internalIdentifier")]
        public string InternalIdentifier { get; private set; }

        /// <summary>
        /// Gets the ARM Id of the azure VM.
        /// </summary>
        [JsonProperty(PropertyName = "azureVirtualMachineId")]
        public string AzureVirtualMachineId { get; private set; }

        /// <summary>
        /// Gets the multi VM group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; private set; }

        /// <summary>
        /// Gets the reprotect agent Id.
        /// </summary>
        [JsonProperty(PropertyName = "reprotectAgentId")]
        public string ReprotectAgentId { get; private set; }

        /// <summary>
        /// Gets the reprotect agent name.
        /// </summary>
        [JsonProperty(PropertyName = "reprotectAgentName")]
        public string ReprotectAgentName { get; private set; }

        /// <summary>
        /// Gets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; private set; }

        /// <summary>
        /// Gets the log storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; private set; }

        /// <summary>
        /// Gets the target vCenter Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetvCenterId")]
        public string TargetvCenterId { get; private set; }

        /// <summary>
        /// Gets the target datastore name.
        /// </summary>
        [JsonProperty(PropertyName = "targetDataStoreName")]
        public string TargetDataStoreName { get; private set; }

        /// <summary>
        /// Gets the target VM name.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmName")]
        public string TargetVmName { get; private set; }

        /// <summary>
        /// Gets the initial replication progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProgressPercentage")]
        public int? InitialReplicationProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the initial replication processed bytes. This includes sum of
        /// total bytes transferred and matched bytes on all selected disks in
        /// source VM.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProcessedBytes")]
        public long? InitialReplicationProcessedBytes { get; private set; }

        /// <summary>
        /// Gets the initial replication transferred bytes from source VM to
        /// target for all selected disks on source VM.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationTransferredBytes")]
        public long? InitialReplicationTransferredBytes { get; private set; }

        /// <summary>
        /// Gets the initial replication progress health. Possible values
        /// include: 'None', 'InProgress', 'SlowProgress', 'NoProgress'
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProgressHealth")]
        public string InitialReplicationProgressHealth { get; private set; }

        /// <summary>
        /// Gets the resync progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the resync processed bytes. This includes sum of total bytes
        /// transferred and matched bytes on all selected disks in source VM.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProcessedBytes")]
        public long? ResyncProcessedBytes { get; private set; }

        /// <summary>
        /// Gets the resync transferred bytes from source VM to target for all
        /// selected disks on source VM.
        /// </summary>
        [JsonProperty(PropertyName = "resyncTransferredBytes")]
        public long? ResyncTransferredBytes { get; private set; }

        /// <summary>
        /// Gets the resync progress health. Possible values include: 'None',
        /// 'InProgress', 'SlowProgress', 'NoProgress'
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressHealth")]
        public string ResyncProgressHealth { get; private set; }

        /// <summary>
        /// Gets a value indicating whether resync is required.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public string ResyncRequired { get; private set; }

        /// <summary>
        /// Gets the resync state. Possible values include: 'None',
        /// 'PreparedForResynchronization', 'StartedResynchronization'
        /// </summary>
        [JsonProperty(PropertyName = "resyncState")]
        public string ResyncState { get; private set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<InMageRcmFailbackProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets the mobility agent information.
        /// </summary>
        [JsonProperty(PropertyName = "mobilityAgentDetails")]
        public InMageRcmFailbackMobilityAgentDetails MobilityAgentDetails { get; set; }

        /// <summary>
        /// Gets or sets the network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<InMageRcmFailbackNicDetails> VmNics { get; set; }

    }
}
