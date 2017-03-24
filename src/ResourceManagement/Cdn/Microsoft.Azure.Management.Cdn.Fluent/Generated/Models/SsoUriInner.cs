// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Microsoft.Azure.Management.Cdn.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSO URI required to login to the supplemental portal.
    /// </summary>
    public partial class SsoUriInner
    {
        /// <summary>
        /// Initializes a new instance of the SsoUriInner class.
        /// </summary>
        public SsoUriInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SsoUriInner class.
        /// </summary>
        /// <param name="ssoUriValue">The URI used to login to the supplemental
        /// portal.</param>
        public SsoUriInner(string ssoUriValue = default(string))
        {
            SsoUriValue = ssoUriValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI used to login to the supplemental portal.
        /// </summary>
        [JsonProperty(PropertyName = "ssoUriValue")]
        public string SsoUriValue { get; set; }

    }
}
