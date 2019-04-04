// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using System.Linq;

    /// <summary>
    /// The status of a blueprint assignment. This field is readonly.
    /// </summary>
    public partial class AssignmentStatus : BlueprintResourceStatusBase
    {
        /// <summary>
        /// Initializes a new instance of the AssignmentStatus class.
        /// </summary>
        public AssignmentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssignmentStatus class.
        /// </summary>
        /// <param name="timeCreated">Creation time of this blueprint
        /// definition.</param>
        /// <param name="lastModified">Last modified time of this blueprint
        /// definition.</param>
        public AssignmentStatus(string timeCreated = default(string), string lastModified = default(string))
            : base(timeCreated, lastModified)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
