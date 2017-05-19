// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RoleAssignments.
    /// </summary>
    public static partial class RoleAssignmentsExtensions
    {
            /// <summary>
            /// Gets role assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource to get role assignments for.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            public static RoleAssignmentListResult ListForResource(this IRoleAssignments operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string filter = default(string))
            {
                return operations.ListForResourceAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource to get role assignments for.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentListResult> ListForResourceAsync(this IRoleAssignments operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            public static RoleAssignmentListResult ListForResourceGroup(this IRoleAssignments operations, string resourceGroupName, string filter = default(string))
            {
                return operations.ListForResourceGroupAsync(resourceGroupName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentListResult> ListForResourceGroupAsync(this IRoleAssignments operations, string resourceGroupName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to delete.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to delete.
            /// </param>
            public static RoleAssignment Delete(this IRoleAssignments operations, string scope, string roleAssignmentName)
            {
                return operations.DeleteAsync(scope, roleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to delete.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignment> DeleteAsync(this IRoleAssignments operations, string scope, string roleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, roleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to create. The scope can be any REST
            /// resource instance. For example, use '/subscriptions/{subscription-id}/' for
            /// a subscription,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// a resource group, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}'
            /// for a resource.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to create. It can be any valid GUID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the role assignment.
            /// </param>
            public static RoleAssignment Create(this IRoleAssignments operations, string scope, string roleAssignmentName, RoleAssignmentCreateParameters parameters)
            {
                return operations.CreateAsync(scope, roleAssignmentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to create. The scope can be any REST
            /// resource instance. For example, use '/subscriptions/{subscription-id}/' for
            /// a subscription,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// a resource group, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}'
            /// for a resource.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to create. It can be any valid GUID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the role assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignment> CreateAsync(this IRoleAssignments operations, string scope, string roleAssignmentName, RoleAssignmentCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(scope, roleAssignmentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to get.
            /// </param>
            public static RoleAssignment Get(this IRoleAssignments operations, string scope, string roleAssignmentName)
            {
                return operations.GetAsync(scope, roleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignment> GetAsync(this IRoleAssignments operations, string scope, string roleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, roleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to delete.
            /// </param>
            public static RoleAssignment DeleteById(this IRoleAssignments operations, string roleAssignmentId)
            {
                return operations.DeleteByIdAsync(roleAssignmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignment> DeleteByIdAsync(this IRoleAssignments operations, string roleAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(roleAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the role assignment.
            /// </param>
            public static RoleAssignment CreateById(this IRoleAssignments operations, string roleAssignmentId, RoleAssignmentCreateParameters parameters)
            {
                return operations.CreateByIdAsync(roleAssignmentId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the role assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignment> CreateByIdAsync(this IRoleAssignments operations, string roleAssignmentId, RoleAssignmentCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateByIdWithHttpMessagesAsync(roleAssignmentId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to get.
            /// </param>
            public static RoleAssignment GetById(this IRoleAssignments operations, string roleAssignmentId)
            {
                return operations.GetByIdAsync(roleAssignmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignment> GetByIdAsync(this IRoleAssignments operations, string roleAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(roleAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all role assignments for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            public static RoleAssignmentListResult List(this IRoleAssignments operations, string filter = default(string))
            {
                return operations.ListAsync(filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all role assignments for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentListResult> ListAsync(this IRoleAssignments operations, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignments.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            public static RoleAssignmentListResult ListForScope(this IRoleAssignments operations, string scope, string filter = default(string))
            {
                return operations.ListForScopeAsync(scope, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignments.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. Use $filter=atScope() to return all
            /// role assignments at or above the scope. Use $filter=principalId eq {id} to
            /// return all role assignments at, above or below the scope for the specified
            /// principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentListResult> ListForScopeAsync(this IRoleAssignments operations, string scope, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeWithHttpMessagesAsync(scope, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
