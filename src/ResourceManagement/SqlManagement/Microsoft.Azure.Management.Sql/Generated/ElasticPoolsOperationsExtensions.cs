// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ElasticPoolsOperations.
    /// </summary>
    public static partial class ElasticPoolsOperationsExtensions
    {
            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            public static ElasticPool CreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).CreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ElasticPool> CreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            public static ElasticPool BeginCreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ElasticPool> BeginCreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be deleted.
            /// </param>
            public static void Delete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).DeleteAsync(resourceGroupName, serverName, elasticPoolName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets information about an Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            public static ElasticPool Get(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).GetAsync(resourceGroupName, serverName, elasticPoolName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about an Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ElasticPool> GetAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            public static System.Collections.Generic.IEnumerable<ElasticPool> ListByServer(this IElasticPoolsOperations operations, string resourceGroupName, string serverName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).ListByServerAsync(resourceGroupName, serverName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ElasticPool>> ListByServerAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool for which to get the current
            /// activity.
            /// </param>
            public static System.Collections.Generic.IEnumerable<ElasticPoolActivity> ListActivity(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).ListActivityAsync(resourceGroupName, serverName, elasticPoolName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool for which to get the current
            /// activity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ElasticPoolActivity>> ListActivityAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListActivityWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about activity on Azure SQL databases inside of an
            /// Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool.
            /// </param>
            public static System.Collections.Generic.IEnumerable<ElasticPoolDatabaseActivity> ListDatabaseActivity(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).ListDatabaseActivityAsync(resourceGroupName, serverName, elasticPoolName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about activity on Azure SQL databases inside of an
            /// Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ElasticPoolDatabaseActivity>> ListDatabaseActivityAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListDatabaseActivityWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about an Azure SQL database inside of an Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the Azure SQL database to be retrieved.
            /// </param>
            public static Database GetDatabase(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).GetDatabaseAsync(resourceGroupName, serverName, elasticPoolName, databaseName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about an Azure SQL database inside of an Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the Azure SQL database to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Database> GetDatabaseAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about an Azure SQL database inside of an Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            public static System.Collections.Generic.IEnumerable<Database> ListDatabases(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolsOperations)s).ListDatabasesAsync(resourceGroupName, serverName, elasticPoolName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL database inside of an Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<Database>> ListDatabasesAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListDatabasesWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
