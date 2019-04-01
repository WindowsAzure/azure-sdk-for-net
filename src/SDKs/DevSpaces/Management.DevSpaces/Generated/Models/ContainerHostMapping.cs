// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevSpaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container host mapping object specifying the Container host resource ID
    /// and its associated Controller resource.
    /// </summary>
    public partial class ContainerHostMapping
    {
        /// <summary>
        /// Initializes a new instance of the ContainerHostMapping class.
        /// </summary>
        public ContainerHostMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerHostMapping class.
        /// </summary>
        /// <param name="containerHostResourceId">ARM ID of the Container Host
        /// resource</param>
        /// <param name="mappedControllerResourceId">ARM ID of the mapped
        /// Controller resource</param>
        public ContainerHostMapping(string containerHostResourceId = default(string), string mappedControllerResourceId = default(string))
        {
            ContainerHostResourceId = containerHostResourceId;
            MappedControllerResourceId = mappedControllerResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM ID of the Container Host resource
        /// </summary>
        [JsonProperty(PropertyName = "containerHostResourceId")]
        public string ContainerHostResourceId { get; set; }

        /// <summary>
        /// Gets ARM ID of the mapped Controller resource
        /// </summary>
        [JsonProperty(PropertyName = "mappedControllerResourceId")]
        public string MappedControllerResourceId { get; private set; }

    }
}
