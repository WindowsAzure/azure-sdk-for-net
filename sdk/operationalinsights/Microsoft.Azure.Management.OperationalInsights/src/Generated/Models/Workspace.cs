// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level Workspace resource container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Workspace : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state of the
        /// workspace. Possible values include: 'Creating', 'Succeeded',
        /// 'Failed', 'Canceled', 'Deleting', 'ProvisioningAccount',
        /// 'Updating'</param>
        /// <param name="customerId">This is a read-only property. Represents
        /// the ID associated with the workspace.</param>
        /// <param name="sku">The SKU of the workspace.</param>
        /// <param name="retentionInDays">The workspace data retention in days.
        /// -1 means Unlimited retention for the Unlimited Sku. 730 days is the
        /// maximum allowed for all other Skus. </param>
        /// <param name="publicNetworkAccessForIngestion">The network access
        /// type for accessing Log Analytics ingestion. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="publicNetworkAccessForQuery">The network access type
        /// for accessing Log Analytics query. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="privateLinkScopedResources">List of linked private
        /// link scope resources.</param>
        /// <param name="eTag">The ETag of the workspace.</param>
        public Workspace(string provisioningState = default(string), string customerId = default(string), WorkspaceSku sku = default(WorkspaceSku), int? retentionInDays = default(int?), string publicNetworkAccessForIngestion = default(string), string publicNetworkAccessForQuery = default(string), IList<PrivateLinkScopedResource> privateLinkScopedResources = default(IList<PrivateLinkScopedResource>), string eTag = default(string))
        {
            ProvisioningState = provisioningState;
            CustomerId = customerId;
            Sku = sku;
            RetentionInDays = retentionInDays;
            PublicNetworkAccessForIngestion = publicNetworkAccessForIngestion;
            PublicNetworkAccessForQuery = publicNetworkAccessForQuery;
            PrivateLinkScopedResources = privateLinkScopedResources;
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provisioning state of the workspace. Possible
        /// values include: 'Creating', 'Succeeded', 'Failed', 'Canceled',
        /// 'Deleting', 'ProvisioningAccount', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets this is a read-only property. Represents the ID associated
        /// with the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets or sets the SKU of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public WorkspaceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the workspace data retention in days. -1 means
        /// Unlimited retention for the Unlimited Sku. 730 days is the maximum
        /// allowed for all other Skus.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets the network access type for accessing Log Analytics
        /// ingestion. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccessForIngestion")]
        public string PublicNetworkAccessForIngestion { get; set; }

        /// <summary>
        /// Gets or sets the network access type for accessing Log Analytics
        /// query. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccessForQuery")]
        public string PublicNetworkAccessForQuery { get; set; }

        /// <summary>
        /// Gets list of linked private link scope resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkScopedResources")]
        public IList<PrivateLinkScopedResource> PrivateLinkScopedResources { get; private set; }

        /// <summary>
        /// Gets or sets the ETag of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (RetentionInDays > 730)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RetentionInDays", 730);
            }
            if (RetentionInDays < -1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RetentionInDays", -1);
            }
        }
    }
}
