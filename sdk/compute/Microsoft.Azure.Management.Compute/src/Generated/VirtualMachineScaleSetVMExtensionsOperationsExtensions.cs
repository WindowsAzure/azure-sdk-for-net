// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineScaleSetVMExtensionsOperations.
    /// </summary>
    public static partial class VirtualMachineScaleSetVMExtensionsOperationsExtensions
    {
            /// <summary>
            /// The operation to create or update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension CreateOrUpdate(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtension extensionParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> CreateOrUpdateAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension Update(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters)
            {
                return operations.UpdateAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> UpdateAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            public static void Delete(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName)
            {
                operations.DeleteAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to get the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            public static VirtualMachineExtension Get(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> GetAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to get all extensions of an instance in Virtual Machine
            /// Scaleset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            public static VirtualMachineExtensionsListResult List(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string expand = default(string))
            {
                return operations.ListAsync(resourceGroupName, vmScaleSetName, instanceId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get all extensions of an instance in Virtual Machine
            /// Scaleset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtensionsListResult> ListAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension BeginCreateOrUpdate(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtension extensionParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> BeginCreateOrUpdateAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension BeginUpdate(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> BeginUpdateAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            public static void BeginDelete(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the VMSS VM extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualMachineScaleSetVMExtensionsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
