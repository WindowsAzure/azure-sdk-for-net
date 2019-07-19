﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace ContainerRegistry.Tests
{
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using global::ContainerRegistry.Tests;
    using Microsoft.Azure.Management.ContainerRegistry;
    using Microsoft.Rest;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using Microsoft.Azure.ContainerRegistry;
    using System.Threading;


    public static class ACRTestUtil
    {
        private static readonly string _testResourceGroup = "matttest";

        public static readonly string ProdRepository = "prod/bash";
        public static readonly string TestRepository = "test/bash";

        public static readonly string ManagedTestRegistry = "managedtestregistry";
        public static readonly string ManagedTestRegistryFullName = "managedtestregistry.azurecr.io";
        public static readonly string ManagedTestRegistryForDeleting = "managedtestregistryfordel";

        public static readonly string ClassicTestRegistry = "classictestregistry";
        public static readonly string ClassicTestRegistryNameFullName = "classictestregistry.azurecr.io";
        public static readonly string ClassicTestRegistryForDeleting = "classictestregistryfordel";

        public static async Task<AzureContainerRegistryClient> GetACRClientAsync(MockContext context, string registryName)
        {
            var registryManagementClient = context.GetServiceClient<ContainerRegistryManagementClient>(handlers: CreateNewRecordedDelegatingHandler());
            var registry = await registryManagementClient.Registries.GetAsync(_testResourceGroup, registryName);
            var registryCredentials = await registryManagementClient.Registries.ListCredentialsAsync(_testResourceGroup, registryName);
            string username = registryCredentials.Username;
            string password = registryCredentials.Passwords[0].Value;
            AcrClientCredentials credential = new AcrClientCredentials(AcrClientCredentials.LoginMode.Basic, registry.LoginServer, username, password);
            var acrClient = context.GetServiceClientWithCredentials<AzureContainerRegistryClient>(credential, CreateNewRecordedDelegatingHandler());
            //var acrClient = new AzureContainerRegistryClient(credential)
            acrClient.LoginUri = "https://" + registry.LoginServer;

            return acrClient;
        }

        private static RecordedDelegatingHandler CreateNewRecordedDelegatingHandler()
        {
            return new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK, IsPassThrough = true };
        }
    }
}
