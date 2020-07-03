// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.Data.Tables.Tests
{
    public class TablesTestEnvironment : TestEnvironment
    {
        public TablesTestEnvironment() : base("tables")
        {
        }

        public const string PrimaryKeyEnvironmentVariableName = "TABLES_PRIMARY_STORAGE_ACCOUNT_KEY";
        private const string StorageUriFormat = "https://{0}.table.core.windows.net";

        public string PrimaryStorageAccountKey => GetRecordedVariable(PrimaryKeyEnvironmentVariableName);
        public string AccountName => GetRecordedVariable("TABLES_STORAGE_ACCOUNT_NAME");
        public string TablesEndpointSuffix = Environment.GetEnvironmentVariable("TABLES_STORAGE_ENDPOINT_SUFFIX");
        public string StorageUri => !string.IsNullOrEmpty(TablesEndpointSuffix) ? $"https://{AccountName}.{TablesEndpointSuffix}" : string.Format(StorageUriFormat, AccountName);
    }
}
