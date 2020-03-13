// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of Cognitive Services account.
    /// </summary>
    public partial class CognitiveServicesAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountProperties class.
        /// </summary>
        public CognitiveServicesAccountProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountProperties class.
        /// </summary>
        /// <param name="provisioningState">Gets the status of the cognitive
        /// services account at the time the operation was called. Possible
        /// values include: 'Creating', 'ResolvingDNS', 'Moving', 'Deleting',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="endpoint">Endpoint of the created account.</param>
        /// <param name="internalId">The internal identifier.</param>
        /// <param name="customSubDomainName">Optional subdomain name used for
        /// token-based authentication.</param>
        /// <param name="networkAcls">A collection of rules governing the
        /// accessibility from specific network locations.</param>
        /// <param name="encryption">The encryption properties for this
        /// resource.</param>
        /// <param name="userOwnedStorage">The storage accounts for this
        /// resource.</param>
        /// <param name="apiProperties">The api properties for special
        /// APIs.</param>
        public CognitiveServicesAccountProperties(string provisioningState = default(string), string endpoint = default(string), string internalId = default(string), string customSubDomainName = default(string), NetworkRuleSet networkAcls = default(NetworkRuleSet), Encryption encryption = default(Encryption), IList<UserOwnedStorage> userOwnedStorage = default(IList<UserOwnedStorage>), CognitiveServicesAccountApiProperties apiProperties = default(CognitiveServicesAccountApiProperties))
        {
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            InternalId = internalId;
            CustomSubDomainName = customSubDomainName;
            NetworkAcls = networkAcls;
            Encryption = encryption;
            UserOwnedStorage = userOwnedStorage;
            ApiProperties = apiProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of the cognitive services account at the time the
        /// operation was called. Possible values include: 'Creating',
        /// 'ResolvingDNS', 'Moving', 'Deleting', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets endpoint of the created account.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets the internal identifier.
        /// </summary>
        [JsonProperty(PropertyName = "internalId")]
        public string InternalId { get; private set; }

        /// <summary>
        /// Gets or sets optional subdomain name used for token-based
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "customSubDomainName")]
        public string CustomSubDomainName { get; set; }

        /// <summary>
        /// Gets or sets a collection of rules governing the accessibility from
        /// specific network locations.
        /// </summary>
        [JsonProperty(PropertyName = "networkAcls")]
        public NetworkRuleSet NetworkAcls { get; set; }

        /// <summary>
        /// Gets or sets the encryption properties for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets the storage accounts for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "userOwnedStorage")]
        public IList<UserOwnedStorage> UserOwnedStorage { get; set; }

        /// <summary>
        /// Gets or sets the api properties for special APIs.
        /// </summary>
        [JsonProperty(PropertyName = "apiProperties")]
        public CognitiveServicesAccountApiProperties ApiProperties { get; set; }

    }
}
