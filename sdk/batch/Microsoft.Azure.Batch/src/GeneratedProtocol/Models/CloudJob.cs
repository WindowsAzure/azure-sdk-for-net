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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch job.
    /// </summary>
    public partial class CloudJob
    {
        /// <summary>
        /// Initializes a new instance of the CloudJob class.
        /// </summary>
        public CloudJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudJob class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the job within
        /// the account.</param>
        /// <param name="displayName">The display name for the job.</param>
        /// <param name="usesTaskDependencies">Whether tasks in the job can
        /// define dependencies on each other. The default is false.</param>
        /// <param name="url">The URL of the job.</param>
        /// <param name="eTag">The ETag of the job.</param>
        /// <param name="lastModified">The last modified time of the
        /// job.</param>
        /// <param name="creationTime">The creation time of the job.</param>
        /// <param name="state">The current state of the job.</param>
        /// <param name="stateTransitionTime">The time at which the job entered
        /// its current state.</param>
        /// <param name="previousState">The previous state of the job.</param>
        /// <param name="previousStateTransitionTime">The time at which the job
        /// entered its previous state.</param>
        /// <param name="priority">The priority of the job.</param>
        /// <param name="constraints">The execution constraints for the
        /// job.</param>
        /// <param name="jobManagerTask">Details of a Job Manager task to be
        /// launched when the job is started.</param>
        /// <param name="jobPreparationTask">The Job Preparation task.</param>
        /// <param name="jobReleaseTask">The Job Release task.</param>
        /// <param name="commonEnvironmentSettings">The list of common
        /// environment variable settings. These environment variables are set
        /// for all tasks in the job (including the Job Manager, Job
        /// Preparation and Job Release tasks).</param>
        /// <param name="poolInfo">The pool settings associated with the
        /// job.</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in the job are in the completed
        /// state.</param>
        /// <param name="onTaskFailure">The action the Batch service should
        /// take when any task in the job fails.</param>
        /// <param name="networkConfiguration">The network configuration for
        /// the job.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job as metadata.</param>
        /// <param name="executionInfo">The execution information for the
        /// job.</param>
        /// <param name="stats">Resource usage statistics for the entire
        /// lifetime of the job.</param>
        public CloudJob(string id = default(string), string displayName = default(string), bool? usesTaskDependencies = default(bool?), string url = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), JobState? state = default(JobState?), System.DateTime? stateTransitionTime = default(System.DateTime?), JobState? previousState = default(JobState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), int? priority = default(int?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), IList<EnvironmentSetting> commonEnvironmentSettings = default(IList<EnvironmentSetting>), PoolInformation poolInfo = default(PoolInformation), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), OnTaskFailure? onTaskFailure = default(OnTaskFailure?), JobNetworkConfiguration networkConfiguration = default(JobNetworkConfiguration), IList<MetadataItem> metadata = default(IList<MetadataItem>), JobExecutionInformation executionInfo = default(JobExecutionInformation), JobStatistics stats = default(JobStatistics))
        {
            Id = id;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Priority = priority;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            NetworkConfiguration = networkConfiguration;
            Metadata = metadata;
            ExecutionInfo = executionInfo;
            Stats = stats;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the job within the
        /// account.
        /// </summary>
        /// <remarks>
        /// The ID is case-preserving and case-insensitive (that is, you may
        /// not have two IDs within an account that differ only by case).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the job.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets whether tasks in the job can define dependencies on
        /// each other. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

        /// <summary>
        /// Gets or sets the URL of the job.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the job.
        /// </summary>
        /// <remarks>
        /// This is an opaque string. You can use it to detect whether the job
        /// has changed between requests. In particular, you can be pass the
        /// ETag when updating a job to specify that your changes should take
        /// effect only if nobody else has modified the job in the meantime.
        /// </remarks>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the job.
        /// </summary>
        /// <remarks>
        /// This is the last time at which the job level data, such as the job
        /// state or priority, changed. It does not factor in task-level
        /// changes such as adding new tasks or tasks changing state.
        /// </remarks>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the job.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'disabling', 'disabled',
        /// 'enabling', 'terminating', 'completed', 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public JobState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job entered its current state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the job.
        /// </summary>
        /// <remarks>
        /// This property is not set if the job is in its initial Active state.
        /// Possible values include: 'active', 'disabling', 'disabled',
        /// 'enabling', 'terminating', 'completed', 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "previousState")]
        public JobState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job entered its previous state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the job is in its initial Active state.
        /// </remarks>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. The default
        /// value is 0.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets details of a Job Manager task to be launched when the
        /// job is started.
        /// </summary>
        [JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation task.
        /// </summary>
        /// <remarks>
        /// The Job Preparation task is a special task run on each node before
        /// any other task of the job.
        /// </remarks>
        [JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release task.
        /// </summary>
        /// <remarks>
        /// The Job Release task is a special task run at the end of the job on
        /// each node that has run any other task of the job.
        /// </remarks>
        [JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets the list of common environment variable settings.
        /// These environment variables are set for all tasks in the job
        /// (including the Job Manager, Job Preparation and Job Release tasks).
        /// </summary>
        /// <remarks>
        /// Individual tasks can override an environment setting specified here
        /// by specifying the same setting name with a different value.
        /// </remarks>
        [JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the pool settings associated with the job.
        /// </summary>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in the job are in the completed state.
        /// </summary>
        /// <remarks>
        /// The default is noaction. Possible values include: 'noAction',
        /// 'terminateJob'
        /// </remarks>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when any task
        /// in the job fails.
        /// </summary>
        /// <remarks>
        /// A task is considered to have failed if has a failureInfo. A
        /// failureInfo is set if the task completes with a non-zero exit code
        /// after exhausting its retry count, or if there was an error starting
        /// the task, for example due to a resource file download error. The
        /// default is noaction. Possible values include: 'noAction',
        /// 'performExitOptionsJobAction'
        /// </remarks>
        [JsonProperty(PropertyName = "onTaskFailure")]
        public OnTaskFailure? OnTaskFailure { get; set; }

        /// <summary>
        /// Gets or sets the network configuration for the job.
        /// </summary>
        [JsonProperty(PropertyName = "networkConfiguration")]
        public JobNetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the execution information for the job.
        /// </summary>
        [JsonProperty(PropertyName = "executionInfo")]
        public JobExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets resource usage statistics for the entire lifetime of
        /// the job.
        /// </summary>
        /// <remarks>
        /// This property is populated only if the CloudJob was retrieved with
        /// an expand clause including the 'stats' attribute; otherwise it is
        /// null. The statistics may not be immediately available. The Batch
        /// service performs periodic roll-up of statistics. The typical delay
        /// is about 30 minutes.
        /// </remarks>
        [JsonProperty(PropertyName = "stats")]
        public JobStatistics Stats { get; set; }

    }
}
