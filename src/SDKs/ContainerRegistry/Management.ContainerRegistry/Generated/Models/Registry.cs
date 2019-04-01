// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object that represents a container registry.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Registry : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Registry class.
        /// </summary>
        public Registry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Registry class.
        /// </summary>
        /// <param name="location">The location of the resource. This cannot be
        /// changed after the resource is created.</param>
        /// <param name="sku">The SKU of the container registry.</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="loginServer">The URL that can be used to log into the
        /// container registry.</param>
        /// <param name="creationDate">The creation date of the container
        /// registry in ISO8601 format.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// container registry at the time the operation was called. Possible
        /// values include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Canceled'</param>
        /// <param name="status">The status of the container registry at the
        /// time the operation was called.</param>
        /// <param name="adminUserEnabled">The value that indicates whether the
        /// admin user is enabled.</param>
        /// <param name="storageAccount">The properties of the storage account
        /// for the container registry. Only applicable to Classic SKU.</param>
        /// <param name="networkRuleSet">The network rule set for a container
        /// registry.</param>
        public Registry(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string loginServer = default(string), System.DateTime? creationDate = default(System.DateTime?), string provisioningState = default(string), Status status = default(Status), bool? adminUserEnabled = default(bool?), StorageAccountProperties storageAccount = default(StorageAccountProperties), NetworkRuleSet networkRuleSet = default(NetworkRuleSet))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            LoginServer = loginServer;
            CreationDate = creationDate;
            ProvisioningState = provisioningState;
            Status = status;
            AdminUserEnabled = adminUserEnabled;
            StorageAccount = storageAccount;
            NetworkRuleSet = networkRuleSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets the URL that can be used to log into the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loginServer")]
        public string LoginServer { get; private set; }

        /// <summary>
        /// Gets the creation date of the container registry in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the container registry at the time
        /// the operation was called. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the container registry at the time the operation
        /// was called.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public Status Status { get; private set; }

        /// <summary>
        /// Gets or sets the value that indicates whether the admin user is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminUserEnabled")]
        public bool? AdminUserEnabled { get; set; }

        /// <summary>
        /// Gets or sets the properties of the storage account for the
        /// container registry. Only applicable to Classic SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccount")]
        public StorageAccountProperties StorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the network rule set for a container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkRuleSet")]
        public NetworkRuleSet NetworkRuleSet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (StorageAccount != null)
            {
                StorageAccount.Validate();
            }
            if (NetworkRuleSet != null)
            {
                NetworkRuleSet.Validate();
            }
        }
    }
}
