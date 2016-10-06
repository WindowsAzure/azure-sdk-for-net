// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Extension Image.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineExtensionImageInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionImageInner class.
        /// </summary>
        public VirtualMachineExtensionImageInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionImageInner class.
        /// </summary>
        /// <param name="operatingSystem">the operating system this extension
        /// supports.</param>
        /// <param name="computeRole">the type of role (IaaS or PaaS) this
        /// extension supports.</param>
        /// <param name="handlerSchema">the schema defined by publisher, where
        /// extension consumers should provide settings in a matching
        /// schema.</param>
        /// <param name="vmScaleSetEnabled">whether the extension can be used
        /// on xRP VMScaleSets.By default existing extensions are usable on
        /// scalesets, but there might be cases where a publisher wants to
        /// explicitly indicate the extension is only enabled for CRP VMs but
        /// not VMSS.</param>
        /// <param name="supportsMultipleExtensions">whether the handler can
        /// support multiple extensions.</param>
        public VirtualMachineExtensionImageInner(string operatingSystem, string computeRole, string handlerSchema, string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), bool? vmScaleSetEnabled = default(bool?), bool? supportsMultipleExtensions = default(bool?))
            : base(location, id, name, type, tags)
        {
            OperatingSystem = operatingSystem;
            ComputeRole = computeRole;
            HandlerSchema = handlerSchema;
            VmScaleSetEnabled = vmScaleSetEnabled;
            SupportsMultipleExtensions = supportsMultipleExtensions;
        }

        /// <summary>
        /// Gets or sets the operating system this extension supports.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.operatingSystem")]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets the type of role (IaaS or PaaS) this extension
        /// supports.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.computeRole")]
        public string ComputeRole { get; set; }

        /// <summary>
        /// Gets or sets the schema defined by publisher, where extension
        /// consumers should provide settings in a matching schema.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.handlerSchema")]
        public string HandlerSchema { get; set; }

        /// <summary>
        /// Gets or sets whether the extension can be used on xRP
        /// VMScaleSets.By default existing extensions are usable on
        /// scalesets, but there might be cases where a publisher wants to
        /// explicitly indicate the extension is only enabled for CRP VMs but
        /// not VMSS.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vmScaleSetEnabled")]
        public bool? VmScaleSetEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether the handler can support multiple extensions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.supportsMultipleExtensions")]
        public bool? SupportsMultipleExtensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (OperatingSystem == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "OperatingSystem");
            }
            if (ComputeRole == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ComputeRole");
            }
            if (HandlerSchema == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "HandlerSchema");
            }
        }
    }
}
