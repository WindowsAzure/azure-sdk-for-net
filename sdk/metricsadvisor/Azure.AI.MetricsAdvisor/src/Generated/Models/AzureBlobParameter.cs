// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureBlobParameter. </summary>
    internal partial class AzureBlobParameter
    {
        /// <summary> Initializes a new instance of AzureBlobParameter. </summary>
        /// <param name="connectionString"> Azure Blob connection string. </param>
        /// <param name="container"> Container. </param>
        /// <param name="blobTemplate"> Blob Template. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/>, <paramref name="container"/>, or <paramref name="blobTemplate"/> is null. </exception>
        public AzureBlobParameter(string connectionString, string container, string blobTemplate)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }
            if (blobTemplate == null)
            {
                throw new ArgumentNullException(nameof(blobTemplate));
            }

            ConnectionString = connectionString;
            Container = container;
            BlobTemplate = blobTemplate;
        }

        /// <summary> Azure Blob connection string. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Container. </summary>
        public string Container { get; set; }
        /// <summary> Blob Template. </summary>
        public string BlobTemplate { get; set; }
    }
}
