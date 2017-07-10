// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProductOperations.
    /// </summary>
    public static partial class ProductOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of products in the specified service instance.
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='expandGroups'>
            /// When set to true, the response contains an array of groups that have
            /// visibility to the product. The default is false.
            /// </param>
            public static IPage<ProductContract> ListByService(this IProductOperations operations, string resourceGroupName, string serviceName, ODataQuery<ProductContract> odataQuery = default(ODataQuery<ProductContract>), bool? expandGroups = default(bool?))
            {
                return ((IProductOperations)operations).ListByServiceAsync(resourceGroupName, serviceName, odataQuery, expandGroups).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of products in the specified service instance.
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='expandGroups'>
            /// When set to true, the response contains an array of groups that have
            /// visibility to the product. The default is false.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProductContract>> ListByServiceAsync(this IProductOperations operations, string resourceGroupName, string serviceName, ODataQuery<ProductContract> odataQuery = default(ODataQuery<ProductContract>), bool? expandGroups = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, expandGroups, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of the product specified by its identifier.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static ProductContract Get(this IProductOperations operations, string resourceGroupName, string serviceName, string productId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, productId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the product specified by its identifier.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProductContract> GetAsync(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, productId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a product.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create or update parameters.
            /// </param>
            public static ProductContract CreateOrUpdate(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, ProductCreateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, productId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a product.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create or update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProductContract> CreateOrUpdateAsync(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, ProductCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, productId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update product.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Product Entity. ETag should match the current entity state from
            /// the header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Update(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, ProductUpdateParameters parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, productId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update product.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Product Entity. ETag should match the current entity state from
            /// the header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, ProductUpdateParameters parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, productId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete product.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Product Entity. ETag should match the current entity state from
            /// the header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='deleteSubscriptions'>
            /// Delete existing subscriptions to the product or not.
            /// </param>
            public static void Delete(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, string ifMatch, bool? deleteSubscriptions = default(bool?))
            {
                operations.DeleteAsync(resourceGroupName, serviceName, productId, ifMatch, deleteSubscriptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete product.
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
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Product Entity. ETag should match the current entity state from
            /// the header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='deleteSubscriptions'>
            /// Delete existing subscriptions to the product or not.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProductOperations operations, string resourceGroupName, string serviceName, string productId, string ifMatch, bool? deleteSubscriptions = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, productId, ifMatch, deleteSubscriptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists a collection of products in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProductContract> ListByServiceNext(this IProductOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of products in the specified service instance.
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
            public static async Task<IPage<ProductContract>> ListByServiceNextAsync(this IProductOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
