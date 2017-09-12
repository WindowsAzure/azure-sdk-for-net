// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the execution of a job in the Azure Batch
    /// service.
    /// </summary>
    public partial class JobExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobExecutionInformation class.
        /// </summary>
        public JobExecutionInformation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobExecutionInformation class.
        /// </summary>
        /// <param name="startTime">The start time of the job.</param>
        /// <param name="endTime">The completion time of the job.</param>
        /// <param name="poolId">The ID of the pool to which this job is
        /// assigned.</param>
        /// <param name="schedulingError">Details of any error encountered by
        /// the service in starting the job.</param>
        /// <param name="terminateReason">A string describing the reason the
        /// job ended.</param>
        public JobExecutionInformation(System.DateTime startTime, System.DateTime? endTime = default(System.DateTime?), string poolId = default(string), JobSchedulingError schedulingError = default(JobSchedulingError), string terminateReason = default(string))
        {
            StartTime = startTime;
            EndTime = endTime;
            PoolId = poolId;
            SchedulingError = schedulingError;
            TerminateReason = terminateReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start time of the job.
        /// </summary>
        /// <remarks>
        /// This is the time at which the job was created.
        /// </remarks>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the completion time of the job.
        /// </summary>
        /// <remarks>
        /// This property is set only if the job is in the completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the ID of the pool to which this job is assigned.
        /// </summary>
        /// <remarks>
        /// This element contains the actual pool where the job is assigned.
        /// When you get job details from the service, they also contain a
        /// poolInfo element, which contains the pool configuration data from
        /// when the job was added or updated. That poolInfo element may also
        /// contain a poolId element. If it does, the two IDs are the same. If
        /// it does not, it means the job ran on an auto pool, and this
        /// property contains the ID of that auto pool.
        /// </remarks>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets details of any error encountered by the service in
        /// starting the job.
        /// </summary>
        /// <remarks>
        /// This property is not set if there was no error starting the job.
        /// </remarks>
        [JsonProperty(PropertyName = "schedulingError")]
        public JobSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets a string describing the reason the job ended.
        /// </summary>
        /// <remarks>
        /// This property is set only if the job is in the completed state. If
        /// the Batch service terminates the job, it sets the reason as
        /// follows: JMComplete - the Job Manager task completed, and
        /// killJobOnCompletion was set to true. MaxWallClockTimeExpiry - the
        /// job reached its maxWallClockTime constraint. TerminateJobSchedule -
        /// the job ran as part of a schedule, and the schedule terminated.
        /// AllTasksComplete - the job's onAllTasksComplete attribute is set to
        /// terminateJob, and all tasks in the job are complete. TaskFailed -
        /// the job's onTaskFailure attribute is set to
        /// performExitOptionsJobAction, and a task in the job failed with an
        /// exit condition that specified a jobAction of terminateJob. Any
        /// other string is a user-defined reason specified in a call to the
        /// 'Terminate a job' operation.
        /// </remarks>
        [JsonProperty(PropertyName = "terminateReason")]
        public string TerminateReason { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SchedulingError != null)
            {
                SchedulingError.Validate();
            }
        }
    }
}
