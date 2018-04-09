// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Azure Blob source.
    /// </summary>
    public partial class BlobSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the BlobSource class.
        /// </summary>
        public BlobSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="treatEmptyAsNull">Treat empty as null. Type: boolean
        /// (or Expression with resultType boolean).</param>
        /// <param name="skipHeaderLineCount">Number of header lines to skip
        /// from each blob. Type: integer (or Expression with resultType
        /// integer).</param>
        /// <param name="recursive">If true, files under the folder path will
        /// be read recursively. Default is true. Type: boolean (or Expression
        /// with resultType boolean).</param>
        public BlobSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object treatEmptyAsNull = default(object), object skipHeaderLineCount = default(object), object recursive = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait)
        {
            TreatEmptyAsNull = treatEmptyAsNull;
            SkipHeaderLineCount = skipHeaderLineCount;
            Recursive = recursive;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets treat empty as null. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "treatEmptyAsNull")]
        public object TreatEmptyAsNull { get; set; }

        /// <summary>
        /// Gets or sets number of header lines to skip from each blob. Type:
        /// integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "skipHeaderLineCount")]
        public object SkipHeaderLineCount { get; set; }

        /// <summary>
        /// Gets or sets if true, files under the folder path will be read
        /// recursively. Default is true. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "recursive")]
        public object Recursive { get; set; }

    }
}
