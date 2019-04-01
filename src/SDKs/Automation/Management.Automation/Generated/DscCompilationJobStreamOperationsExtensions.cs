// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DscCompilationJobStreamOperations.
    /// </summary>
    public static partial class DscCompilationJobStreamOperationsExtensions
    {
            /// <summary>
            /// Retrieve all the job streams for the compilation Job.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobId'>
            /// The job id.
            /// </param>
            public static JobStreamListResult ListByJob(this IDscCompilationJobStreamOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobId)
            {
                return operations.ListByJobAsync(resourceGroupName, automationAccountName, jobId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve all the job streams for the compilation Job.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobId'>
            /// The job id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobStreamListResult> ListByJobAsync(this IDscCompilationJobStreamOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByJobWithHttpMessagesAsync(resourceGroupName, automationAccountName, jobId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
