// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object. </summary>
    public partial class Endpoints
    {
        /// <summary> Gets the blob endpoint. </summary>
        public string Blob { get; internal set; }
        /// <summary> Gets the queue endpoint. </summary>
        public string Queue { get; internal set; }
        /// <summary> Gets the table endpoint. </summary>
        public string Table { get; internal set; }
        /// <summary> Gets the file endpoint. </summary>
        public string File { get; internal set; }
        /// <summary> Gets the web endpoint. </summary>
        public string Web { get; internal set; }
        /// <summary> Gets the dfs endpoint. </summary>
        public string Dfs { get; internal set; }
        /// <summary> Gets the microsoft routing storage endpoints. </summary>
        public StorageAccountMicrosoftEndpoints MicrosoftEndpoints { get; set; }
        /// <summary> Gets the internet routing storage endpoints. </summary>
        public StorageAccountInternetEndpoints InternetEndpoints { get; set; }
    }
}
