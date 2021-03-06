// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of available versions for an agent pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AgentPoolAvailableVersions
    {
        /// <summary>
        /// Initializes a new instance of the AgentPoolAvailableVersions class.
        /// </summary>
        public AgentPoolAvailableVersions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentPoolAvailableVersions class.
        /// </summary>
        /// <param name="id">The ID of the agent pool version list.</param>
        /// <param name="name">The name of the agent pool version list.</param>
        /// <param name="type">Type of the agent pool version list.</param>
        /// <param name="agentPoolVersions">List of versions available for
        /// agent pool.</param>
        public AgentPoolAvailableVersions(string id = default(string), string name = default(string), string type = default(string), IList<AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem> agentPoolVersions = default(IList<AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem>))
        {
            Id = id;
            Name = name;
            Type = type;
            AgentPoolVersions = agentPoolVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the agent pool version list.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the agent pool version list.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of the agent pool version list.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets list of versions available for agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolVersions")]
        public IList<AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem> AgentPoolVersions { get; set; }

    }
}
