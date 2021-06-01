// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PortalRevisionOperations.
    /// </summary>
    public static partial class PortalRevisionOperationsExtensions
    {
            /// <summary>
            /// Lists developer portal's revisions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='filter'>
            /// | Field       | Supported operators    | Supported functions
            /// |
            /// |-------------|------------------------|-----------------------------------|
            ///
            /// |name | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
            /// endswith|
            /// |description | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
            /// endswith|
            /// |isCurrent | eq, ne |    |
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skip'>
            /// Number of records to skip.
            /// </param>
            public static IPage<PortalRevisionContract> ListByService(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists developer portal's revisions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='filter'>
            /// | Field       | Supported operators    | Supported functions
            /// |
            /// |-------------|------------------------|-----------------------------------|
            ///
            /// |name | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
            /// endswith|
            /// |description | ge, le, eq, ne, gt, lt | substringof, contains, startswith,
            /// endswith|
            /// |isCurrent | eq, ne |    |
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skip'>
            /// Number of records to skip.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PortalRevisionContract>> ListByServiceAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the developer portal revision specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            public static PortalRevisionGetEntityTagHeaders GetEntityTag(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, portalRevisionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the developer portal revision specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalRevisionGetEntityTagHeaders> GetEntityTagAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, portalRevisionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the developer portal's revision specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            public static PortalRevisionContract Get(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, portalRevisionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the developer portal's revision specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalRevisionContract> GetAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, portalRevisionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new developer portal's revision by running the portal's
            /// publishing. The `isCurrent` property indicates if the revision is publicly
            /// accessible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PortalRevisionContract CreateOrUpdate(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, portalRevisionId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new developer portal's revision by running the portal's
            /// publishing. The `isCurrent` property indicates if the revision is publicly
            /// accessible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalRevisionContract> CreateOrUpdateAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, portalRevisionId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the description of specified portal revision or makes it current.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static PortalRevisionContract Update(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters, string ifMatch)
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, portalRevisionId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the description of specified portal revision or makes it current.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalRevisionContract> UpdateAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, portalRevisionId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new developer portal's revision by running the portal's
            /// publishing. The `isCurrent` property indicates if the revision is publicly
            /// accessible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PortalRevisionContract BeginCreateOrUpdate(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, portalRevisionId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new developer portal's revision by running the portal's
            /// publishing. The `isCurrent` property indicates if the revision is publicly
            /// accessible.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalRevisionContract> BeginCreateOrUpdateAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, portalRevisionId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the description of specified portal revision or makes it current.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static PortalRevisionContract BeginUpdate(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters, string ifMatch)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serviceName, portalRevisionId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the description of specified portal revision or makes it current.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalRevisionId'>
            /// Portal revision identifier. Must be unique in the current API Management
            /// service instance.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalRevisionContract> BeginUpdateAsync(this IPortalRevisionOperations operations, string resourceGroupName, string serviceName, string portalRevisionId, PortalRevisionContract parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, portalRevisionId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists developer portal's revisions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PortalRevisionContract> ListByServiceNext(this IPortalRevisionOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists developer portal's revisions.
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
            public static async Task<IPage<PortalRevisionContract>> ListByServiceNextAsync(this IPortalRevisionOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
