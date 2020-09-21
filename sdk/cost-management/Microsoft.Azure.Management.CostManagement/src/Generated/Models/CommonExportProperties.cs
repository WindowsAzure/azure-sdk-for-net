// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The common properties of the export.
    /// </summary>
    public partial class CommonExportProperties
    {
        /// <summary>
        /// Initializes a new instance of the CommonExportProperties class.
        /// </summary>
        public CommonExportProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommonExportProperties class.
        /// </summary>
        /// <param name="deliveryInfo">Has delivery information for the
        /// export.</param>
        /// <param name="definition">Has the definition for the export.</param>
        /// <param name="format">The format of the export being delivered.
        /// Currently only 'Csv' is supported. Possible values include:
        /// 'Csv'</param>
        /// <param name="runHistory">If requested, has the most recent
        /// execution history for the export.</param>
        /// <param name="nextRunTimeEstimate">If the export has an active
        /// schedule, provides an estimate of the next execution time.</param>
        public CommonExportProperties(ExportDeliveryInfo deliveryInfo, ExportDefinition definition, string format = default(string), ExportExecutionListResult runHistory = default(ExportExecutionListResult), System.DateTime? nextRunTimeEstimate = default(System.DateTime?))
        {
            Format = format;
            DeliveryInfo = deliveryInfo;
            Definition = definition;
            RunHistory = runHistory;
            NextRunTimeEstimate = nextRunTimeEstimate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the format of the export being delivered. Currently
        /// only 'Csv' is supported. Possible values include: 'Csv'
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets has delivery information for the export.
        /// </summary>
        [JsonProperty(PropertyName = "deliveryInfo")]
        public ExportDeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// Gets or sets has the definition for the export.
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public ExportDefinition Definition { get; set; }

        /// <summary>
        /// Gets or sets if requested, has the most recent execution history
        /// for the export.
        /// </summary>
        [JsonProperty(PropertyName = "runHistory")]
        public ExportExecutionListResult RunHistory { get; set; }

        /// <summary>
        /// Gets if the export has an active schedule, provides an estimate of
        /// the next execution time.
        /// </summary>
        [JsonProperty(PropertyName = "nextRunTimeEstimate")]
        public System.DateTime? NextRunTimeEstimate { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeliveryInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeliveryInfo");
            }
            if (Definition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Definition");
            }
            if (DeliveryInfo != null)
            {
                DeliveryInfo.Validate();
            }
            if (Definition != null)
            {
                Definition.Validate();
            }
        }
    }
}
