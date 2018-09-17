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
    /// The metric data.
    /// </summary>
    public partial class MetricData
    {
        /// <summary>
        /// Initializes a new instance of the MetricData class.
        /// </summary>
        public MetricData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricData class.
        /// </summary>
        /// <param name="timeStamp">The time when the metric data is
        /// fetched</param>
        /// <param name="sum">The sum of all the samples available in the given
        /// instance of time for the specific metric data</param>
        /// <param name="count">The count of samples of the metric data
        /// available for the given instance</param>
        /// <param name="average">The average of all sample for the given
        /// instance</param>
        /// <param name="minimum">The minimum of all samples available</param>
        /// <param name="maximum">The maximum of all samples available</param>
        public MetricData(System.DateTime timeStamp, double sum, int count, double average, double minimum, double maximum)
        {
            TimeStamp = timeStamp;
            Sum = sum;
            Count = count;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time when the metric data is fetched
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the sum of all the samples available in the given
        /// instance of time for the specific metric data
        /// </summary>
        [JsonProperty(PropertyName = "sum")]
        public double Sum { get; set; }

        /// <summary>
        /// Gets or sets the count of samples of the metric data available for
        /// the given instance
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the average of all sample for the given instance
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        public double Average { get; set; }

        /// <summary>
        /// Gets or sets the minimum of all samples available
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum of all samples available
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double Maximum { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
