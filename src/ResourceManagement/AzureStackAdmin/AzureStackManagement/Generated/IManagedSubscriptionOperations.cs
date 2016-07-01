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
using Microsoft.Azure;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    /// <summary>
    /// Administrator Operations on the subscription  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
    /// more information)
    /// </summary>
    public partial interface IManagedSubscriptionOperations
    {
        /// <summary>
        /// Result of the create or update operation of the subscription  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Subscription update parameters
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Result of the create or the update operation of the subscription
        /// </returns>
        Task<ManagedSubscriptionCreateOrUpdateResult> CreateOrUpdateAsync(ManagedSubscriptionCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete operation of the subscription  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='subscriptionId'>
        /// Subscription Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string subscriptionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the administrator view of the subscription  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='subscriptionId'>
        /// Subscription Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        Task<ManagedSubscriptionGetResult> GetAsync(string subscriptionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists the subscriptions  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Result of the list operations
        /// </returns>
        Task<ManagedSubscriptionListResult> ListAsync(bool includeDetails, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists the subscription with the next link  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='nextLink'>
        /// Next link for the subscription  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Result of the list operations
        /// </returns>
        Task<ManagedSubscriptionListResult> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
