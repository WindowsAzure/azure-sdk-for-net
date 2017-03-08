// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The integration account map.
    /// </summary>
    [JsonTransformation]
    public partial class IntegrationAccountMap : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountMap class.
        /// </summary>
        public IntegrationAccountMap() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountMap class.
        /// </summary>
        /// <param name="mapType">The map type. Possible values include:
        /// 'NotSpecified', 'Xslt'</param>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="parametersSchema">The parameters schema of integration
        /// account map.</param>
        /// <param name="createdTime">The created time.</param>
        /// <param name="changedTime">The changed time.</param>
        /// <param name="content">The content.</param>
        /// <param name="contentType">The content type.</param>
        /// <param name="contentLink">The content link.</param>
        /// <param name="metadata">The metadata.</param>
        public IntegrationAccountMap(MapType mapType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IntegrationAccountMapPropertiesParametersSchema parametersSchema = default(IntegrationAccountMapPropertiesParametersSchema), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), object content = default(object), string contentType = default(string), ContentLink contentLink = default(ContentLink), object metadata = default(object))
            : base(id, name, type, location, tags)
        {
            MapType = mapType;
            ParametersSchema = parametersSchema;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Content = content;
            ContentType = contentType;
            ContentLink = contentLink;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the map type. Possible values include: 'NotSpecified',
        /// 'Xslt'
        /// </summary>
        [JsonProperty(PropertyName = "properties.mapType")]
        public MapType MapType { get; set; }

        /// <summary>
        /// Gets or sets the parameters schema of integration account map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parametersSchema")]
        public IntegrationAccountMapPropertiesParametersSchema ParametersSchema { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; protected set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public System.DateTime? ChangedTime { get; protected set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public object Content { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets the content link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentLink")]
        public ContentLink ContentLink { get; protected set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}

