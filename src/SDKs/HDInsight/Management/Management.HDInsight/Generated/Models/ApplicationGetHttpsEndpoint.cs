// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Gets the application HTTP endpoints.
    /// </summary>
    public partial class ApplicationGetHttpsEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGetHttpsEndpoint
        /// class.
        /// </summary>
        public ApplicationGetHttpsEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGetHttpsEndpoint
        /// class.
        /// </summary>
        /// <param name="accessModes">The list of access modes for the
        /// application.</param>
        /// <param name="location">The location of the endpoint.</param>
        /// <param name="destinationPort">The destination port to connect
        /// to.</param>
        /// <param name="publicPort">The public port to connect to.</param>
        public ApplicationGetHttpsEndpoint(IList<string> accessModes = default(IList<string>), string location = default(string), int? destinationPort = default(int?), int? publicPort = default(int?))
        {
            AccessModes = accessModes;
            Location = location;
            DestinationPort = destinationPort;
            PublicPort = publicPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of access modes for the application.
        /// </summary>
        [JsonProperty(PropertyName = "accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        /// Gets or sets the location of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the destination port to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPort")]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Gets or sets the public port to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "publicPort")]
        public int? PublicPort { get; set; }

    }
}
