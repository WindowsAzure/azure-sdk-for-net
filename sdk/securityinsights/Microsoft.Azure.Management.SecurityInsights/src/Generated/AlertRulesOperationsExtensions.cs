// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AlertRulesOperations.
    /// </summary>
    public static partial class AlertRulesOperationsExtensions
    {
            /// <summary>
            /// Gets all alert rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IPage<AlertRule> List(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all alert rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AlertRule>> ListAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            public static AlertRule Get(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId)
            {
                return operations.GetAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertRule> GetAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='alertRule'>
            /// The alert rule
            /// </param>
            public static AlertRule CreateOrUpdate(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, AlertRule alertRule)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, alertRule).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='alertRule'>
            /// The alert rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertRule> CreateOrUpdateAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, AlertRule alertRule, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, alertRule, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            public static void Delete(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId)
            {
                operations.DeleteAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the action of alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='actionId'>
            /// Action ID
            /// </param>
            public static ActionResponse GetAction(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, string actionId)
            {
                return operations.GetActionAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, actionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the action of alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='actionId'>
            /// Action ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionResponse> GetActionAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, string actionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetActionWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, actionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the action of alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='actionId'>
            /// Action ID
            /// </param>
            /// <param name='etag'>
            /// Etag of the azure resource
            /// </param>
            /// <param name='triggerUri'>
            /// Logic App Callback URL for this specific workflow.
            /// </param>
            public static ActionResponse CreateOrUpdateAction(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, string actionId, string etag = default(string), string triggerUri = default(string))
            {
                return operations.CreateOrUpdateActionAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, actionId, etag, triggerUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the action of alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='actionId'>
            /// Action ID
            /// </param>
            /// <param name='etag'>
            /// Etag of the azure resource
            /// </param>
            /// <param name='triggerUri'>
            /// Logic App Callback URL for this specific workflow.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionResponse> CreateOrUpdateActionAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, string actionId, string etag = default(string), string triggerUri = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateActionWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, actionId, etag, triggerUri, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the action of alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='actionId'>
            /// Action ID
            /// </param>
            public static void DeleteAction(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, string actionId)
            {
                operations.DeleteActionAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, actionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the action of alert rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='ruleId'>
            /// Alert rule ID
            /// </param>
            /// <param name='actionId'>
            /// Action ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteActionAsync(this IAlertRulesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string ruleId, string actionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteActionWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, ruleId, actionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all alert rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AlertRule> ListNext(this IAlertRulesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all alert rules.
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
            public static async Task<IPage<AlertRule>> ListNextAsync(this IAlertRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
