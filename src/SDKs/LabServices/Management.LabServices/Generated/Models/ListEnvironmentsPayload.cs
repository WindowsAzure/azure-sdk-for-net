// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the payload to list environments owned by a user
    /// </summary>
    public partial class ListEnvironmentsPayload
    {
        /// <summary>
        /// Initializes a new instance of the ListEnvironmentsPayload class.
        /// </summary>
        public ListEnvironmentsPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListEnvironmentsPayload class.
        /// </summary>
        /// <param name="labId">The resource Id of the lab</param>
        public ListEnvironmentsPayload(string labId = default(string))
        {
            LabId = labId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource Id of the lab
        /// </summary>
        [JsonProperty(PropertyName = "labId")]
        public string LabId { get; set; }

    }
}
