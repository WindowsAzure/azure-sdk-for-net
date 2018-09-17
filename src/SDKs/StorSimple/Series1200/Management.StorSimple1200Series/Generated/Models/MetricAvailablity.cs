// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric availability specifies the time grain (aggregation interval or
    /// frequency) and the retention period for that time grain
    /// </summary>
    public partial class MetricAvailablity
    {
        /// <summary>
        /// Initializes a new instance of the MetricAvailablity class.
        /// </summary>
        public MetricAvailablity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAvailablity class.
        /// </summary>
        /// <param name="timeGrain">The time grain, specifies the aggregation
        /// interval for the metric.</param>
        /// <param name="retention">The retention period for the metric at the
        /// specified timegrain</param>
        public MetricAvailablity(string timeGrain, string retention)
        {
            TimeGrain = timeGrain;
            Retention = retention;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time grain, specifies the aggregation interval for
        /// the metric.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets the retention period for the metric at the specified
        /// timegrain
        /// </summary>
        [JsonProperty(PropertyName = "retention")]
        public string Retention { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeGrain == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeGrain");
            }
            if (Retention == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Retention");
            }
        }
    }
}
