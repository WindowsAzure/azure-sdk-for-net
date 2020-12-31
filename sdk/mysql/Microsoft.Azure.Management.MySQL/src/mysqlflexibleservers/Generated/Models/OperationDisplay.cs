// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Display metadata associated with the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Operation resource provider name.</param>
        /// <param name="resource">Resource on which the operation is
        /// performed.</param>
        /// <param name="operation">Localized friendly name for the
        /// operation.</param>
        /// <param name="description">Operation description.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets operation resource provider name.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; private set; }

        /// <summary>
        /// Gets resource on which the operation is performed.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; private set; }

        /// <summary>
        /// Gets localized friendly name for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; private set; }

        /// <summary>
        /// Gets operation description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

    }
}
