// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Selective Key Restore operation. </summary>
    public partial class SelectiveKeyRestoreDetails
    {
        /// <summary> Initializes a new instance of SelectiveKeyRestoreDetails. </summary>
        internal SelectiveKeyRestoreDetails()
        {
        }

        /// <summary> Initializes a new instance of SelectiveKeyRestoreDetails. </summary>
        /// <param name="status"> Status of the restore operation. </param>
        /// <param name="statusDetails"> The status details of restore operation. </param>
        /// <param name="error"> Error encountered, if any, during the selective key restore operation. </param>
        /// <param name="jobId"> Identifier for the selective key restore operation. </param>
        /// <param name="startTime"> The start time of the restore operation. </param>
        /// <param name="endTime"> The end time of the restore operation in UTC. </param>
        internal SelectiveKeyRestoreDetails(string status, string statusDetails, KeyVaultServiceError error, string jobId, DateTimeOffset? startTime, DateTimeOffset? endTime)
        {
            Status = status;
            StatusDetails = statusDetails;
            Error = error;
            JobId = jobId;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> Status of the restore operation. </summary>
        public string Status { get; }
        /// <summary> The status details of restore operation. </summary>
        public string StatusDetails { get; }
        /// <summary> Error encountered, if any, during the selective key restore operation. </summary>
        public KeyVaultServiceError Error { get; }
        /// <summary> Identifier for the selective key restore operation. </summary>
        public string JobId { get; }
        /// <summary> The start time of the restore operation. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of the restore operation in UTC. </summary>
        public DateTimeOffset? EndTime { get; }
    }
}
