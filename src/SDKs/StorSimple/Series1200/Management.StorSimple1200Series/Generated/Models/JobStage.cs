// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains details about the multiple job stages of a job
    /// </summary>
    public partial class JobStage
    {
        /// <summary>
        /// Initializes a new instance of the JobStage class.
        /// </summary>
        public JobStage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStage class.
        /// </summary>
        /// <param name="stageStatus">The stage status. Possible values
        /// include: 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Paused', 'Scheduled'</param>
        /// <param name="message">The message of the job stage.</param>
        /// <param name="detail">The details of the stage.</param>
        /// <param name="errorCode">The error code of the stage if any.</param>
        public JobStage(JobStatus stageStatus, string message = default(string), string detail = default(string), string errorCode = default(string))
        {
            Message = message;
            StageStatus = stageStatus;
            Detail = detail;
            ErrorCode = errorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the message of the job stage.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the stage status. Possible values include: 'Invalid',
        /// 'Running', 'Succeeded', 'Failed', 'Canceled', 'Paused', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "stageStatus")]
        public JobStatus StageStatus { get; set; }

        /// <summary>
        /// Gets or sets the details of the stage.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets the error code of the stage if any.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
