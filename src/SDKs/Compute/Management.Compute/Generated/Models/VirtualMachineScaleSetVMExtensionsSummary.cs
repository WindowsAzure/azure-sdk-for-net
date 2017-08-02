// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extensions summary for virtual machines of a virtual machine scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetVMExtensionsSummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMExtensionsSummary class.
        /// </summary>
        public VirtualMachineScaleSetVMExtensionsSummary()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMExtensionsSummary class.
        /// </summary>
        /// <param name="name">The extension name.</param>
        /// <param name="statusesSummary">The extensions information.</param>
        public VirtualMachineScaleSetVMExtensionsSummary(string name = default(string), IList<VirtualMachineStatusCodeCount> statusesSummary = default(IList<VirtualMachineStatusCodeCount>))
        {
            Name = name;
            StatusesSummary = statusesSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the extension name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "statusesSummary")]
        public IList<VirtualMachineStatusCodeCount> StatusesSummary { get; private set; }

    }
}
