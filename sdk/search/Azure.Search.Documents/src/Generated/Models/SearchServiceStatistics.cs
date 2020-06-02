// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Response from a get service statistics request. If successful, it includes service level counters and limits. </summary>
    public partial class SearchServiceStatistics
    {
        /// <summary> Initializes a new instance of SearchServiceStatistics. </summary>
        /// <param name="counters"> Service level resource counters. </param>
        /// <param name="limits"> Service level general limits. </param>
        internal SearchServiceStatistics(SearchServiceCounters counters, SearchServiceLimits limits)
        {
            if (counters == null)
            {
                throw new ArgumentNullException(nameof(counters));
            }
            if (limits == null)
            {
                throw new ArgumentNullException(nameof(limits));
            }

            Counters = counters;
            Limits = limits;
        }

        /// <summary> Service level resource counters. </summary>
        public SearchServiceCounters Counters { get; }
        /// <summary> Service level general limits. </summary>
        public SearchServiceLimits Limits { get; }
    }
}
