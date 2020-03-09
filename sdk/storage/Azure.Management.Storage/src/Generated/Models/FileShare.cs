// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> Properties of the file share, including Id, resource name, resource type, Etag. </summary>
    public partial class FileShare : AzureEntityResource
    {
        /// <summary> Returns the date and time the share was last modified. </summary>
        public DateTimeOffset? LastModifiedTime { get; internal set; }
        /// <summary> A name-value pair to associate with the share as metadata. </summary>
        public IDictionary<string, string> Metadata { get; set; }
        /// <summary> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </summary>
        public int? ShareQuota { get; set; }
    }
}
