// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Certificate signing request object
    /// </summary>
    public partial class Csr : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Csr class.
        /// </summary>
        public Csr() { }

        /// <summary>
        /// Initializes a new instance of the Csr class.
        /// </summary>
        public Csr(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string csrName = default(string), string distinguishedName = default(string), string csrString = default(string), string pfxBlob = default(string), string password = default(string), string publicKeyHash = default(string), string hostingEnvironment = default(string))
            : base(location, id, name, kind, type, tags)
        {
            CsrName = csrName;
            DistinguishedName = distinguishedName;
            CsrString = csrString;
            PfxBlob = pfxBlob;
            Password = password;
            PublicKeyHash = publicKeyHash;
            HostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Name used to locate CSR object
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string CsrName { get; set; }

        /// <summary>
        /// Distinguished name of certificate to be created
        /// </summary>
        [JsonProperty(PropertyName = "properties.distinguishedName")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Actual CSR string created
        /// </summary>
        [JsonProperty(PropertyName = "properties.csrString")]
        public string CsrString { get; set; }

        /// <summary>
        /// PFX certifcate of created certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.pfxBlob")]
        public string PfxBlob { get; set; }

        /// <summary>
        /// PFX password
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Hash of the certificates public key
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicKeyHash")]
        public string PublicKeyHash { get; set; }

        /// <summary>
        /// Hosting environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingEnvironment")]
        public string HostingEnvironment { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
