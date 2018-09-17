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
    /// Monitoring metric definition represents the metadata of the metrics.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        /// <param name="name">The metric name</param>
        /// <param name="unit">The metric unit. Possible values include:
        /// 'Bytes', 'BytesPerSecond', 'Count', 'CountPerSecond', 'Percent',
        /// 'Seconds'</param>
        /// <param name="primaryAggregationType">The metric aggregation type.
        /// Possible values include: 'Average', 'Last', 'Maximum', 'Minimum',
        /// 'None', 'Total'</param>
        /// <param name="resourceId">The metric source id</param>
        /// <param name="metricAvailabilities">The available metric
        /// granularities</param>
        /// <param name="dimensions">The supported dimensions</param>
        /// <param name="type">The metric definition type</param>
        public MetricDefinition(MetricName name, MetricUnit unit, MetricAggregationType primaryAggregationType, string resourceId, IList<MetricAvailablity> metricAvailabilities, IList<MetricDimension> dimensions, string type)
        {
            Name = name;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            ResourceId = resourceId;
            MetricAvailabilities = metricAvailabilities;
            Dimensions = dimensions;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metric name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; set; }

        /// <summary>
        /// Gets or sets the metric unit. Possible values include: 'Bytes',
        /// 'BytesPerSecond', 'Count', 'CountPerSecond', 'Percent', 'Seconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public MetricUnit Unit { get; set; }

        /// <summary>
        /// Gets or sets the metric aggregation type. Possible values include:
        /// 'Average', 'Last', 'Maximum', 'Minimum', 'None', 'Total'
        /// </summary>
        [JsonProperty(PropertyName = "primaryAggregationType")]
        public MetricAggregationType PrimaryAggregationType { get; set; }

        /// <summary>
        /// Gets or sets the metric source id
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the available metric granularities
        /// </summary>
        [JsonProperty(PropertyName = "metricAvailabilities")]
        public IList<MetricAvailablity> MetricAvailabilities { get; set; }

        /// <summary>
        /// Gets or sets the supported dimensions
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricDimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets the metric definition type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

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
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (MetricAvailabilities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricAvailabilities");
            }
            if (Dimensions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dimensions");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Name != null)
            {
                Name.Validate();
            }
            if (MetricAvailabilities != null)
            {
                foreach (var element in MetricAvailabilities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Dimensions != null)
            {
                foreach (var element1 in Dimensions)
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
