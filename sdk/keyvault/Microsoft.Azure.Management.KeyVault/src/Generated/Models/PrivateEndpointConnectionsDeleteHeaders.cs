// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class PrivateEndpointConnectionsDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionsDeleteHeaders class.
        /// </summary>
        public PrivateEndpointConnectionsDeleteHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionsDeleteHeaders class.
        /// </summary>
        /// <param name="retryAfter">The recommended number of seconds to wait
        /// before calling the URI specified in the location header.</param>
        /// <param name="location">The URI to poll for completion
        /// status.</param>
        public PrivateEndpointConnectionsDeleteHeaders(int? retryAfter = default(int?), string location = default(string))
        {
            RetryAfter = retryAfter;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recommended number of seconds to wait before
        /// calling the URI specified in the location header.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

        /// <summary>
        /// Gets or sets the URI to poll for completion status.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
