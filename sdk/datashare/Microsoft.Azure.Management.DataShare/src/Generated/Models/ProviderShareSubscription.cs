// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A provider side share subscription data transfer object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProviderShareSubscription : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the ProviderShareSubscription class.
        /// </summary>
        public ProviderShareSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderShareSubscription class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="company">Company name</param>
        /// <param name="createdAt">created at</param>
        /// <param name="createdBy">Created by</param>
        /// <param name="sharedAt">Shared at</param>
        /// <param name="sharedBy">Shared by</param>
        /// <param name="shareSubscriptionObjectId">share Subscription Object
        /// Id</param>
        /// <param name="shareSubscriptionStatus">Gets the status of share
        /// subscription. Possible values include: 'Active', 'Revoked',
        /// 'SourceDeleted', 'Revoking'</param>
        public ProviderShareSubscription(string id = default(string), string name = default(string), string type = default(string), string company = default(string), System.DateTime? createdAt = default(System.DateTime?), string createdBy = default(string), System.DateTime? sharedAt = default(System.DateTime?), string sharedBy = default(string), string shareSubscriptionObjectId = default(string), string shareSubscriptionStatus = default(string))
            : base(id, name, type)
        {
            Company = company;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            SharedAt = sharedAt;
            SharedBy = sharedBy;
            ShareSubscriptionObjectId = shareSubscriptionObjectId;
            ShareSubscriptionStatus = shareSubscriptionStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets company name
        /// </summary>
        [JsonProperty(PropertyName = "properties.company")]
        public string Company { get; private set; }

        /// <summary>
        /// Gets created at
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets created by
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdBy")]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Gets shared at
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedAt")]
        public System.DateTime? SharedAt { get; private set; }

        /// <summary>
        /// Gets shared by
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedBy")]
        public string SharedBy { get; private set; }

        /// <summary>
        /// Gets share Subscription Object Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareSubscriptionObjectId")]
        public string ShareSubscriptionObjectId { get; private set; }

        /// <summary>
        /// Gets the status of share subscription. Possible values include:
        /// 'Active', 'Revoked', 'SourceDeleted', 'Revoking'
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareSubscriptionStatus")]
        public string ShareSubscriptionStatus { get; private set; }

    }
}
