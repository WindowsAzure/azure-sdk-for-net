// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Actions are applied to the filtered blobs when the execution condition
    /// is met.
    /// </summary>
    public partial class ManagementPolicyAction
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicyAction class.
        /// </summary>
        public ManagementPolicyAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicyAction class.
        /// </summary>
        /// <param name="baseBlob">The management policy action for base
        /// blob</param>
        /// <param name="snapshot">The management policy action for
        /// snapshot</param>
        public ManagementPolicyAction(ManagementPolicyBaseBlob baseBlob = default(ManagementPolicyBaseBlob), ManagementPolicySnapShot snapshot = default(ManagementPolicySnapShot))
        {
            BaseBlob = baseBlob;
            Snapshot = snapshot;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the management policy action for base blob
        /// </summary>
        [JsonProperty(PropertyName = "baseBlob")]
        public ManagementPolicyBaseBlob BaseBlob { get; set; }

        /// <summary>
        /// Gets or sets the management policy action for snapshot
        /// </summary>
        [JsonProperty(PropertyName = "snapshot")]
        public ManagementPolicySnapShot Snapshot { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BaseBlob != null)
            {
                BaseBlob.Validate();
            }
            if (Snapshot != null)
            {
                Snapshot.Validate();
            }
        }
    }
}
