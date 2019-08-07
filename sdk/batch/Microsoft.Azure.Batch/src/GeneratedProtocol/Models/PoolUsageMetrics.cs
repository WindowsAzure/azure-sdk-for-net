// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Usage metrics for a Pool across an aggregation interval.
    /// </summary>
    public partial class PoolUsageMetrics
    {
        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        public PoolUsageMetrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        /// <param name="poolId">The ID of the Pool whose metrics are
        /// aggregated in this entry.</param>
        /// <param name="startTime">The start time of the aggregation interval
        /// covered by this entry.</param>
        /// <param name="endTime">The end time of the aggregation interval
        /// covered by this entry.</param>
        /// <param name="vmSize">The size of virtual machines in the Pool. All
        /// VMs in a Pool are the same size.</param>
        /// <param name="totalCoreHours">The total core hours used in the Pool
        /// during this aggregation interval.</param>
        public PoolUsageMetrics(string poolId, System.DateTime startTime, System.DateTime endTime, string vmSize, double totalCoreHours)
        {
            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the Pool whose metrics are aggregated in
        /// this entry.
        /// </summary>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets the start time of the aggregation interval covered by
        /// this entry.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the aggregation interval covered by
        /// this entry.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the Pool. All VMs in a
        /// Pool are the same size.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines in Pools,
        /// see Choose a VM size for Compute Nodes in an Azure Batch Pool
        /// (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes).
        /// </remarks>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the total core hours used in the Pool during this
        /// aggregation interval.
        /// </summary>
        [JsonProperty(PropertyName = "totalCoreHours")]
        public double TotalCoreHours { get; set; }

    }
}
