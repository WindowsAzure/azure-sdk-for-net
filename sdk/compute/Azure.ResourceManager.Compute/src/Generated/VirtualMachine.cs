// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a VirtualMachine along with the instance operations that can be performed on it. </summary>
    public class VirtualMachine : VirtualMachineOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "VirtualMachine"/> class for mocking. </summary>
        internal VirtualMachine() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualMachine"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VirtualMachine(OperationsBase options, VirtualMachineData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the VirtualMachineData. </summary>
        public VirtualMachineData Data { get; private set; }
    }
}
