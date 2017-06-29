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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The ssh username, password, and ssh public key.
    /// </summary>
    public partial class LinuxOperatingSystemProfile
    {
        /// <summary>
        /// Initializes a new instance of the LinuxOperatingSystemProfile
        /// class.
        /// </summary>
        public LinuxOperatingSystemProfile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinuxOperatingSystemProfile
        /// class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="sshProfile">The SSH profile.</param>
        public LinuxOperatingSystemProfile(string username = default(string), string password = default(string), SshProfile sshProfile = default(SshProfile))
        {
            Username = username;
            Password = password;
            SshProfile = sshProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the SSH profile.
        /// </summary>
        [JsonProperty(PropertyName = "sshProfile")]
        public SshProfile SshProfile { get; set; }

    }
}
