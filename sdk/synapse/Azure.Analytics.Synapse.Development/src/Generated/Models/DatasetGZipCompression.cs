// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> The GZip compression method used on a dataset. </summary>
    public partial class DatasetGZipCompression : DatasetCompression
    {
        /// <summary> Initializes a new instance of DatasetGZipCompression. </summary>
        public DatasetGZipCompression()
        {
            Type = "GZip";
        }

        /// <summary> Initializes a new instance of DatasetGZipCompression. </summary>
        /// <param name="type"> Type of dataset compression. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="level"> The GZip compression level. </param>
        internal DatasetGZipCompression(string type, IDictionary<string, object> additionalProperties, DatasetCompressionLevel? level) : base(type, additionalProperties)
        {
            Level = level;
            Type = type ?? "GZip";
        }

        /// <summary> The GZip compression level. </summary>
        public DatasetCompressionLevel? Level { get; set; }
    }
}
