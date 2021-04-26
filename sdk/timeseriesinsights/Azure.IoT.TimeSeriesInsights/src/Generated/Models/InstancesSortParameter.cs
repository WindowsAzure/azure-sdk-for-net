// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.IoT.TimeSeriesInsights.Models;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Definition of how time series instances are sorted before being returned by search instances call. </summary>
    internal partial class InstancesSortParameter
    {
        /// <summary> Initializes a new instance of InstancesSortParameter. </summary>
        public InstancesSortParameter()
        {
        }

        /// <summary> Value to use for sorting of the time series instances before being returned by search instances call. When it is set to &apos;Rank&apos;, the returned instances are sorted based on the relevance. When it is set to &apos;DisplayName&apos;, the returned results are sorted based on the display name. Display name is the name of the instance if it exists, otherwise, display name is the time series ID. Default is &apos;Rank&apos;. </summary>
        public InstancesSortBy? By { get; set; }
    }
}
