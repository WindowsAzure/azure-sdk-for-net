// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Monitoring metric
    /// </summary>
    public partial class Metrics
    {
        /// <summary>
        /// Initializes a new instance of the Metrics class.
        /// </summary>
        public Metrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Metrics class.
        /// </summary>
        /// <param name="resourceId">The id of metric source</param>
        /// <param name="startTime">The metric start time</param>
        /// <param name="endTime">The metric end time</param>
        /// <param name="timeGrain">The time grain, time grain indicates
        /// frequency of the metric data</param>
        /// <param name="primaryAggregation">The metric aggregation type.
        /// Possible values include: 'Average', 'Last', 'Maximum', 'Minimum',
        /// 'None', 'Total'</param>
        /// <param name="name">The name of the metrics</param>
        /// <param name="dimensions">The Metric dimension which indicates the
        /// source of the metric</param>
        /// <param name="unit">The unit of the metric data. Possible values
        /// include: 'Bytes', 'BytesPerSecond', 'Count', 'CountPerSecond',
        /// 'Percent', 'Seconds'</param>
        /// <param name="type">The Type of the metric data</param>
        /// <param name="values">The metric data</param>
        public Metrics(string resourceId, System.DateTime startTime, System.DateTime endTime, string timeGrain, MetricAggregationType primaryAggregation, MetricName name, IList<MetricDimension> dimensions, MetricUnit unit, string type, IList<MetricData> values)
        {
            ResourceId = resourceId;
            StartTime = startTime;
            EndTime = endTime;
            TimeGrain = timeGrain;
            PrimaryAggregation = primaryAggregation;
            Name = name;
            Dimensions = dimensions;
            Unit = unit;
            Type = type;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of metric source
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the metric start time
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the metric end time
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the time grain, time grain indicates frequency of the
        /// metric data
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets the metric aggregation type. Possible values include:
        /// 'Average', 'Last', 'Maximum', 'Minimum', 'None', 'Total'
        /// </summary>
        [JsonProperty(PropertyName = "primaryAggregation")]
        public MetricAggregationType PrimaryAggregation { get; set; }

        /// <summary>
        /// Gets or sets the name of the metrics
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; set; }

        /// <summary>
        /// Gets or sets the Metric dimension which indicates the source of the
        /// metric
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricDimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric data. Possible values include:
        /// 'Bytes', 'BytesPerSecond', 'Count', 'CountPerSecond', 'Percent',
        /// 'Seconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public MetricUnit Unit { get; set; }

        /// <summary>
        /// Gets or sets the Type of the metric data
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the metric data
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<MetricData> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (TimeGrain == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeGrain");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Dimensions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dimensions");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
            if (Name != null)
            {
                Name.Validate();
            }
            if (Dimensions != null)
            {
                foreach (var element in Dimensions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Values != null)
            {
                foreach (var element1 in Values)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
