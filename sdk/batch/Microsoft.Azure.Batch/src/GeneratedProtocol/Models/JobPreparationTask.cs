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
    /// A Job Preparation task to run before any tasks of the job on any given
    /// compute node.
    /// </summary>
    /// <remarks>
    /// You can use Job Preparation to prepare a compute node to run tasks for
    /// the job. Activities commonly performed in Job Preparation include:
    /// Downloading common resource files used by all the tasks in the job. The
    /// Job Preparation task can download these common resource files to the
    /// shared location on the compute node. (AZ_BATCH_NODE_ROOT_DIR\shared),
    /// or starting a local service on the compute node so that all tasks of
    /// that job can communicate with it. If the Job Preparation task fails
    /// (that is, exhausts its retry count before exiting with exit code 0),
    /// Batch will not run tasks of this job on the compute node. The node
    /// remains ineligible to run tasks of this job until it is reimaged. The
    /// node remains active and can be used for other jobs. The Job Preparation
    /// task can run multiple times on the same compute node. Therefore, you
    /// should write the Job Preparation task to handle re-execution. If the
    /// compute node is rebooted, the Job Preparation task is run again on the
    /// node before scheduling any other task of the job, if
    /// rerunOnNodeRebootAfterSuccess is true or if the Job Preparation task
    /// did not previously complete. If the compute node is reimaged, the Job
    /// Preparation task is run again before scheduling any task of the job.
    /// Batch will retry tasks when a recovery operation is triggered on a
    /// compute node. Examples of recovery operations include (but are not
    /// limited to) when an unhealthy compute node is rebooted or a compute
    /// node disappeared due to host failure. Retries due to recovery
    /// operations are independent of and are not counted against the
    /// maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal
    /// retry due to a recovery operation may occur. Because of this, all tasks
    /// should be idempotent. This means tasks need to tolerate being
    /// interrupted and restarted without causing any corruption or duplicate
    /// data. The best practice for long running tasks is to use some form of
    /// checkpointing.
    /// </remarks>
    public partial class JobPreparationTask
    {
        /// <summary>
        /// Initializes a new instance of the JobPreparationTask class.
        /// </summary>
        public JobPreparationTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPreparationTask class.
        /// </summary>
        /// <param name="commandLine">The command line of the Job Preparation
        /// task.</param>
        /// <param name="id">A string that uniquely identifies the Job
        /// Preparation task within the job.</param>
        /// <param name="containerSettings">The settings for the container
        /// under which the Job Preparation task runs.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the Job Preparation task.</param>
        /// <param name="constraints">Constraints that apply to the Job
        /// Preparation task.</param>
        /// <param name="waitForSuccess">Whether the Batch service should wait
        /// for the Job Preparation task to complete successfully before
        /// scheduling any other tasks of the job on the compute node. A Job
        /// Preparation task has completed successfully if it exits with exit
        /// code 0.</param>
        /// <param name="userIdentity">The user identity under which the Job
        /// Preparation task runs.</param>
        /// <param name="rerunOnNodeRebootAfterSuccess">Whether the Batch
        /// service should rerun the Job Preparation task after a compute node
        /// reboots.</param>
        public JobPreparationTask(string commandLine, string id = default(string), TaskContainerSettings containerSettings = default(TaskContainerSettings), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), TaskConstraints constraints = default(TaskConstraints), bool? waitForSuccess = default(bool?), UserIdentity userIdentity = default(UserIdentity), bool? rerunOnNodeRebootAfterSuccess = default(bool?))
        {
            Id = id;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            Constraints = constraints;
            WaitForSuccess = waitForSuccess;
            UserIdentity = userIdentity;
            RerunOnNodeRebootAfterSuccess = rerunOnNodeRebootAfterSuccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job Preparation
        /// task within the job.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores and cannot contain more than 64
        /// characters. If you do not specify this property, the Batch service
        /// assigns a default value of 'jobpreparation'. No other task in the
        /// job can have the same ID as the Job Preparation task. If you try to
        /// submit a task with the same id, the Batch service rejects the
        /// request with error code TaskIdSameAsJobPreparationTask; if you are
        /// calling the REST API directly, the HTTP status code is 409
        /// (Conflict).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the command line of the Job Preparation task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using "cmd
        /// /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the
        /// command line refers to file paths, it should use a relative path
        /// (relative to the task working directory), or use the Batch provided
        /// environment variable
        /// (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets the settings for the container under which the Job
        /// Preparation task runs.
        /// </summary>
        /// <remarks>
        /// When this is specified, all directories recursively below the
        /// AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the
        /// node) are mapped into the container, all task environment variables
        /// are mapped into the container, and the task command line is
        /// executed in the container. Files produced in the container outside
        /// of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk,
        /// meaning that Batch file APIs will not be able to access those
        /// files.
        /// </remarks>
        [JsonProperty(PropertyName = "containerSettings")]
        public TaskContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// Files listed under this element are located in the task's working
        /// directory.  There is a maximum size for the list of resource files.
        /// When the max size is exceeded, the request will fail and the
        /// response error code will be RequestEntityTooLarge. If this occurs,
        /// the collection of ResourceFiles must be reduced in size. This can
        /// be achieved using .zip files, Application Packages, or Docker
        /// Containers.
        /// </remarks>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the Job
        /// Preparation task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets constraints that apply to the Job Preparation task.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether the Batch service should wait for the Job
        /// Preparation task to complete successfully before scheduling any
        /// other tasks of the job on the compute node. A Job Preparation task
        /// has completed successfully if it exits with exit code 0.
        /// </summary>
        /// <remarks>
        /// If true and the Job Preparation task fails on a compute node, the
        /// Batch service retries the Job Preparation task up to its maximum
        /// retry count (as specified in the constraints element). If the task
        /// has still not completed successfully after all retries, then the
        /// Batch service will not schedule tasks of the job to the compute
        /// node. The compute node remains active and eligible to run tasks of
        /// other jobs. If false, the Batch service will not wait for the Job
        /// Preparation task to complete. In this case, other tasks of the job
        /// can start executing on the compute node while the Job Preparation
        /// task is still running; and even if the Job Preparation task fails,
        /// new tasks will continue to be scheduled on the node. The default
        /// value is true.
        /// </remarks>
        [JsonProperty(PropertyName = "waitForSuccess")]
        public bool? WaitForSuccess { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the Job Preparation task
        /// runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to
        /// the task on Windows nodes, or a non-administrative user unique to
        /// the pool on Linux nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Gets or sets whether the Batch service should rerun the Job
        /// Preparation task after a compute node reboots.
        /// </summary>
        /// <remarks>
        /// The Job Preparation task is always rerun if a compute node is
        /// reimaged, or if the Job Preparation task did not complete (e.g.
        /// because the reboot occurred while the task was running). Therefore,
        /// you should always write a Job Preparation task to be idempotent and
        /// to behave correctly if run multiple times. The default value is
        /// true.
        /// </remarks>
        [JsonProperty(PropertyName = "rerunOnNodeRebootAfterSuccess")]
        public bool? RerunOnNodeRebootAfterSuccess { get; set; }

    }
}
