// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsageModels.
    /// </summary>
    public static partial class UsageModelsExtensions
    {
            /// <summary>
            /// Get the list of cache Usage Models available to this subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static UsageModelsResult List(this IUsageModels operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of cache Usage Models available to this subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UsageModelsResult> ListAsync(this IUsageModels operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
