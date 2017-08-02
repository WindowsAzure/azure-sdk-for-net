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
    using System.Linq;

    /// <summary>
    /// Profile for diagnostics on the container service VMs.
    /// </summary>
    public partial class ContainerServiceVMDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceVMDiagnostics
        /// class.
        /// </summary>
        public ContainerServiceVMDiagnostics()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceVMDiagnostics
        /// class.
        /// </summary>
        /// <param name="enabled">Whether the VM diagnostic agent is
        /// provisioned on the VM.</param>
        /// <param name="storageUri">The URI of the storage account where
        /// diagnostics are stored.</param>
        public ContainerServiceVMDiagnostics(bool enabled, string storageUri = default(string))
        {
            Enabled = enabled;
            StorageUri = storageUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the VM diagnostic agent is provisioned on the
        /// VM.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets the URI of the storage account where diagnostics are stored.
        /// </summary>
        [JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
