﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;

namespace Azure.Storage.Files
{
    // TODO can we make the info link not blob-centric?

    /// <summary>
    /// Standard HTTP properties supported by the files.
    /// These properties are represented as standard HTTP headers use standard
    /// names, as specified in the Header Field Definitions section 14 of the
    /// HTTP/1.1 protocol specification.
    /// 
    /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-and-retrieving-properties-and-metadata-for-blob-resources" />.
    /// </summary>
    public struct FileHttpHeaders : IEquatable<FileHttpHeaders>
    {
        /// <summary>
        /// The MIME content type of the file.
        /// </summary>
        public string ContentType { get; set; }

#pragma warning disable CA1819 // Properties should not return arrays
        /// <summary>
        /// An MD5 hash of the file content. This hash is used to verify the
        /// integrity of the file content during transport.  When this header is
        /// specified, the storage service checks the hash that has arrived 
        /// with the one that was sent. If the two hashes do not match, the 
        /// operation will fail with error code 400 (Bad Request).
        /// </summary>
        public byte[] ContentHash { get; set; }

        /// <summary>
        /// Specifies which content encodings have been applied to the file.
        /// This value is returned to the client when the Get File operation
        /// is performed on the file resource. The client can use this value 
        /// when returned to decode the file content.
        /// </summary>
        public string[] ContentEncoding { get; set; }

        /// <summary>
        /// Specifies the natural languages used by this resource.
        /// </summary>
        public string[] ContentLanguage { get; set; }
#pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// Conveys additional information about how to process the response
        /// payload, and also can be used to attach additional metadata.  For
        /// example, if set to attachment, it indicates that the user-agent
        /// should not display the response, but instead show a Save As dialog
        /// with a filename other than the file name specified.
        /// </summary>
        public string ContentDisposition { get; set; }

        /// <summary>
        /// Specify directives for caching mechanisms.
        /// </summary>
        public string CacheControl { get; set; }

        /// <summary>
        /// Check if two FileHttpHeaders instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public override bool Equals(object obj)
            => obj is FileHttpHeaders other && this.Equals(other);

        /// <summary>
        /// Get a hash code for the FileHttpHeaders.
        /// </summary>
        /// <returns>Hash code for the FileHttpHeaders.</returns>
        public override int GetHashCode()
            => this.ContentType.GetHashCode()
            ^ this.ContentHash.GetHashCode()
            ^ this.ContentEncoding.GetHashCode()
            ^ this.ContentLanguage.GetHashCode()
            ^ this.ContentDisposition.GetHashCode()
            ^ this.CacheControl.GetHashCode()
            ;

        /// <summary>
        /// Check if two FileHttpHeaders instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public static bool operator ==(FileHttpHeaders left, FileHttpHeaders right) => left.Equals(right);

        /// <summary>
        /// Check if two FileHttpHeaders instances are not equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're not equal, false otherwise.</returns>
        public static bool operator !=(FileHttpHeaders left, FileHttpHeaders right) => !(left == right);

        /// <summary>
        /// Check if two FileHttpHeaders instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        public bool Equals(FileHttpHeaders other)
            => this.CacheControl == other.CacheControl
            && this.ContentDisposition == other.ContentDisposition
            && this.ContentEncoding == other.ContentEncoding
            && this.ContentLanguage == other.ContentLanguage
            && this.ContentHash == other.ContentHash
            && this.ContentType == other.ContentType
            ;
    }
}
