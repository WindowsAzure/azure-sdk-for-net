// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Workload group operations for a data warehouse. </summary>
    public partial class WorkloadGroup : Resource
    {
        /// <summary> Initializes a new instance of WorkloadGroup. </summary>
        public WorkloadGroup()
        {
        }

        /// <summary> Initializes a new instance of WorkloadGroup. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="minResourcePercent"> The workload group minimum percentage resource. </param>
        /// <param name="maxResourcePercent"> The workload group cap percentage resource. </param>
        /// <param name="minResourcePercentPerRequest"> The workload group request minimum grant percentage. </param>
        /// <param name="maxResourcePercentPerRequest"> The workload group request maximum grant percentage. </param>
        /// <param name="importance"> The workload group importance level. </param>
        /// <param name="queryExecutionTimeout"> The workload group query execution timeout. </param>
        internal WorkloadGroup(string id, string name, string type, int? minResourcePercent, int? maxResourcePercent, double? minResourcePercentPerRequest, double? maxResourcePercentPerRequest, string importance, int? queryExecutionTimeout) : base(id, name, type)
        {
            MinResourcePercent = minResourcePercent;
            MaxResourcePercent = maxResourcePercent;
            MinResourcePercentPerRequest = minResourcePercentPerRequest;
            MaxResourcePercentPerRequest = maxResourcePercentPerRequest;
            Importance = importance;
            QueryExecutionTimeout = queryExecutionTimeout;
        }

        /// <summary> The workload group minimum percentage resource. </summary>
        public int? MinResourcePercent { get; set; }
        /// <summary> The workload group cap percentage resource. </summary>
        public int? MaxResourcePercent { get; set; }
        /// <summary> The workload group request minimum grant percentage. </summary>
        public double? MinResourcePercentPerRequest { get; set; }
        /// <summary> The workload group request maximum grant percentage. </summary>
        public double? MaxResourcePercentPerRequest { get; set; }
        /// <summary> The workload group importance level. </summary>
        public string Importance { get; set; }
        /// <summary> The workload group query execution timeout. </summary>
        public int? QueryExecutionTimeout { get; set; }
    }
}
