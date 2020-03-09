// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> An error response from the storage resource provider. </summary>
    public partial class ErrorResponse
    {
        /// <summary> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; set; }
        /// <summary> A message describing the error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; set; }
    }
}
