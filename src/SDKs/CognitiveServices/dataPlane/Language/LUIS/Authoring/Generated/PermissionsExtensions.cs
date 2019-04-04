// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Permissions.
    /// </summary>
    public static partial class PermissionsExtensions
    {
            /// <summary>
            /// Gets the list of user emails that have permissions to access your
            /// application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserAccessList> ListAsync(this IPermissions operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a user to the allowed list of users to access this LUIS application.
            /// Users are added using their email address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='userToAdd'>
            /// A model containing the user's email address.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> AddAsync(this IPermissions operations, System.Guid appId, UserCollaborator userToAdd, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(appId, userToAdd, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a user from the allowed list of users to access this LUIS
            /// application. Users are removed using their email address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='userToDelete'>
            /// A model containing the user's email address.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeleteAsync(this IPermissions operations, System.Guid appId, UserCollaborator userToDelete, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(appId, userToDelete, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Replaces the current user access list with the new list sent in the body.
            /// If an empty list is sent, all access to other users will be removed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='collaborators'>
            /// A model containing a list of user email addresses.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> UpdateAsync(this IPermissions operations, System.Guid appId, CollaboratorsArray collaborators, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(appId, collaborators, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
