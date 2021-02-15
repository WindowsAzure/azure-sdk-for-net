// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace ServiceFabric.Tests.Managed
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Resources;
    using Microsoft.Azure.Management.ServiceFabricManagedClusters;
    using Microsoft.Azure.Management.ServiceFabricManagedClusters.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using Xunit;
    using System.Threading.Tasks;

    public class ApplicationTests : ServiceFabricManagedTestBase
    {
        internal const string Location = "South Central US";
        internal const string ResourceGroupPrefix = "sfmc-net-sdk-app-rg-";
        internal const string ClusterNamePrefix = "sfmcnetsdk";

        private const string AppName = "Voting";
        private const string AppTypeVersionName = "1.0.0";
        private const string AppTypeName = "VotingType";
        private const string AppPackageUrl = "https://sfmconeboxst.blob.core.windows.net/managed-application-deployment/Voting.sfpkg";
        private const string StatefulServiceName = "VotingData";
        private const string StatefulServiceTypeName = "VotingDataType";

        [Fact]
        public void AppCreateDeleteTest()
        {
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                var serviceFabricMcClient = GetServiceFabricMcClient(context);
                var resourceClient = GetResourceManagementClient(context);
                var resourceGroupName = TestUtilities.GenerateName(ResourceGroupPrefix);
                var clusterName = TestUtilities.GenerateName(ClusterNamePrefix);
                var nodeTypeName = TestUtilities.GenerateName("nt");

                var cluster = this.CreateManagedCluster(resourceClient, serviceFabricMcClient, resourceGroupName, Location, clusterName, sku: "Basic");
                cluster = serviceFabricMcClient.ManagedClusters.Get(resourceGroupName, clusterName);
                Assert.NotNull(cluster);
                Assert.Equal("Succeeded", cluster.ProvisioningState);
                Assert.Equal("WaitingForNodes", cluster.ClusterState);
                var primaryNodeType = this.CreateNodeType(serviceFabricMcClient, resourceGroupName, clusterName, nodeTypeName, isPrimary: true, vmInstanceCount: 6);

                this.WaitForClusterReadyState(serviceFabricMcClient, resourceGroupName, clusterName);

                CreateAppType(serviceFabricMcClient, resourceGroupName, clusterName, cluster.ClusterId, AppTypeName);
                var appTypeVersion = CreateAppTypeVersion(serviceFabricMcClient, resourceGroupName, clusterName, cluster.ClusterId, AppTypeName, AppTypeVersionName, AppPackageUrl);
                CreateApplication(serviceFabricMcClient, resourceGroupName, clusterName, cluster.ClusterId, AppName, appTypeVersion.Id);
                CreateService(serviceFabricMcClient, resourceGroupName, clusterName, cluster.ClusterId, AppName, StatefulServiceTypeName, StatefulServiceName);

                DeleteApplication(serviceFabricMcClient, resourceGroupName, clusterName, cluster.ClusterId, AppName);
                DeleteAppType(serviceFabricMcClient, resourceGroupName, clusterName, cluster.ClusterId, AppTypeName);
            }
        }

        private void CreateAppType(
            ServiceFabricManagedClustersManagementClient serviceFabricMcClient,
            string resourceGroup,
            string clusterName,
            string clusterId,
            string appTypeName)
        {
            var appTypeResourceId = $"{clusterId}/applicationTypes/{appTypeName}";

            var appTypeParams = new ApplicationTypeResource(
                name: appTypeName,
                location: Location,
                id: appTypeResourceId);

            var appTypeResult = serviceFabricMcClient.ApplicationTypes.CreateOrUpdate(
                resourceGroup,
                clusterName,
                appTypeName,
                appTypeParams);

            Assert.Equal("Succeeded", appTypeResult.ProvisioningState);
        }

        private ApplicationTypeVersionResource CreateAppTypeVersion(
            ServiceFabricManagedClustersManagementClient serviceFabricMcClient,
            string resourceGroup,
            string clusterName,
            string clusterId,
            string appTypeName,
            string appTypeVersionName,
            string appPackageUrl)
        {
            var appTypeVersionResourceId = $"{clusterId}/applicationTypes/{appTypeName}/versions/{appTypeVersionName}";

            var appTypeVersionParams = new ApplicationTypeVersionResource(
                name: AppTypeVersionName,
                location: Location,
                id: appTypeVersionResourceId,
                appPackageUrl: appPackageUrl);

            var appTypeVersionResult = serviceFabricMcClient.ApplicationTypeVersions.CreateOrUpdate(
                resourceGroup,
                clusterName,
                appTypeName,
                appTypeVersionName,
                appTypeVersionParams);

            Assert.Equal("Succeeded", appTypeVersionResult.ProvisioningState);
            return appTypeVersionResult;
        }

        private void CreateApplication(
            ServiceFabricManagedClustersManagementClient serviceFabricMcClient,
            string resourceGroup,
            string clusterName,
            string clusterId,
            string appName,
            string versionResourceId)
        {
            var applicationResourceId = $"{clusterId}/applications/{appName}";

            var applicationParams = new ApplicationResource(
                name: appName,
                location: Location,
                id: applicationResourceId,
                version: versionResourceId,
                upgradePolicy: new ApplicationUpgradePolicy(recreateApplication: true));

            var applicationResult = serviceFabricMcClient.Applications.CreateOrUpdate(
                resourceGroup,
                clusterName,
                appName,
                applicationParams);

            Assert.Equal("Succeeded", applicationResult.ProvisioningState);
        }

        private void CreateService(
            ServiceFabricManagedClustersManagementClient serviceFabricMcClient,
            string resourceGroup,
            string clusterName,
            string clusterId,
            string appName,
            string serviceTypeName,
            string serviceName)
        {
            var serviceResourceId = $"{clusterId}/applications/{appName}/services/{serviceName}";

            var serviceParams = new ServiceResource(
                name: serviceName,
                location: Location,
                id: serviceResourceId,
                properties: new StatefulServiceProperties(
                    serviceTypeName: serviceTypeName,
                    partitionDescription: new UniformInt64RangePartitionScheme(
                        count: 1,
                        lowKey: 0,
                        highKey: 25),
                    hasPersistedState: true,
                    targetReplicaSetSize: 5,
                    minReplicaSetSize: 3));

            var serviceResult = serviceFabricMcClient.Services.CreateOrUpdate(
                resourceGroup,
                clusterName,
                appName,
                serviceName,
                serviceParams);

            Assert.Equal("Succeeded", serviceResult.Properties.ProvisioningState);
        }

        private void DeleteApplication(
            ServiceFabricManagedClustersManagementClient serviceFabricMcClient,
            string resourceGroup,
            string clusterName,
            string clusterId,
            string appName)
        {
            var deleteStartTime = DateTime.UtcNow;
            var applicationResourceId = $"{clusterId}/applications/{appName}";

            serviceFabricMcClient.Applications.Delete(
                resourceGroup,
                clusterName,
                appName);

            var ex = Assert.ThrowsAsync<ErrorModelException>(
                () => serviceFabricMcClient.Applications.GetAsync(resourceGroup, clusterName, appName)).Result;
            Assert.True(ex.Response.StatusCode == System.Net.HttpStatusCode.NotFound);
        }

        private void DeleteAppType(
            ServiceFabricManagedClustersManagementClient serviceFabricMcClient,
            string resourceGroup,
            string clusterName,
            string clusterId,
            string appTypeName)
        {
            var appTypeResourceId = $"{clusterId}/applicationTypes/{appTypeName}";

            serviceFabricMcClient.ApplicationTypes.Delete(
                resourceGroup,
                clusterName,
                appTypeName);

            var ex = Assert.ThrowsAsync<ErrorModelException>(
                () => serviceFabricMcClient.ApplicationTypes.GetAsync(resourceGroup, clusterName, appTypeName)).Result;
            Assert.True(ex.Response.StatusCode == System.Net.HttpStatusCode.NotFound);
        }
    }
}

