// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Factory resource type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Factory : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Factory class.
        /// </summary>
        public Factory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Factory class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="identity">Managed service identity of the
        /// factory.</param>
        /// <param name="provisioningState">Factory provisioning state, example
        /// Succeeded.</param>
        /// <param name="createTime">Time the factory was created in ISO8601
        /// format.</param>
        /// <param name="version">Version of the factory.</param>
        public Factory(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), FactoryIdentity identity = default(FactoryIdentity), string provisioningState = default(string), System.DateTime? createTime = default(System.DateTime?), string version = default(string))
            : base(id, name, type, location, tags)
        {
            AdditionalProperties = additionalProperties;
            Identity = identity;
            ProvisioningState = provisioningState;
            CreateTime = createTime;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets managed service identity of the factory.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public FactoryIdentity Identity { get; set; }

        /// <summary>
        /// Gets factory provisioning state, example Succeeded.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets time the factory was created in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createTime")]
        public System.DateTime? CreateTime { get; private set; }

        /// <summary>
        /// Gets version of the factory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

    }
}
