// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight.Models
{
    using Microsoft.HDInsight;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The RDP settings for the windows cluster.
    /// </summary>
    public partial class RdpSettings
    {
        /// <summary>
        /// Initializes a new instance of the RdpSettings class.
        /// </summary>
        public RdpSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RdpSettings class.
        /// </summary>
        /// <param name="username">The username for the RDP user.</param>
        /// <param name="password">The password for the RDP user.</param>
        /// <param name="expiryDate">The RDP expiry date(YYYY-MM-DD).</param>
        public RdpSettings(string username = default(string), string password = default(string), System.DateTime? expiryDate = default(System.DateTime?))
        {
            Username = username;
            Password = password;
            ExpiryDate = expiryDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the username for the RDP user.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password for the RDP user.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the RDP expiry date(YYYY-MM-DD).
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "expiryDate")]
        public System.DateTime? ExpiryDate { get; set; }

    }
}
