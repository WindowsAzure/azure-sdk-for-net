// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DataConnectionsOperations operations.
    /// </summary>
    public partial interface IDataConnectionsOperations
    {
        /// <summary>
        /// Returns the list of data connections of the given Kusto database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<DataConnection>>> ListByDatabaseWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks that the data connection parameters are valid.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='parameters'>
        /// The data connection parameters supplied to the CreateOrUpdate
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataConnectionValidationListResult>> DataConnectionValidationMethodWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, DataConnectionValidation parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks that the data connection name is valid and is not already in
        /// use.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckNameResult>> CheckNameAvailabilityWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, DataConnectionCheckNameRequest dataConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a data connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a data connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='parameters'>
        /// The data connection parameters supplied to the CreateOrUpdate
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, DataConnection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a data connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='parameters'>
        /// The data connection parameters supplied to the Update operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataConnection>> UpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, DataConnection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the data connection with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a data connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='parameters'>
        /// The data connection parameters supplied to the CreateOrUpdate
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataConnection>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, DataConnection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a data connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='parameters'>
        /// The data connection parameters supplied to the Update operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataConnection>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, DataConnection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the data connection with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='dataConnectionName'>
        /// The name of the data connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, string dataConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
