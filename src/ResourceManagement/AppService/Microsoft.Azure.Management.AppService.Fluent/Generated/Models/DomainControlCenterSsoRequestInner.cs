// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Single sign-on request information for domain management.
    /// </summary>
    public partial class DomainControlCenterSsoRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DomainControlCenterSsoRequestInner class.
        /// </summary>
        public DomainControlCenterSsoRequestInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DomainControlCenterSsoRequestInner class.
        /// </summary>
        /// <param name="url">URL where the single sign-on request is to be
        /// made.</param>
        /// <param name="postParameterKey">Post parameter key.</param>
        /// <param name="postParameterValue">Post parameter value. Client
        /// should use 'application/x-www-form-urlencoded' encoding for this
        /// value.</param>
        public DomainControlCenterSsoRequestInner(string url = default(string), string postParameterKey = default(string), string postParameterValue = default(string))
        {
            Url = url;
            PostParameterKey = postParameterKey;
            PostParameterValue = postParameterValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets URL where the single sign-on request is to be made.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets post parameter key.
        /// </summary>
        [JsonProperty(PropertyName = "postParameterKey")]
        public string PostParameterKey { get; private set; }

        /// <summary>
        /// Gets post parameter value. Client should use
        /// 'application/x-www-form-urlencoded' encoding for this value.
        /// </summary>
        [JsonProperty(PropertyName = "postParameterValue")]
        public string PostParameterValue { get; private set; }

    }
}
