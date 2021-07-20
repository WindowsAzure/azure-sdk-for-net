// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> The result of the query. SearchAddressReverseResponse if the query completed successfully, ErrorResponse otherwise. </summary>
    public partial class SearchAddressReverseBatchItemResponse : SearchAddressReverseResponse
    {
        /// <summary> Initializes a new instance of SearchAddressReverseBatchItemResponse. </summary>
        internal SearchAddressReverseBatchItemResponse()
        {
        }

        /// <summary> Initializes a new instance of SearchAddressReverseBatchItemResponse. </summary>
        /// <param name="summary"> Summary object for a Search Address Reverse response. </param>
        /// <param name="addresses"> Addresses array. </param>
        /// <param name="error"> The error object. </param>
        internal SearchAddressReverseBatchItemResponse(SearchCommonSummary summary, IReadOnlyList<SearchAddressReverseResult> addresses, ErrorDetail error) : base(summary, addresses)
        {
            Error = error;
        }

        /// <summary> The error object. </summary>
        public ErrorDetail Error { get; }
    }
}
