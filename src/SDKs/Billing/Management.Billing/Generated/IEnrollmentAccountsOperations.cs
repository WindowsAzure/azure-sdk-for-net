// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// EnrollmentAccountsOperations operations.
    /// </summary>
    public partial interface IEnrollmentAccountsOperations
    {
        /// <summary>
        /// Lists all Enrollment Accounts for a user which he has access to.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='expand'>
        /// May be used to expand the department.
        /// </param>
        /// <param name='filter'>
        /// The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It
        /// does not currently support 'ne', 'or', or 'not'. Tag filter is a
        /// key value pair string where key and value is separated by a colon
        /// (:).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EnrollmentAccountListResult>> ListByBillingAccountNameWithHttpMessagesAsync(string billingAccountName, string expand = default(string), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the enrollment account by id.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='enrollmentAccountName'>
        /// Enrollment Account Id.
        /// </param>
        /// <param name='expand'>
        /// May be used to expand the Department.
        /// </param>
        /// <param name='filter'>
        /// The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It
        /// does not currently support 'ne', 'or', or 'not'. Tag filter is a
        /// key value pair string where key and value is separated by a colon
        /// (:).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<EnrollmentAccount>> GetByEnrollmentAccountIdWithHttpMessagesAsync(string billingAccountName, string enrollmentAccountName, string expand = default(string), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
