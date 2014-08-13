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
    /// Operations for managing the autoscale.
    /// </summary>
    public partial interface IAutoscaleOperations
    {
        /// <param name='resourceGroupName'>
        /// The resource name.
        /// </param>
        /// <param name='autoscaleSettingName'>
        /// The autoscale setting name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateOrUpdateSettingAsync(string resourceGroupName, string autoscaleSettingName, AutoscaleSettingCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The resource name.
        /// </param>
        /// <param name='autoscaleSettingName'>
        /// The autoscale setting name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteSettingAsync(string resourceGroupName, string autoscaleSettingName, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The resource name.
        /// </param>
        /// <param name='autoscaleSettingName'>
        /// The autoscale setting name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AutoscaleSettingGetResponse> GetSettingAsync(string resourceGroupName, string autoscaleSettingName, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The resource name.
        /// </param>
        /// <param name='targetResourceUri'>
        /// The resource uri of the target of the autoscale setting.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Autoscale settings operation response.
        /// </returns>
        Task<AutoscaleSettingListResponse> ListSettingsAsync(string resourceGroupName, string targetResourceUri, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The resource name.
        /// </param>
        /// <param name='autoscaleSettingName'>
        /// The autoscale setting name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateSettingAsync(string resourceGroupName, string autoscaleSettingName, AutoscaleSettingCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
