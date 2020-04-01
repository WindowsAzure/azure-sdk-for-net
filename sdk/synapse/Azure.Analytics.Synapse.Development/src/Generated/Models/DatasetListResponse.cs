// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> A list of dataset resources. </summary>
    public partial class DatasetListResponse
    {
        /// <summary> Initializes a new instance of DatasetListResponse. </summary>
        /// <param name="value"> List of datasets. </param>
        internal DatasetListResponse(IEnumerable<DatasetResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of DatasetListResponse. </summary>
        /// <param name="value"> List of datasets. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal DatasetListResponse(IReadOnlyList<DatasetResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of datasets. </summary>
        public IReadOnlyList<DatasetResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
