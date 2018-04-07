// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Dns.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An AAAA record.
    /// </summary>
    public partial class AaaaRecord
    {
        /// <summary>
        /// Initializes a new instance of the AaaaRecord class.
        /// </summary>
        public AaaaRecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AaaaRecord class.
        /// </summary>
        /// <param name="ipv6Address">The IPv6 address of this AAAA
        /// record.</param>
        public AaaaRecord(string ipv6Address = default(string))
        {
            Ipv6Address = ipv6Address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IPv6 address of this AAAA record.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6Address")]
        public string Ipv6Address { get; set; }

    }
}
