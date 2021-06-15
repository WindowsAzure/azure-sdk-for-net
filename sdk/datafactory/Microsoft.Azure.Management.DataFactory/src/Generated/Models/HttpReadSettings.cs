// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sftp read settings.
    /// </summary>
    public partial class HttpReadSettings : StoreReadSettings
    {
        /// <summary>
        /// Initializes a new instance of the HttpReadSettings class.
        /// </summary>
        public HttpReadSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpReadSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="disableMetricsCollection">If true, disable data store
        /// metrics collection. Default is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="requestMethod">The HTTP method used to call the
        /// RESTful API. The default is GET. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="requestBody">The HTTP request body to the RESTful API
        /// if requestMethod is POST. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="additionalHeaders">The additional HTTP headers in the
        /// request to the RESTful API. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="requestTimeout">Specifies the timeout for a HTTP
        /// client to get HTTP response from HTTP server.</param>
        /// <param name="enablePartitionDiscovery">Indicates whether to enable
        /// partition discovery.</param>
        /// <param name="partitionRootPath">Specify the root path where
        /// partition discovery starts from. Type: string (or Expression with
        /// resultType string).</param>
        public HttpReadSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object requestMethod = default(object), object requestBody = default(object), object additionalHeaders = default(object), object requestTimeout = default(object), bool? enablePartitionDiscovery = default(bool?), object partitionRootPath = default(object))
            : base(additionalProperties, maxConcurrentConnections, disableMetricsCollection)
        {
            RequestMethod = requestMethod;
            RequestBody = requestBody;
            AdditionalHeaders = additionalHeaders;
            RequestTimeout = requestTimeout;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the HTTP method used to call the RESTful API. The
        /// default is GET. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "requestMethod")]
        public object RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request body to the RESTful API if
        /// requestMethod is POST. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "requestBody")]
        public object RequestBody { get; set; }

        /// <summary>
        /// Gets or sets the additional HTTP headers in the request to the
        /// RESTful API. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "additionalHeaders")]
        public object AdditionalHeaders { get; set; }

        /// <summary>
        /// Gets or sets specifies the timeout for a HTTP client to get HTTP
        /// response from HTTP server.
        /// </summary>
        [JsonProperty(PropertyName = "requestTimeout")]
        public object RequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets indicates whether to enable partition discovery.
        /// </summary>
        [JsonProperty(PropertyName = "enablePartitionDiscovery")]
        public bool? EnablePartitionDiscovery { get; set; }

        /// <summary>
        /// Gets or sets specify the root path where partition discovery starts
        /// from. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "partitionRootPath")]
        public object PartitionRootPath { get; set; }

    }
}
