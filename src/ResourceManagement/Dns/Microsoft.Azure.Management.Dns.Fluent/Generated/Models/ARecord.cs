// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// An A record.
    /// </summary>
    public partial class ARecord
    {
        /// <summary>
        /// Initializes a new instance of the ARecord class.
        /// </summary>
        public ARecord() { }

        /// <summary>
        /// Initializes a new instance of the ARecord class.
        /// </summary>
        /// <param name="ipv4Address">The IPv4 address of this A
        /// record.</param>
        public ARecord(string ipv4Address = default(string))
        {
            Ipv4Address = ipv4Address;
        }

        /// <summary>
        /// Gets or sets the IPv4 address of this A record.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipv4Address")]
        public string Ipv4Address { get; set; }

    }
}
