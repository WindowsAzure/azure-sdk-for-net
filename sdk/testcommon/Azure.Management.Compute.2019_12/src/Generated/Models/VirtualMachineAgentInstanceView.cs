// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> The instance view of the VM Agent running on the virtual machine. </summary>
    public partial class VirtualMachineAgentInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineAgentInstanceView. </summary>
        public VirtualMachineAgentInstanceView()
        {
            ExtensionHandlers = new ChangeTrackingList<VirtualMachineExtensionHandlerInstanceView>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of VirtualMachineAgentInstanceView. </summary>
        /// <param name="vmAgentVersion"> The VM Agent full version. </param>
        /// <param name="extensionHandlers"> The virtual machine extension handler instance view. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal VirtualMachineAgentInstanceView(string vmAgentVersion, IList<VirtualMachineExtensionHandlerInstanceView> extensionHandlers, IList<InstanceViewStatus> statuses)
        {
            VmAgentVersion = vmAgentVersion;
            ExtensionHandlers = extensionHandlers;
            Statuses = statuses;
        }

        /// <summary> The VM Agent full version. </summary>
        public string VmAgentVersion { get; set; }
        /// <summary> The virtual machine extension handler instance view. </summary>
        public IList<VirtualMachineExtensionHandlerInstanceView> ExtensionHandlers { get; }
        /// <summary> The resource status information. </summary>
        public IList<InstanceViewStatus> Statuses { get; }
    }
}
