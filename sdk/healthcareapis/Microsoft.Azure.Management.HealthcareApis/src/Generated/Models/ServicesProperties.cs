// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a service instance.
    /// </summary>
    public partial class ServicesProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServicesProperties class.
        /// </summary>
        public ServicesProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicesProperties class.
        /// </summary>
        /// <param name="accessPolicies">The access policies of the service
        /// instance.</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Deleting', 'Succeeded', 'Creating', 'Accepted',
        /// 'Verifying', 'Updating', 'Failed', 'Canceled',
        /// 'Deprovisioned'</param>
        /// <param name="cosmosDbConfiguration">The settings for the Cosmos DB
        /// database backing the service.</param>
        /// <param name="authenticationConfiguration">The authentication
        /// configuration for the service instance.</param>
        /// <param name="corsConfiguration">The settings for the CORS
        /// configuration of the service instance.</param>
        public ServicesProperties(IList<ServiceAccessPolicyEntry> accessPolicies, string provisioningState = default(string), ServiceCosmosDbConfigurationInfo cosmosDbConfiguration = default(ServiceCosmosDbConfigurationInfo), ServiceAuthenticationConfigurationInfo authenticationConfiguration = default(ServiceAuthenticationConfigurationInfo), ServiceCorsConfigurationInfo corsConfiguration = default(ServiceCorsConfigurationInfo))
        {
            ProvisioningState = provisioningState;
            AccessPolicies = accessPolicies;
            CosmosDbConfiguration = cosmosDbConfiguration;
            AuthenticationConfiguration = authenticationConfiguration;
            CorsConfiguration = corsConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state. Possible values include: 'Deleting',
        /// 'Succeeded', 'Creating', 'Accepted', 'Verifying', 'Updating',
        /// 'Failed', 'Canceled', 'Deprovisioned'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the access policies of the service instance.
        /// </summary>
        [JsonProperty(PropertyName = "accessPolicies")]
        public IList<ServiceAccessPolicyEntry> AccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets the settings for the Cosmos DB database backing the
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "cosmosDbConfiguration")]
        public ServiceCosmosDbConfigurationInfo CosmosDbConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the authentication configuration for the service
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "authenticationConfiguration")]
        public ServiceAuthenticationConfigurationInfo AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the settings for the CORS configuration of the service
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "corsConfiguration")]
        public ServiceCorsConfigurationInfo CorsConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccessPolicies == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessPolicies");
            }
            if (AccessPolicies != null)
            {
                foreach (var element in AccessPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (CosmosDbConfiguration != null)
            {
                CosmosDbConfiguration.Validate();
            }
            if (CorsConfiguration != null)
            {
                CorsConfiguration.Validate();
            }
        }
    }
}
