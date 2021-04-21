﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Storage.Test;
using Azure.Storage.Test.Shared;

namespace Azure.Storage.Blobs.Tests
{
    public class BlobTestEnvironment : StorageTestEnvironment
    {
        public override Task<bool> IsEnvironmentReady()
        {
            return DoesOAuthWork();
        }

        private async Task<bool> DoesOAuthWork()
        {
            if (Mode != RecordedTestMode.Live)
            {
                return true;
            }

            BlobServiceClient blobServiceClient = new BlobServiceClient(new Uri(TestConfigurations.DefaultTargetOAuthTenant.BlobServiceEndpoint), OAuthCredential);
            try
            {
                await blobServiceClient.GetPropertiesAsync();
            } catch (RequestFailedException e) when (e.Status == 403 && e.ErrorCode == "AuthorizationPermissionMismatch")
            {
                return false;
            }
            return true;
        }
    }
}
