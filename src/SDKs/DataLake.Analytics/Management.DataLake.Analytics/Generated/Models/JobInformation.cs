// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The common Data Lake Analytics job information properties.
    /// </summary>
    public partial class JobInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobInformation class.
        /// </summary>
        public JobInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobInformation class.
        /// </summary>
        /// <param name="name">the friendly name of the job.</param>
        /// <param name="type">the job type of the current job (Hive or USql).
        /// Possible values include: 'USql', 'Hive'</param>
        /// <param name="properties">the job specific properties.</param>
        /// <param name="jobId">the job's unique identifier (a GUID).</param>
        /// <param name="submitter">the user or account that submitted the
        /// job.</param>
        /// <param name="errorMessage">the error message details for the job,
        /// if the job failed.</param>
        /// <param name="degreeOfParallelism">the degree of parallelism used
        /// for this job. This must be greater than 0, if set to less than 0 it
        /// will default to 1.</param>
        /// <param name="priority">the priority value for the current job.
        /// Lower numbers have a higher priority. By default, a job has a
        /// priority of 1000. This must be greater than 0.</param>
        /// <param name="submitTime">the time the job was submitted to the
        /// service.</param>
        /// <param name="startTime">the start time of the job.</param>
        /// <param name="endTime">the completion time of the job.</param>
        /// <param name="state">the job state. When the job is in the Ended
        /// state, refer to Result and ErrorMessage for details. Possible
        /// values include: 'Accepted', 'Compiling', 'Ended', 'New', 'Queued',
        /// 'Running', 'Scheduling', 'Starting', 'Paused',
        /// 'WaitingForCapacity'</param>
        /// <param name="result">the result of job execution or the current
        /// result of the running job. Possible values include: 'None',
        /// 'Succeeded', 'Cancelled', 'Failed'</param>
        /// <param name="logFolder">the log folder path to use in the following
        /// format:
        /// adl://&lt;accountName&gt;.azuredatalakestore.net/system/jobservice/jobs/Usql/2016/03/13/17/18/5fe51957-93bc-4de0-8ddc-c5a4753b068b/logs/.</param>
        /// <param name="logFilePatterns">the list of log file name patterns to
        /// find in the logFolder. '*' is the only matching character allowed.
        /// Example format: jobExecution*.log or *mylog*.txt</param>
        /// <param name="stateAuditRecords">the job state audit records,
        /// indicating when various operations have been performed on this
        /// job.</param>
        /// <param name="related">the recurring job relationship information
        /// properties.</param>
        public JobInformation(string name, JobType type, JobProperties properties, System.Guid? jobId = default(System.Guid?), string submitter = default(string), IList<JobErrorDetails> errorMessage = default(IList<JobErrorDetails>), int? degreeOfParallelism = default(int?), int? priority = default(int?), System.DateTimeOffset? submitTime = default(System.DateTimeOffset?), System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), JobState? state = default(JobState?), JobResult? result = default(JobResult?), string logFolder = default(string), IList<string> logFilePatterns = default(IList<string>), IList<JobStateAuditRecord> stateAuditRecords = default(IList<JobStateAuditRecord>), JobRelationshipProperties related = default(JobRelationshipProperties))
        {
            JobId = jobId;
            Name = name;
            Type = type;
            Submitter = submitter;
            ErrorMessage = errorMessage;
            DegreeOfParallelism = degreeOfParallelism;
            Priority = priority;
            SubmitTime = submitTime;
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            Result = result;
            LogFolder = logFolder;
            LogFilePatterns = logFilePatterns;
            StateAuditRecords = stateAuditRecords;
            Properties = properties;
            Related = related;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the job's unique identifier (a GUID).
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public System.Guid? JobId { get; private set; }

        /// <summary>
        /// Gets or sets the friendly name of the job.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the job type of the current job (Hive or USql).
        /// Possible values include: 'USql', 'Hive'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public JobType Type { get; set; }

        /// <summary>
        /// Gets the user or account that submitted the job.
        /// </summary>
        [JsonProperty(PropertyName = "submitter")]
        public string Submitter { get; private set; }

        /// <summary>
        /// Gets the error message details for the job, if the job failed.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public IList<JobErrorDetails> ErrorMessage { get; private set; }

        /// <summary>
        /// Gets or sets the degree of parallelism used for this job. This must
        /// be greater than 0, if set to less than 0 it will default to 1.
        /// </summary>
        [JsonProperty(PropertyName = "degreeOfParallelism")]
        public int? DegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the priority value for the current job. Lower numbers
        /// have a higher priority. By default, a job has a priority of 1000.
        /// This must be greater than 0.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets the time the job was submitted to the service.
        /// </summary>
        [JsonProperty(PropertyName = "submitTime")]
        public System.DateTimeOffset? SubmitTime { get; private set; }

        /// <summary>
        /// Gets the start time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTimeOffset? StartTime { get; private set; }

        /// <summary>
        /// Gets the completion time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTimeOffset? EndTime { get; private set; }

        /// <summary>
        /// Gets the job state. When the job is in the Ended state, refer to
        /// Result and ErrorMessage for details. Possible values include:
        /// 'Accepted', 'Compiling', 'Ended', 'New', 'Queued', 'Running',
        /// 'Scheduling', 'Starting', 'Paused', 'WaitingForCapacity'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState? State { get; private set; }

        /// <summary>
        /// Gets the result of job execution or the current result of the
        /// running job. Possible values include: 'None', 'Succeeded',
        /// 'Cancelled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public JobResult? Result { get; private set; }

        /// <summary>
        /// Gets the log folder path to use in the following format:
        /// adl://&amp;lt;accountName&amp;gt;.azuredatalakestore.net/system/jobservice/jobs/Usql/2016/03/13/17/18/5fe51957-93bc-4de0-8ddc-c5a4753b068b/logs/.
        /// </summary>
        [JsonProperty(PropertyName = "logFolder")]
        public string LogFolder { get; private set; }

        /// <summary>
        /// Gets or sets the list of log file name patterns to find in the
        /// logFolder. '*' is the only matching character allowed. Example
        /// format: jobExecution*.log or *mylog*.txt
        /// </summary>
        [JsonProperty(PropertyName = "logFilePatterns")]
        public IList<string> LogFilePatterns { get; set; }

        /// <summary>
        /// Gets the job state audit records, indicating when various
        /// operations have been performed on this job.
        /// </summary>
        [JsonProperty(PropertyName = "stateAuditRecords")]
        public IList<JobStateAuditRecord> StateAuditRecords { get; private set; }

        /// <summary>
        /// Gets or sets the job specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public JobProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the recurring job relationship information properties.
        /// </summary>
        [JsonProperty(PropertyName = "related")]
        public JobRelationshipProperties Related { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
            if (Related != null)
            {
                Related.Validate();
            }
        }
    }
}
