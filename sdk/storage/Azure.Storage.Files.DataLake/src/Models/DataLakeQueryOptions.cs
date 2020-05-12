﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary>
    /// Optional parameters for <see cref="DataLakeFileClient.QueryAsync(string, DataLakeQueryOptions, System.Threading.CancellationToken)"/>.
    /// </summary>
    public class DataLakeQueryOptions
    {
        /// <summary>
        /// Optional input text configuration.
        /// </summary>
        public DataLakeQueryTextConfiguration InputTextConfiguration { get; set; }

        /// <summary>
        /// Optional output text configuration.
        /// </summary>
        public DataLakeQueryTextConfiguration OutputTextConfiguration { get; set; }

        /// <summary>
        /// Optional error handler.
        /// </summary>
        public Action<DataLakeQueryError> ErrorHandler { get; set; }

        /// <summary>
        /// Optional <see cref="DataLakeRequestConditions"/> to add conditions on the query.
        /// </summary>
        public DataLakeRequestConditions Conditions { get; set; }

        /// <summary>
        /// Optional progress handler.
        /// </summary>
        public IProgress<long> ProgressHandler { get; set; }
    }
}
