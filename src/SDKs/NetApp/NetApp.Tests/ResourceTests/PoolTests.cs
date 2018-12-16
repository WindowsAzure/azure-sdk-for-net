﻿using NetApp.Tests.Helpers;
using Microsoft.Azure.Management.NetApp;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using Xunit;
using System;
using Microsoft.Azure.Management.NetApp.Models;
using System.Collections.Generic;

namespace NetApp.Tests.ResourceTests
{
    public class PoolTests : TestBase
    {
        [Fact]
        public void CreateDeletePool()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create the account
                ResourceUtils.CreateAccount(netAppMgmtClient);

                // create the pool, get all pools and check
                ResourceUtils.CreatePool(netAppMgmtClient, ResourceUtils.poolName1, ResourceUtils.accountName1, poolOnly: true);
                var poolsBefore = netAppMgmtClient.Pools.List(ResourceUtils.resourceGroup, ResourceUtils.accountName1);
                Assert.Single(poolsBefore);

                // delete the pool and check again
                netAppMgmtClient.Pools.Delete(ResourceUtils.resourceGroup, ResourceUtils.accountName1, ResourceUtils.poolName1);
                var poolsAfter = netAppMgmtClient.Pools.List(ResourceUtils.resourceGroup, ResourceUtils.accountName1);
                Assert.Empty(poolsAfter);

                // cleanup - remove the account
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void ListPools()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create two pools under same account
                ResourceUtils.CreatePool(netAppMgmtClient);
                ResourceUtils.CreatePool(netAppMgmtClient, ResourceUtils.poolName2, poolOnly: true);

                // get the account list and check
                var pools = netAppMgmtClient.Pools.List(ResourceUtils.resourceGroup, ResourceUtils.accountName1);
                Assert.Equal(pools.ElementAt(0).Name, ResourceUtils.accountName1 + '/' + ResourceUtils.poolName1);
                Assert.Equal(pools.ElementAt(1).Name, ResourceUtils.accountName1 + '/' + ResourceUtils.poolName2);
                Assert.Equal(2, pools.Count());

                // clean up - delete the two pools and the account
                ResourceUtils.DeletePool(netAppMgmtClient, ResourceUtils.poolName2);
                ResourceUtils.DeletePool(netAppMgmtClient);
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void GetPoolByName()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create the account and pool
                ResourceUtils.CreatePool(netAppMgmtClient);

                // get and check the pool
                var pool = netAppMgmtClient.Pools.Get(ResourceUtils.resourceGroup, ResourceUtils.accountName1, ResourceUtils.poolName1);
                Assert.Equal(pool.Name, ResourceUtils.accountName1 + '/' + ResourceUtils.poolName1);

                // clean up - delete the pool and account
                ResourceUtils.DeletePool(netAppMgmtClient);
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void GetPoolByNameNotFound()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create an account
                ResourceUtils.CreateAccount(netAppMgmtClient);

                // try and get the non-existent pool
                try
                {
                    var pool = netAppMgmtClient.Pools.Get(ResourceUtils.resourceGroup, ResourceUtils.accountName1, ResourceUtils.poolName1);
                    Assert.True(false); // expecting exception
                }
                catch (Exception ex)
                {
                    Assert.Contains("NotFound", ex.Message);
                }

                // cleanup - remove the account
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void GetPoolByNameAccountNotFound()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create an account and pool
                ResourceUtils.CreatePool(netAppMgmtClient);

                // get and check the pool in a non-existent account
                try
                {
                    var pool = netAppMgmtClient.Pools.Get(ResourceUtils.resourceGroup, ResourceUtils.accountName2, ResourceUtils.poolName1);
                    Assert.True(false); // expecting exception
                }
                catch (Exception ex)
                {
                    Assert.Contains("NotFound", ex.Message);
                }

                // cleanup - remove pool and account
                ResourceUtils.DeletePool(netAppMgmtClient);
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void DeleteAccountWithPoolPresent()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create the account and pool
                ResourceUtils.CreatePool(netAppMgmtClient);

                var poolsBefore = netAppMgmtClient.Pools.List(ResourceUtils.resourceGroup, ResourceUtils.accountName1);
                Assert.Single(poolsBefore);

                // try and delete the account
                try
                {
                    netAppMgmtClient.Accounts.Delete(ResourceUtils.resourceGroup, ResourceUtils.accountName1);
                    Assert.True(false); // expecting exception
                }
                catch (Exception ex)
                {
                    Assert.Contains("Conflict", ex.Message);
                }

                // clean up
                ResourceUtils.DeletePool(netAppMgmtClient);
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void UpdatePool()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                // create the pool
                var pool = ResourceUtils.CreatePool(netAppMgmtClient);
                Assert.Equal("Premium", pool.ServiceLevel);

                // update
                pool.ServiceLevel = "Standard";
                var updatedPool = netAppMgmtClient.Pools.CreateOrUpdate(pool, ResourceUtils.resourceGroup, ResourceUtils.accountName1, ResourceUtils.poolName1);
                Assert.Equal("Standard", updatedPool.ServiceLevel);

                // cleanup
                ResourceUtils.DeletePool(netAppMgmtClient);
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        [Fact]
        public void PatchPool()
        {
            HttpMockServer.RecordsDirectory = GetSessionsDirectoryPath();
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var netAppMgmtClient = NetAppTestUtilities.GetNetAppManagementClient(context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
                
                // create the pool
                var pool = ResourceUtils.CreatePool(netAppMgmtClient);
                Assert.Null(pool.Tags);
                
                var dict = new Dictionary<string, string>();
                dict.Add("Tag1", "Value1");

                // Now try and modify it
                var poolPatch = new CapacityPoolPatch()
                {
                    Tags = dict
                };

                var resource = netAppMgmtClient.Pools.Update(poolPatch, ResourceUtils.resourceGroup, ResourceUtils.accountName1, ResourceUtils.poolName1);
                Assert.True(resource.Tags.ToString().Contains("Tag1") && resource.Tags.ToString().Contains("Value1"));
                
                // cleanup
                ResourceUtils.DeletePool(netAppMgmtClient);
                ResourceUtils.DeleteAccount(netAppMgmtClient);
            }
        }

        private static string GetSessionsDirectoryPath()
        {
            string executingAssemblyPath = typeof(NetApp.Tests.ResourceTests.PoolTests).GetTypeInfo().Assembly.Location;
            return Path.Combine(Path.GetDirectoryName(executingAssemblyPath), "SessionRecords");
        }
    }
}
