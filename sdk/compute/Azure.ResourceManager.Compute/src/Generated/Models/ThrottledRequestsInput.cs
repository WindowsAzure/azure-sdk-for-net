// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Api request input for LogAnalytics getThrottledRequests Api. </summary>
    public partial class ThrottledRequestsInput : LogAnalyticsInputBase
    {
        /// <summary> Initializes a new instance of ThrottledRequestsInput. </summary>
        /// <param name="blobContainerSasUri"> SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to. </param>
        /// <param name="fromTime"> From time of the query. </param>
        /// <param name="toTime"> To time of the query. </param>
        public ThrottledRequestsInput(string blobContainerSasUri, DateTimeOffset fromTime, DateTimeOffset toTime) : base(blobContainerSasUri, fromTime, toTime)
        {
            if (blobContainerSasUri == null)
            {
                throw new ArgumentNullException(nameof(blobContainerSasUri));
            }
        }
    }
}
