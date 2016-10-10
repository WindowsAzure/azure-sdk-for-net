// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for LogProfilesOperations.
    /// </summary>
    public static partial class LogProfilesOperationsExtensions
    {
            /// <summary>
            /// Deletes the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            public static void Delete(this ILogProfilesOperations operations, string logProfileName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ILogProfilesOperations)s).DeleteAsync(logProfileName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ILogProfilesOperations operations, string logProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(logProfileName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            public static LogProfileResource Get(this ILogProfilesOperations operations, string logProfileName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILogProfilesOperations)s).GetAsync(logProfileName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LogProfileResource> GetAsync(this ILogProfilesOperations operations, string logProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(logProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static LogProfileResource CreateOrUpdate(this ILogProfilesOperations operations, string logProfileName, LogProfileCreateOrUpdateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILogProfilesOperations)s).CreateOrUpdateAsync(logProfileName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the log profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logProfileName'>
            /// The name of the log profile.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LogProfileResource> CreateOrUpdateAsync(this ILogProfilesOperations operations, string logProfileName, LogProfileCreateOrUpdateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(logProfileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the log profiles.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IEnumerable<LogProfileResource> List(this ILogProfilesOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILogProfilesOperations)s).ListAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the log profiles.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<LogProfileResource>> ListAsync(this ILogProfilesOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
