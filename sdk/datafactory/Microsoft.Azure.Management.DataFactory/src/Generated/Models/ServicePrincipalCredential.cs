// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service principal credential.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServicePrincipal")]
    [Rest.Serialization.JsonTransformation]
    public partial class ServicePrincipalCredential : Credential
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalCredential class.
        /// </summary>
        public ServicePrincipalCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalCredential class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Credential description.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Credential.</param>
        /// <param name="servicePrincipalId">The app ID of the service
        /// principal used to authenticate</param>
        /// <param name="servicePrincipalKey">The key of the service principal
        /// used to authenticate.</param>
        /// <param name="tenant">The ID of the tenant to which the service
        /// principal belongs</param>
        public ServicePrincipalCredential(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<object> annotations = default(IList<object>), object servicePrincipalId = default(object), AzureKeyVaultSecretReference servicePrincipalKey = default(AzureKeyVaultSecretReference), object tenant = default(object))
            : base(additionalProperties, description, annotations)
        {
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the app ID of the service principal used to
        /// authenticate
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public AzureKeyVaultSecretReference ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the ID of the tenant to which the service principal
        /// belongs
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServicePrincipalKey != null)
            {
                ServicePrincipalKey.Validate();
            }
        }
    }
}
