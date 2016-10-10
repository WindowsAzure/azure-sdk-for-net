// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// A rule that provide the triggers and parameters for the scaling action.
    /// </summary>
    public partial class ScaleRule
    {
        /// <summary>
        /// Initializes a new instance of the ScaleRule class.
        /// </summary>
        public ScaleRule()
        {
            ScaleAction = new ScaleAction();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleRule class.
        /// </summary>
        /// <param name="scaleAction">the parameters for the scaling
        /// action.</param>
        /// <param name="metricTrigger">the trigger that results in a scaling
        /// action.</param>
        public ScaleRule(ScaleAction scaleAction, MetricTrigger metricTrigger = default(MetricTrigger))
        {
            ScaleAction = new ScaleAction();
            MetricTrigger = metricTrigger;
            ScaleAction = scaleAction;
        }

        /// <summary>
        /// Gets or sets the trigger that results in a scaling action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metricTrigger")]
        public MetricTrigger MetricTrigger { get; set; }

        /// <summary>
        /// Gets or sets the parameters for the scaling action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scaleAction")]
        public ScaleAction ScaleAction { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScaleAction == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ScaleAction");
            }
            if (this.ScaleAction != null)
            {
                this.ScaleAction.Validate();
            }
        }
    }
}
