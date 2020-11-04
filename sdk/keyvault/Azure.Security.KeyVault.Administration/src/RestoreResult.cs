// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary>
    /// The result of a restore operation.
    /// </summary>
    public class RestoreResult
    {
        internal RestoreResult(DateTimeOffset startTime, DateTimeOffset endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// The start time of the restore operation.
        /// </summary>
        public DateTimeOffset StartTime { get; }

        /// <summary>
        /// The end time of the restore operation.
        /// </summary>
        public DateTimeOffset EndTime { get; }
    }
}
