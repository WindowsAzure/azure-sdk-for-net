// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Insights.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Insights
{
    /// <summary>
    /// Operations for managing the alert rules and incidents.
    /// </summary>
    public partial interface IAlertOperations
    {
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// The rule to create or update.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateOrUpdateRuleAsync(string resourceGroupName, RuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteRuleAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
        /// </param>
        /// <param name='incidentName'>
        /// The name of the incident to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Incident operation response.
        /// </returns>
        Task<IncidentGetResponse> GetIncidentAsync(string resourceGroupName, string ruleName, string incidentName, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Rule operation response.
        /// </returns>
        Task<RuleGetResponse> GetRuleAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List incidents operation response.
        /// </returns>
        Task<IncidentListResponse> ListIncidentsForRuleAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// List the alert rules within a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='targetResourceUri'>
        /// The resource uri of the target of the alert rule.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Rules operation response.
        /// </returns>
        Task<RuleListResponse> ListRulesAsync(string resourceGroupName, string targetResourceUri, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// The rule to update.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateRuleAsync(string resourceGroupName, RuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
