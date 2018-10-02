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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RunbookDraftOperations.
    /// </summary>
    public static partial class RunbookDraftOperationsExtensions
    {
            /// <summary>
            /// Retrieve the content of runbook draft identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            public static Stream GetContent(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName)
            {
                return operations.GetContentAsync(resourceGroupName, automationAccountName, runbookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the content of runbook draft identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetContentAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetContentWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Replaces the runbook draft content.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='runbookContent'>
            /// The runbook draft content.
            /// </param>
            public static string ReplaceContent(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string runbookContent)
            {
                return operations.ReplaceContentAsync(resourceGroupName, automationAccountName, runbookName, runbookContent).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Replaces the runbook draft content.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='runbookContent'>
            /// The runbook draft content.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ReplaceContentAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string runbookContent, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReplaceContentWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, runbookContent, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the runbook draft identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            public static RunbookDraft Get(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, runbookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the runbook draft identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RunbookDraft> GetAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Undo draft edit to last known published state identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            public static RunbookDraftUndoEditResult UndoEdit(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName)
            {
                return operations.UndoEditAsync(resourceGroupName, automationAccountName, runbookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Undo draft edit to last known published state identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RunbookDraftUndoEditResult> UndoEditAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UndoEditWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Replaces the runbook draft content.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='runbookContent'>
            /// The runbook draft content.
            /// </param>
            public static string BeginReplaceContent(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string runbookContent)
            {
                return operations.BeginReplaceContentAsync(resourceGroupName, automationAccountName, runbookName, runbookContent).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Replaces the runbook draft content.
            /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='runbookContent'>
            /// The runbook draft content.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> BeginReplaceContentAsync(this IRunbookDraftOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string runbookContent, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginReplaceContentWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, runbookContent, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
