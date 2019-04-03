// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;

    /// <summary>
    /// Extension methods for TokensOperations.
    /// </summary>
    public static partial class TokensOperationsExtensions
    {
            /// <summary>
            /// Gets the properties of the specified token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            public static Token Get(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName)
            {
                return operations.GetAsync(resourceGroupName, registryName, tokenName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Token> GetAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a token for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            public static Token Create(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string))
            {
                return operations.CreateAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a token for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Token> CreateAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a token from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            public static void Delete(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, tokenName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a token from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a token with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            public static Token Update(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a token with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Token> UpdateAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the tokens for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            public static IPage<Token> List(this ITokensOperations operations, string resourceGroupName, string registryName)
            {
                return operations.ListAsync(resourceGroupName, registryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the tokens for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<Token>> ListAsync(this ITokensOperations operations, string resourceGroupName, string registryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a token for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            public static Token BeginCreate(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string))
            {
                return operations.BeginCreateAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a token for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Token> BeginCreateAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a token from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            public static void BeginDelete(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, tokenName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a token from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a token with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            public static Token BeginUpdate(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string))
            {
                return operations.BeginUpdateAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a token with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='tokenName'>
            /// The name of the token.
            /// </param>
            /// <param name='scopeMapId'>
            /// The resource ID of the scope map to which the token will be associated
            /// with.
            /// </param>
            /// <param name='objectId'>
            /// The user/group/application object ID for which the token has to be created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Token> BeginUpdateAsync(this ITokensOperations operations, string resourceGroupName, string registryName, string tokenName, string scopeMapId = default(string), string objectId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, tokenName, scopeMapId, objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the tokens for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Token> ListNext(this ITokensOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the tokens for the specified container registry.
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
            public static async System.Threading.Tasks.Task<IPage<Token>> ListNextAsync(this ITokensOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
