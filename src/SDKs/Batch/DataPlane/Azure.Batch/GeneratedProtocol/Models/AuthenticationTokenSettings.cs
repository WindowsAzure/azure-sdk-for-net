// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The settings for an authentication token that the task can use to
    /// perform Batch service operations.
    /// </summary>
    public partial class AuthenticationTokenSettings
    {
        /// <summary>
        /// Initializes a new instance of the AuthenticationTokenSettings
        /// class.
        /// </summary>
        public AuthenticationTokenSettings() { }

        /// <summary>
        /// Initializes a new instance of the AuthenticationTokenSettings
        /// class.
        /// </summary>
        /// <param name="access">The Batch resources to which the token grants
        /// access.</param>
        public AuthenticationTokenSettings(System.Collections.Generic.IList<AccessScope> access = default(System.Collections.Generic.IList<AccessScope>))
        {
            Access = access;
        }

        /// <summary>
        /// Gets or sets the Batch resources to which the token grants access.
        /// </summary>
        /// <remarks>
        /// The authentication token grants access to a limited set of Batch
        /// service operations. Currently the only supported value for the
        /// access property is 'job', which grants access to all operations
        /// related to the job which contains the task.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "access")]
        public System.Collections.Generic.IList<AccessScope> Access { get; set; }

    }
}
