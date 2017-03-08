// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Monthly retention schedule.
    /// </summary>
    public partial class MonthlyRetentionSchedule
    {
        /// <summary>
        /// Initializes a new instance of the MonthlyRetentionSchedule class.
        /// </summary>
        public MonthlyRetentionSchedule() { }

        /// <summary>
        /// Initializes a new instance of the MonthlyRetentionSchedule class.
        /// </summary>
        /// <param name="retentionScheduleFormatType">Retention schedule
        /// format type for monthly retention policy. Possible values
        /// include: 'Invalid', 'Daily', 'Weekly'</param>
        /// <param name="retentionScheduleDaily">Daily retention format for
        /// monthly retention policy.</param>
        /// <param name="retentionScheduleWeekly">Weekly retention format for
        /// monthly retention policy.</param>
        /// <param name="retentionTimes">Retention times of retention
        /// policy.</param>
        /// <param name="retentionDuration">Retention duration of retention
        /// Policy.</param>
        public MonthlyRetentionSchedule(RetentionScheduleFormat? retentionScheduleFormatType = default(RetentionScheduleFormat?), DailyRetentionFormat retentionScheduleDaily = default(DailyRetentionFormat), WeeklyRetentionFormat retentionScheduleWeekly = default(WeeklyRetentionFormat), System.Collections.Generic.IList<System.DateTime?> retentionTimes = default(System.Collections.Generic.IList<System.DateTime?>), RetentionDuration retentionDuration = default(RetentionDuration))
        {
            RetentionScheduleFormatType = retentionScheduleFormatType;
            RetentionScheduleDaily = retentionScheduleDaily;
            RetentionScheduleWeekly = retentionScheduleWeekly;
            RetentionTimes = retentionTimes;
            RetentionDuration = retentionDuration;
        }

        /// <summary>
        /// Gets or sets retention schedule format type for monthly retention
        /// policy. Possible values include: 'Invalid', 'Daily', 'Weekly'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionScheduleFormatType")]
        public RetentionScheduleFormat? RetentionScheduleFormatType { get; set; }

        /// <summary>
        /// Gets or sets daily retention format for monthly retention policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionScheduleDaily")]
        public DailyRetentionFormat RetentionScheduleDaily { get; set; }

        /// <summary>
        /// Gets or sets weekly retention format for monthly retention policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionScheduleWeekly")]
        public WeeklyRetentionFormat RetentionScheduleWeekly { get; set; }

        /// <summary>
        /// Gets or sets retention times of retention policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionTimes")]
        public System.Collections.Generic.IList<System.DateTime?> RetentionTimes { get; set; }

        /// <summary>
        /// Gets or sets retention duration of retention Policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionDuration")]
        public RetentionDuration RetentionDuration { get; set; }

    }
}
