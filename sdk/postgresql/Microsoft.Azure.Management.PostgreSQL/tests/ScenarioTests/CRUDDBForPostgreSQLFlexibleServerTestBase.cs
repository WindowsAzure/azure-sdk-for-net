﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using PostgreSQL.Tests.Helpers;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.Azure.Management.PostgreSQL.FlexibleServers;
using Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models;

namespace Microsoft.Azure.Management.PostgreSQL.Tests.ScenarioTests
{
    public class CRUDDBForPostgreSQLFlexibleServerTestBase
    {
        protected static string ResourceGroupName;
        protected static string ServerName;

        public CRUDDBForPostgreSQLFlexibleServerTestBase()
        {
            ResourceGroupName = "pgsdkrg";
            ServerName = "pgsdkflexserver";
        }

        protected Server CreatePostgreSQLFlexibleServersInstance(MockContext context,
            FlexibleServers.PostgreSQLManagementClient client,
            ResourceGroup resourceGroup,
            string serverName)
        {
            return client.Servers.Create(
                resourceGroup.Name,
                serverName,
                new Server(location: resourceGroup.Location,
                            sku: new FlexibleServers.Models.Sku("Standard_D4s_v3", "GeneralPurpose"),
                            administratorLogin: "testUser",
                            administratorLoginPassword: "testPassword1!",
                            version: "12",
                            storageProfile: new StorageProfile(storageMB: 524288)));
        }

        protected ResourceGroup CreateResourceGroup(MockContext context,
            RecordedDelegatingHandler handler,
            string resourceGroupName,
            string location)
        {
            var resourcesClient =
                Utilities.GetResourceManagementClient(
                    context,
                    handler);

            var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                resourceGroupName,
                new ResourceGroup
                {
                    Location = location
                });

            return resourceGroup;
        }

        protected void DeleteResourceGroup(MockContext context,
            RecordedDelegatingHandler handler,
            string resourceGroupName)
        {
            var resourcesClient =
                Utilities.GetResourceManagementClient(
                    context,
                    handler);

            resourcesClient.ResourceGroups.Delete(resourceGroupName);
        }
    }
}
