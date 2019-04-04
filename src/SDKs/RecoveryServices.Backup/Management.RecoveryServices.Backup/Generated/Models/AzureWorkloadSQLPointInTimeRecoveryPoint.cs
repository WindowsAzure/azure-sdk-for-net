// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recovery point specific to PointInTime
    /// </summary>
    public partial class AzureWorkloadSQLPointInTimeRecoveryPoint : AzureWorkloadSQLRecoveryPoint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSQLPointInTimeRecoveryPoint class.
        /// </summary>
        public AzureWorkloadSQLPointInTimeRecoveryPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSQLPointInTimeRecoveryPoint class.
        /// </summary>
        /// <param name="recoveryPointTimeInUTC">UTC time at which recovery
        /// point was created</param>
        /// <param name="type">Type of restore point. Possible values include:
        /// 'Invalid', 'Full', 'Log', 'Differential'</param>
        /// <param name="extendedInfo">Extended Info that provides data
        /// directory details. Will be populated in two cases:
        /// When a specific recovery point is accessed using GetRecoveryPoint
        /// Or when ListRecoveryPoints is called for Log RP only with
        /// ExtendedInfo query filter</param>
        /// <param name="timeRanges">List of log ranges</param>
        public AzureWorkloadSQLPointInTimeRecoveryPoint(System.DateTime? recoveryPointTimeInUTC = default(System.DateTime?), string type = default(string), AzureWorkloadSQLRecoveryPointExtendedInfo extendedInfo = default(AzureWorkloadSQLRecoveryPointExtendedInfo), IList<PointInTimeRange> timeRanges = default(IList<PointInTimeRange>))
            : base(recoveryPointTimeInUTC, type, extendedInfo)
        {
            TimeRanges = timeRanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of log ranges
        /// </summary>
        [JsonProperty(PropertyName = "timeRanges")]
        public IList<PointInTimeRange> TimeRanges { get; set; }

    }
}
