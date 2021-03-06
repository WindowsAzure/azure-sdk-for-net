// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor
{
    internal static partial class FeedbackQueryTimeModeExtensions
    {

        public static FeedbackQueryTimeMode ToFeedbackQueryTimeMode(this string value)
        {
            if (string.Equals(value, "MetricTimestamp", StringComparison.InvariantCultureIgnoreCase)) return FeedbackQueryTimeMode.MetricTimestamp;
            if (string.Equals(value, "FeedbackCreatedTime", StringComparison.InvariantCultureIgnoreCase)) return FeedbackQueryTimeMode.FeedbackCreatedOn;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FeedbackQueryTimeMode value.");
        }
    }
}
