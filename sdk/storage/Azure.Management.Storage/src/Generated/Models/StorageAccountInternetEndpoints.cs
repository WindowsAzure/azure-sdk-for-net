// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint. </summary>
    public partial class StorageAccountInternetEndpoints
    {
        /// <summary> Gets the blob endpoint. </summary>
        public string Blob { get; internal set; }
        /// <summary> Gets the file endpoint. </summary>
        public string File { get; internal set; }
        /// <summary> Gets the web endpoint. </summary>
        public string Web { get; internal set; }
        /// <summary> Gets the dfs endpoint. </summary>
        public string Dfs { get; internal set; }
    }
}
