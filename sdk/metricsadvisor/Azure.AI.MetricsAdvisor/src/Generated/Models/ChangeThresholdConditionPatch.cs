// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ChangeThresholdConditionPatch. </summary>
    internal partial class ChangeThresholdConditionPatch
    {
        /// <summary> Initializes a new instance of ChangeThresholdConditionPatch. </summary>
        public ChangeThresholdConditionPatch()
        {
        }

        /// <summary> change percentage, value range : [0, +∞). </summary>
        public double? ChangePercentage { get; set; }
        /// <summary> shift point, value range : [1, +∞). </summary>
        public int? ShiftPoint { get; set; }
        /// <summary>
        /// if the withinRange = true, detected data is abnormal when the value falls in the range, in this case anomalyDetectorDirection must be Both
        /// if the withinRange = false, detected data is abnormal when the value falls out of the range
        /// </summary>
        public bool? WithinRange { get; set; }
        /// <summary> detection direction. </summary>
        public AnomalyDetectorDirection? AnomalyDetectorDirection { get; set; }
        public SuppressConditionPatch SuppressCondition { get; set; }
    }
}
