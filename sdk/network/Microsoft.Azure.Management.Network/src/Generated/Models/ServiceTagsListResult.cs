// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response for the ListServiceTags API service call.
    /// </summary>
    public partial class ServiceTagsListResult
    {
        /// <summary>
        /// Initializes a new instance of the ServiceTagsListResult class.
        /// </summary>
        public ServiceTagsListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceTagsListResult class.
        /// </summary>
        /// <param name="name">The name of the cloud.</param>
        /// <param name="id">The ID of the cloud.</param>
        /// <param name="type">The azure resource type.</param>
        /// <param name="changeNumber">The iteration number.</param>
        /// <param name="cloud">The name of the cloud.</param>
        /// <param name="values">The list of service tag information
        /// resources.</param>
        /// <param name="nextLink">The URL to get next page of service tag
        /// information resources.</param>
        public ServiceTagsListResult(string name = default(string), string id = default(string), string type = default(string), string changeNumber = default(string), string cloud = default(string), IList<ServiceTagInformation> values = default(IList<ServiceTagInformation>), string nextLink = default(string))
        {
            Name = name;
            Id = id;
            Type = type;
            ChangeNumber = changeNumber;
            Cloud = cloud;
            Values = values;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the cloud.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of the cloud.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the azure resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the iteration number.
        /// </summary>
        [JsonProperty(PropertyName = "changeNumber")]
        public string ChangeNumber { get; private set; }

        /// <summary>
        /// Gets the name of the cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud")]
        public string Cloud { get; private set; }

        /// <summary>
        /// Gets the list of service tag information resources.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<ServiceTagInformation> Values { get; private set; }

        /// <summary>
        /// Gets the URL to get next page of service tag information resources.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
