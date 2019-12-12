// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Agent Pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AgentPool : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the AgentPool class.
        /// </summary>
        public AgentPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentPool class.
        /// </summary>
        /// <param name="count">Number of agents (VMs) to host docker
        /// containers. Allowed values must be in the range of 1 to 100
        /// (inclusive). The default value is 1. </param>
        /// <param name="vmSize">Size of agent VMs. Possible values include:
        /// 'Standard_A1', 'Standard_A10', 'Standard_A11', 'Standard_A1_v2',
        /// 'Standard_A2', 'Standard_A2_v2', 'Standard_A2m_v2', 'Standard_A3',
        /// 'Standard_A4', 'Standard_A4_v2', 'Standard_A4m_v2', 'Standard_A5',
        /// 'Standard_A6', 'Standard_A7', 'Standard_A8', 'Standard_A8_v2',
        /// 'Standard_A8m_v2', 'Standard_A9', 'Standard_B2ms', 'Standard_B2s',
        /// 'Standard_B4ms', 'Standard_B8ms', 'Standard_D1', 'Standard_D11',
        /// 'Standard_D11_v2', 'Standard_D11_v2_Promo', 'Standard_D12',
        /// 'Standard_D12_v2', 'Standard_D12_v2_Promo', 'Standard_D13',
        /// 'Standard_D13_v2', 'Standard_D13_v2_Promo', 'Standard_D14',
        /// 'Standard_D14_v2', 'Standard_D14_v2_Promo', 'Standard_D15_v2',
        /// 'Standard_D16_v3', 'Standard_D16s_v3', 'Standard_D1_v2',
        /// 'Standard_D2', 'Standard_D2_v2', 'Standard_D2_v2_Promo',
        /// 'Standard_D2_v3', 'Standard_D2s_v3', 'Standard_D3',
        /// 'Standard_D32_v3', 'Standard_D32s_v3', 'Standard_D3_v2',
        /// 'Standard_D3_v2_Promo', 'Standard_D4', 'Standard_D4_v2',
        /// 'Standard_D4_v2_Promo', 'Standard_D4_v3', 'Standard_D4s_v3',
        /// 'Standard_D5_v2', 'Standard_D5_v2_Promo', 'Standard_D64_v3',
        /// 'Standard_D64s_v3', 'Standard_D8_v3', 'Standard_D8s_v3',
        /// 'Standard_DS1', 'Standard_DS11', 'Standard_DS11_v2',
        /// 'Standard_DS11_v2_Promo', 'Standard_DS12', 'Standard_DS12_v2',
        /// 'Standard_DS12_v2_Promo', 'Standard_DS13', 'Standard_DS13-2_v2',
        /// 'Standard_DS13-4_v2', 'Standard_DS13_v2', 'Standard_DS13_v2_Promo',
        /// 'Standard_DS14', 'Standard_DS14-4_v2', 'Standard_DS14-8_v2',
        /// 'Standard_DS14_v2', 'Standard_DS14_v2_Promo', 'Standard_DS15_v2',
        /// 'Standard_DS1_v2', 'Standard_DS2', 'Standard_DS2_v2',
        /// 'Standard_DS2_v2_Promo', 'Standard_DS3', 'Standard_DS3_v2',
        /// 'Standard_DS3_v2_Promo', 'Standard_DS4', 'Standard_DS4_v2',
        /// 'Standard_DS4_v2_Promo', 'Standard_DS5_v2',
        /// 'Standard_DS5_v2_Promo', 'Standard_E16_v3', 'Standard_E16s_v3',
        /// 'Standard_E2_v3', 'Standard_E2s_v3', 'Standard_E32-16s_v3',
        /// 'Standard_E32-8s_v3', 'Standard_E32_v3', 'Standard_E32s_v3',
        /// 'Standard_E4_v3', 'Standard_E4s_v3', 'Standard_E64-16s_v3',
        /// 'Standard_E64-32s_v3', 'Standard_E64_v3', 'Standard_E64s_v3',
        /// 'Standard_E8_v3', 'Standard_E8s_v3', 'Standard_F1', 'Standard_F16',
        /// 'Standard_F16s', 'Standard_F16s_v2', 'Standard_F1s', 'Standard_F2',
        /// 'Standard_F2s', 'Standard_F2s_v2', 'Standard_F32s_v2',
        /// 'Standard_F4', 'Standard_F4s', 'Standard_F4s_v2',
        /// 'Standard_F64s_v2', 'Standard_F72s_v2', 'Standard_F8',
        /// 'Standard_F8s', 'Standard_F8s_v2', 'Standard_G1', 'Standard_G2',
        /// 'Standard_G3', 'Standard_G4', 'Standard_G5', 'Standard_GS1',
        /// 'Standard_GS2', 'Standard_GS3', 'Standard_GS4', 'Standard_GS4-4',
        /// 'Standard_GS4-8', 'Standard_GS5', 'Standard_GS5-16',
        /// 'Standard_GS5-8', 'Standard_H16', 'Standard_H16m',
        /// 'Standard_H16mr', 'Standard_H16r', 'Standard_H8', 'Standard_H8m',
        /// 'Standard_L16s', 'Standard_L32s', 'Standard_L4s', 'Standard_L8s',
        /// 'Standard_M128-32ms', 'Standard_M128-64ms', 'Standard_M128ms',
        /// 'Standard_M128s', 'Standard_M64-16ms', 'Standard_M64-32ms',
        /// 'Standard_M64ms', 'Standard_M64s', 'Standard_NC12',
        /// 'Standard_NC12s_v2', 'Standard_NC12s_v3', 'Standard_NC24',
        /// 'Standard_NC24r', 'Standard_NC24rs_v2', 'Standard_NC24rs_v3',
        /// 'Standard_NC24s_v2', 'Standard_NC24s_v3', 'Standard_NC6',
        /// 'Standard_NC6s_v2', 'Standard_NC6s_v3', 'Standard_ND12s',
        /// 'Standard_ND24rs', 'Standard_ND24s', 'Standard_ND6s',
        /// 'Standard_NV12', 'Standard_NV24', 'Standard_NV6'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="type">Resource type</param>
        /// <param name="osDiskSizeGB">OS Disk Size in GB to be used to specify
        /// the disk size for every machine in this master/agent pool. If you
        /// specify 0, it will apply the default osDisk size according to the
        /// vmSize specified.</param>
        /// <param name="vnetSubnetID">VNet SubnetID specifies the VNet's
        /// subnet identifier.</param>
        /// <param name="maxPods">Maximum number of pods that can run on a
        /// node.</param>
        /// <param name="osType">OsType to be used to specify os type. Choose
        /// from Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'</param>
        /// <param name="maxCount">Maximum number of nodes for
        /// auto-scaling</param>
        /// <param name="minCount">Minimum number of nodes for
        /// auto-scaling</param>
        /// <param name="enableAutoScaling">Whether to enable
        /// auto-scaler</param>
        /// <param name="agentPoolType">AgentPoolType represents types of an
        /// agent pool. Possible values include: 'VirtualMachineScaleSets',
        /// 'AvailabilitySet'</param>
        /// <param name="orchestratorVersion">Version of orchestrator specified
        /// when creating the managed cluster.</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="availabilityZones">Availability zones for nodes. Must
        /// use VirtualMachineScaleSets AgentPoolType.</param>
        /// <param name="enableNodePublicIP">Enable public IP for nodes</param>
        /// <param name="scaleSetPriority">ScaleSetPriority to be used to
        /// specify virtual machine scale set priority. Default to regular.
        /// Possible values include: 'Low', 'Regular'</param>
        /// <param name="scaleSetEvictionPolicy">ScaleSetEvictionPolicy to be
        /// used to specify eviction policy for low priority virtual machine
        /// scale set. Default to Delete. Possible values include: 'Delete',
        /// 'Deallocate'</param>
        /// <param name="tags">Agent pool tags to be persisted on the agent
        /// pool virtual machine scale set.</param>
        /// <param name="nodeLabels">Agent pool node labels to be persisted
        /// across all nodes in agent pool.</param>
        /// <param name="nodeTaints">Taints added to new nodes during node pool
        /// create and scale. For example, key=value:NoSchedule.</param>
        public AgentPool(int count, string vmSize, string id = default(string), string name = default(string), string type = default(string), int? osDiskSizeGB = default(int?), string vnetSubnetID = default(string), int? maxPods = default(int?), string osType = default(string), int? maxCount = default(int?), int? minCount = default(int?), bool? enableAutoScaling = default(bool?), string agentPoolType = default(string), string orchestratorVersion = default(string), string provisioningState = default(string), IList<string> availabilityZones = default(IList<string>), bool? enableNodePublicIP = default(bool?), string scaleSetPriority = default(string), string scaleSetEvictionPolicy = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> nodeLabels = default(IDictionary<string, string>), IList<string> nodeTaints = default(IList<string>))
            : base(id, name, type)
        {
            Count = count;
            VmSize = vmSize;
            OsDiskSizeGB = osDiskSizeGB;
            VnetSubnetID = vnetSubnetID;
            MaxPods = maxPods;
            OsType = osType;
            MaxCount = maxCount;
            MinCount = minCount;
            EnableAutoScaling = enableAutoScaling;
            AgentPoolType = agentPoolType;
            OrchestratorVersion = orchestratorVersion;
            ProvisioningState = provisioningState;
            AvailabilityZones = availabilityZones;
            EnableNodePublicIP = enableNodePublicIP;
            ScaleSetPriority = scaleSetPriority;
            ScaleSetEvictionPolicy = scaleSetEvictionPolicy;
            Tags = tags;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of agents (VMs) to host docker containers.
        /// Allowed values must be in the range of 1 to 100 (inclusive). The
        /// default value is 1.
        /// </summary>
        [JsonProperty(PropertyName = "properties.count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets size of agent VMs. Possible values include:
        /// 'Standard_A1', 'Standard_A10', 'Standard_A11', 'Standard_A1_v2',
        /// 'Standard_A2', 'Standard_A2_v2', 'Standard_A2m_v2', 'Standard_A3',
        /// 'Standard_A4', 'Standard_A4_v2', 'Standard_A4m_v2', 'Standard_A5',
        /// 'Standard_A6', 'Standard_A7', 'Standard_A8', 'Standard_A8_v2',
        /// 'Standard_A8m_v2', 'Standard_A9', 'Standard_B2ms', 'Standard_B2s',
        /// 'Standard_B4ms', 'Standard_B8ms', 'Standard_D1', 'Standard_D11',
        /// 'Standard_D11_v2', 'Standard_D11_v2_Promo', 'Standard_D12',
        /// 'Standard_D12_v2', 'Standard_D12_v2_Promo', 'Standard_D13',
        /// 'Standard_D13_v2', 'Standard_D13_v2_Promo', 'Standard_D14',
        /// 'Standard_D14_v2', 'Standard_D14_v2_Promo', 'Standard_D15_v2',
        /// 'Standard_D16_v3', 'Standard_D16s_v3', 'Standard_D1_v2',
        /// 'Standard_D2', 'Standard_D2_v2', 'Standard_D2_v2_Promo',
        /// 'Standard_D2_v3', 'Standard_D2s_v3', 'Standard_D3',
        /// 'Standard_D32_v3', 'Standard_D32s_v3', 'Standard_D3_v2',
        /// 'Standard_D3_v2_Promo', 'Standard_D4', 'Standard_D4_v2',
        /// 'Standard_D4_v2_Promo', 'Standard_D4_v3', 'Standard_D4s_v3',
        /// 'Standard_D5_v2', 'Standard_D5_v2_Promo', 'Standard_D64_v3',
        /// 'Standard_D64s_v3', 'Standard_D8_v3', 'Standard_D8s_v3',
        /// 'Standard_DS1', 'Standard_DS11', 'Standard_DS11_v2',
        /// 'Standard_DS11_v2_Promo', 'Standard_DS12', 'Standard_DS12_v2',
        /// 'Standard_DS12_v2_Promo', 'Standard_DS13', 'Standard_DS13-2_v2',
        /// 'Standard_DS13-4_v2', 'Standard_DS13_v2', 'Standard_DS13_v2_Promo',
        /// 'Standard_DS14', 'Standard_DS14-4_v2', 'Standard_DS14-8_v2',
        /// 'Standard_DS14_v2', 'Standard_DS14_v2_Promo', 'Standard_DS15_v2',
        /// 'Standard_DS1_v2', 'Standard_DS2', 'Standard_DS2_v2',
        /// 'Standard_DS2_v2_Promo', 'Standard_DS3', 'Standard_DS3_v2',
        /// 'Standard_DS3_v2_Promo', 'Standard_DS4', 'Standard_DS4_v2',
        /// 'Standard_DS4_v2_Promo', 'Standard_DS5_v2',
        /// 'Standard_DS5_v2_Promo', 'Standard_E16_v3', 'Standard_E16s_v3',
        /// 'Standard_E2_v3', 'Standard_E2s_v3', 'Standard_E32-16s_v3',
        /// 'Standard_E32-8s_v3', 'Standard_E32_v3', 'Standard_E32s_v3',
        /// 'Standard_E4_v3', 'Standard_E4s_v3', 'Standard_E64-16s_v3',
        /// 'Standard_E64-32s_v3', 'Standard_E64_v3', 'Standard_E64s_v3',
        /// 'Standard_E8_v3', 'Standard_E8s_v3', 'Standard_F1', 'Standard_F16',
        /// 'Standard_F16s', 'Standard_F16s_v2', 'Standard_F1s', 'Standard_F2',
        /// 'Standard_F2s', 'Standard_F2s_v2', 'Standard_F32s_v2',
        /// 'Standard_F4', 'Standard_F4s', 'Standard_F4s_v2',
        /// 'Standard_F64s_v2', 'Standard_F72s_v2', 'Standard_F8',
        /// 'Standard_F8s', 'Standard_F8s_v2', 'Standard_G1', 'Standard_G2',
        /// 'Standard_G3', 'Standard_G4', 'Standard_G5', 'Standard_GS1',
        /// 'Standard_GS2', 'Standard_GS3', 'Standard_GS4', 'Standard_GS4-4',
        /// 'Standard_GS4-8', 'Standard_GS5', 'Standard_GS5-16',
        /// 'Standard_GS5-8', 'Standard_H16', 'Standard_H16m',
        /// 'Standard_H16mr', 'Standard_H16r', 'Standard_H8', 'Standard_H8m',
        /// 'Standard_L16s', 'Standard_L32s', 'Standard_L4s', 'Standard_L8s',
        /// 'Standard_M128-32ms', 'Standard_M128-64ms', 'Standard_M128ms',
        /// 'Standard_M128s', 'Standard_M64-16ms', 'Standard_M64-32ms',
        /// 'Standard_M64ms', 'Standard_M64s', 'Standard_NC12',
        /// 'Standard_NC12s_v2', 'Standard_NC12s_v3', 'Standard_NC24',
        /// 'Standard_NC24r', 'Standard_NC24rs_v2', 'Standard_NC24rs_v3',
        /// 'Standard_NC24s_v2', 'Standard_NC24s_v3', 'Standard_NC6',
        /// 'Standard_NC6s_v2', 'Standard_NC6s_v3', 'Standard_ND12s',
        /// 'Standard_ND24rs', 'Standard_ND24s', 'Standard_ND6s',
        /// 'Standard_NV12', 'Standard_NV24', 'Standard_NV6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets OS Disk Size in GB to be used to specify the disk size
        /// for every machine in this master/agent pool. If you specify 0, it
        /// will apply the default osDisk size according to the vmSize
        /// specified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osDiskSizeGB")]
        public int? OsDiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets vNet SubnetID specifies the VNet's subnet identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetSubnetID")]
        public string VnetSubnetID { get; set; }

        /// <summary>
        /// Gets or sets maximum number of pods that can run on a node.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxPods")]
        public int? MaxPods { get; set; }

        /// <summary>
        /// Gets or sets osType to be used to specify os type. Choose from
        /// Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets maximum number of nodes for auto-scaling
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxCount")]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Gets or sets minimum number of nodes for auto-scaling
        /// </summary>
        [JsonProperty(PropertyName = "properties.minCount")]
        public int? MinCount { get; set; }

        /// <summary>
        /// Gets or sets whether to enable auto-scaler
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAutoScaling")]
        public bool? EnableAutoScaling { get; set; }

        /// <summary>
        /// Gets or sets agentPoolType represents types of an agent pool.
        /// Possible values include: 'VirtualMachineScaleSets',
        /// 'AvailabilitySet'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string AgentPoolType { get; set; }

        /// <summary>
        /// Gets or sets version of orchestrator specified when creating the
        /// managed cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orchestratorVersion")]
        public string OrchestratorVersion { get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets availability zones for nodes. Must use
        /// VirtualMachineScaleSets AgentPoolType.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilityZones")]
        public IList<string> AvailabilityZones { get; set; }

        /// <summary>
        /// Gets or sets enable public IP for nodes
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableNodePublicIP")]
        public bool? EnableNodePublicIP { get; set; }

        /// <summary>
        /// Gets or sets scaleSetPriority to be used to specify virtual machine
        /// scale set priority. Default to regular. Possible values include:
        /// 'Low', 'Regular'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleSetPriority")]
        public string ScaleSetPriority { get; set; }

        /// <summary>
        /// Gets or sets scaleSetEvictionPolicy to be used to specify eviction
        /// policy for low priority virtual machine scale set. Default to
        /// Delete. Possible values include: 'Delete', 'Deallocate'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleSetEvictionPolicy")]
        public string ScaleSetEvictionPolicy { get; set; }

        /// <summary>
        /// Gets or sets agent pool tags to be persisted on the agent pool
        /// virtual machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets agent pool node labels to be persisted across all
        /// nodes in agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeLabels")]
        public IDictionary<string, string> NodeLabels { get; set; }

        /// <summary>
        /// Gets or sets taints added to new nodes during node pool create and
        /// scale. For example, key=value:NoSchedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeTaints")]
        public IList<string> NodeTaints { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VmSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmSize");
            }
            if (Count > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Count", 100);
            }
            if (Count < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Count", 1);
            }
        }
    }
}
