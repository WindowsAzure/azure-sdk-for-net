// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Capture Virtual Machine parameters.
    /// </summary>
    public partial class VirtualMachineCaptureParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineCaptureParametersInner class.
        /// </summary>
        public VirtualMachineCaptureParametersInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineCaptureParametersInner class.
        /// </summary>
        /// <param name="vhdPrefix">The captured virtual hard disk's name
        /// prefix.</param>
        /// <param name="destinationContainerName">The destination container
        /// name.</param>
        /// <param name="overwriteVhds">Specifies whether to overwrite the
        /// destination virtual hard disk, in case of conflict.</param>
        public VirtualMachineCaptureParametersInner(string vhdPrefix, string destinationContainerName, bool overwriteVhds)
        {
            VhdPrefix = vhdPrefix;
            DestinationContainerName = destinationContainerName;
            OverwriteVhds = overwriteVhds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the captured virtual hard disk's name prefix.
        /// </summary>
        [JsonProperty(PropertyName = "vhdPrefix")]
        public string VhdPrefix { get; set; }

        /// <summary>
        /// Gets or sets the destination container name.
        /// </summary>
        [JsonProperty(PropertyName = "destinationContainerName")]
        public string DestinationContainerName { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to overwrite the destination virtual
        /// hard disk, in case of conflict.
        /// </summary>
        [JsonProperty(PropertyName = "overwriteVhds")]
        public bool OverwriteVhds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VhdPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VhdPrefix");
            }
            if (DestinationContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationContainerName");
            }
        }
    }
}
