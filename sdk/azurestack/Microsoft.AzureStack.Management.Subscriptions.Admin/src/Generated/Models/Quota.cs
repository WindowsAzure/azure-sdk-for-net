// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Quotas for DelegatedProviders.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Quota : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Quota class.
        /// </summary>
        public Quota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Quota class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location of the resource</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="allowCustomPortalBranding">Value indicating whether
        /// custom portal branding is allowed.</param>
        public Quota(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? allowCustomPortalBranding = default(bool?))
            : base(id, name, type, location, tags)
        {
            AllowCustomPortalBranding = allowCustomPortalBranding;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value indicating whether custom portal branding is
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowCustomPortalBranding")]
        public bool? AllowCustomPortalBranding { get; set; }

    }
}
