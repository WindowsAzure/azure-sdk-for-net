// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines workload agnostic properties for a job.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Job")]
    public partial class Job
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="entityFriendlyName">Friendly name of the entity on
        /// which the current job is executing.</param>
        /// <param name="backupManagementType">Backup management type to
        /// execute the current job. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="status">Job status.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="activityId">ActivityId of job.</param>
        public Job(string entityFriendlyName = default(string), string backupManagementType = default(string), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string))
        {
            EntityFriendlyName = entityFriendlyName;
            BackupManagementType = backupManagementType;
            Operation = operation;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            ActivityId = activityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the entity on which the current job
        /// is executing.
        /// </summary>
        [JsonProperty(PropertyName = "entityFriendlyName")]
        public string EntityFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets backup management type to execute the current job.
        /// Possible values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
        /// 'DefaultBackup'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets the operation name.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets job status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets activityId of job.
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

    }
}
