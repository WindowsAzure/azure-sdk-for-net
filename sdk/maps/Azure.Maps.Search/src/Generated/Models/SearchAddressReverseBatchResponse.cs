// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful Search Address Reverse Batch service call. </summary>
    public partial class SearchAddressReverseBatchResponse : BatchResponse
    {
        /// <summary> Initializes a new instance of SearchAddressReverseBatchResponse. </summary>
        internal SearchAddressReverseBatchResponse()
        {
            BatchItems = new ChangeTrackingList<SearchAddressReverseBatchItem>();
        }

        /// <summary> Initializes a new instance of SearchAddressReverseBatchResponse. </summary>
        /// <param name="summary"> Summary for the batch request. </param>
        /// <param name="batchItems"> Array containing the batch results. </param>
        internal SearchAddressReverseBatchResponse(BatchResponseSummary summary, IReadOnlyList<SearchAddressReverseBatchItem> batchItems) : base(summary)
        {
            BatchItems = batchItems;
        }

        /// <summary> Array containing the batch results. </summary>
        public IReadOnlyList<SearchAddressReverseBatchItem> BatchItems { get; }
    }
}
