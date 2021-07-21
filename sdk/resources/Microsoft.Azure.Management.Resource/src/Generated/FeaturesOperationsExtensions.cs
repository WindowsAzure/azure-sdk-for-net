// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FeaturesOperations.
    /// </summary>
    public static partial class FeaturesOperationsExtensions
    {
            /// <summary>
            /// Gets all the preview features that are available through AFEC for the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static IPage<FeatureResult> ListAll(this IFeaturesOperations operations, string apiVersion)
            {
                return operations.ListAllAsync(apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the preview features that are available through AFEC for the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FeatureResult>> ListAllAsync(this IFeaturesOperations operations, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the preview features in a provider namespace that are available
            /// through AFEC for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider for getting features.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static IPage<FeatureResult> List(this IFeaturesOperations operations, string resourceProviderNamespace, string apiVersion)
            {
                return operations.ListAsync(resourceProviderNamespace, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the preview features in a provider namespace that are available
            /// through AFEC for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider for getting features.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FeatureResult>> ListAsync(this IFeaturesOperations operations, string resourceProviderNamespace, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceProviderNamespace, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the preview feature with the specified name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The resource provider namespace for the feature.
            /// </param>
            /// <param name='featureName'>
            /// The name of the feature to get.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static FeatureResult Get(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, string apiVersion)
            {
                return operations.GetAsync(resourceProviderNamespace, featureName, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the preview feature with the specified name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The resource provider namespace for the feature.
            /// </param>
            /// <param name='featureName'>
            /// The name of the feature to get.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureResult> GetAsync(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, featureName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Registers the preview feature for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// The name of the feature to register.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static FeatureResult Register(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, string apiVersion)
            {
                return operations.RegisterAsync(resourceProviderNamespace, featureName, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers the preview feature for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// The name of the feature to register.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureResult> RegisterAsync(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, featureName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Unregisters the preview feature for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// The name of the feature to unregister.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static FeatureResult Unregister(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, string apiVersion)
            {
                return operations.UnregisterAsync(resourceProviderNamespace, featureName, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters the preview feature for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// The name of the feature to unregister.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureResult> UnregisterAsync(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UnregisterWithHttpMessagesAsync(resourceProviderNamespace, featureName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the preview features that are available through AFEC for the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FeatureResult> ListAllNext(this IFeaturesOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the preview features that are available through AFEC for the
            /// subscription.
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
            public static async Task<IPage<FeatureResult>> ListAllNextAsync(this IFeaturesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the preview features in a provider namespace that are available
            /// through AFEC for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FeatureResult> ListNext(this IFeaturesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the preview features in a provider namespace that are available
            /// through AFEC for the subscription.
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
            public static async Task<IPage<FeatureResult>> ListNextAsync(this IFeaturesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
