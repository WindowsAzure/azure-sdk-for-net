// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Core
{
    /// <summary> The details of a management group used during creation. </summary>
    public partial class CreateManagementGroupDetails
    {
        /// <summary> Initializes a new instance of CreateManagementGroupDetails. </summary>
        public CreateManagementGroupDetails()
        {
        }

        /// <summary> The version number of the object. </summary>
        public int? Version { get; }
        /// <summary> The date and time when this object was last updated. </summary>
        public DateTimeOffset? UpdatedTime { get; }
        /// <summary> The identity of the principal or process that updated the object. </summary>
        public string UpdatedBy { get; }
        /// <summary> (Optional) The ID of the parent management group used during creation. </summary>
        public CreateParentGroupInfo Parent { get; set; }
    }
}
