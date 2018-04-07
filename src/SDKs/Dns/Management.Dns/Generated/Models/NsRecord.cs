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
    /// An NS record.
    /// </summary>
    public partial class NsRecord
    {
        /// <summary>
        /// Initializes a new instance of the NsRecord class.
        /// </summary>
        public NsRecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NsRecord class.
        /// </summary>
        /// <param name="nsdname">The name server name for this NS
        /// record.</param>
        public NsRecord(string nsdname = default(string))
        {
            Nsdname = nsdname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name server name for this NS record.
        /// </summary>
        [JsonProperty(PropertyName = "nsdname")]
        public string Nsdname { get; set; }

    }
}
