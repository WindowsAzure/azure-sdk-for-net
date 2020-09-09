// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkloadClassifiersOperations.
    /// </summary>
    public static partial class WorkloadClassifiersOperationsExtensions
    {
            /// <summary>
            /// Gets a workload classifier
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            public static WorkloadClassifier Get(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName)
            {
                return operations.GetAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workload classifier
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadClassifier> GetAsync(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to create/update.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            public static WorkloadClassifier CreateOrUpdate(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to create/update.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadClassifier> CreateOrUpdateAsync(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to delete.
            /// </param>
            public static void Delete(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of workload classifiers for a workload group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifiers from.
            /// </param>
            public static IPage<WorkloadClassifier> ListByWorkloadGroup(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName)
            {
                return operations.ListByWorkloadGroupAsync(resourceGroupName, serverName, databaseName, workloadGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of workload classifiers for a workload group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifiers from.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadClassifier>> ListByWorkloadGroupAsync(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkloadGroupWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, workloadGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to create/update.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            public static WorkloadClassifier BeginCreateOrUpdate(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to create/update.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadClassifier> BeginCreateOrUpdateAsync(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to delete.
            /// </param>
            public static void BeginDelete(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a workload classifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group from which to receive the classifier from.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IWorkloadClassifiersOperations operations, string resourceGroupName, string serverName, string databaseName, string workloadGroupName, string workloadClassifierName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of workload classifiers for a workload group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkloadClassifier> ListByWorkloadGroupNext(this IWorkloadClassifiersOperations operations, string nextPageLink)
            {
                return operations.ListByWorkloadGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of workload classifiers for a workload group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadClassifier>> ListByWorkloadGroupNextAsync(this IWorkloadClassifiersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkloadGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
