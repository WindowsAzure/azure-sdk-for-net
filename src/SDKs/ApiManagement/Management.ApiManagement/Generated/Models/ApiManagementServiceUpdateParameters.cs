// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameter supplied to Update Api Management Service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApiManagementServiceUpdateParameters : ApimResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceUpdateParameters class.
        /// </summary>
        public ApiManagementServiceUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceUpdateParameters class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management resource is set
        /// to Microsoft.ApiManagement.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="notificationSenderEmail">Email address from which the
        /// notification will be sent.</param>
        /// <param name="provisioningState">The current provisioning state of
        /// the API Management service which can be one of the following:
        /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.</param>
        /// <param name="targetProvisioningState">The provisioning state of the
        /// API Management service, which is targeted by the long running
        /// operation started on the service.</param>
        /// <param name="createdAtUtc">Creation UTC date of the API Management
        /// service.The date conforms to the following format:
        /// `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601
        /// standard.</param>
        /// <param name="gatewayUrl">Gateway URL of the API Management
        /// service.</param>
        /// <param name="gatewayRegionalUrl">Gateway URL of the API Management
        /// service in the Default Region.</param>
        /// <param name="portalUrl">Publisher portal endpoint Url of the API
        /// Management service.</param>
        /// <param name="managementApiUrl">Management API endpoint URL of the
        /// API Management service.</param>
        /// <param name="scmUrl">SCM endpoint URL of the API Management
        /// service.</param>
        /// <param name="hostnameConfigurations">Custom hostname configuration
        /// of the API Management service.</param>
        /// <param name="publicIPAddresses">Public Static Load Balanced IP
        /// addresses of the API Management service in Primary region.
        /// Available only for Basic, Standard and Premium SKU.</param>
        /// <param name="privateIPAddresses">Private Static Load Balanced IP
        /// addresses of the API Management service in Primary region which is
        /// deployed in an Internal Virtual Network. Available only for Basic,
        /// Standard and Premium SKU.</param>
        /// <param name="virtualNetworkConfiguration">Virtual network
        /// configuration of the API Management service.</param>
        /// <param name="additionalLocations">Additional datacenter locations
        /// of the API Management service.</param>
        /// <param name="customProperties">Custom properties of the API
        /// Management service. Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168`
        /// will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all
        /// TLS(1.0, 1.1 and 1.2). Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11`
        /// can be used to disable just TLS 1.1 and setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10`
        /// can be used to disable TLS 1.0 on an API Management
        /// service.</param>
        /// <param name="certificates">List of Certificates that need to be
        /// installed in the API Management service. Max supported certificates
        /// that can be installed is 10.</param>
        /// <param name="virtualNetworkType">The type of VPN in which API
        /// Management service needs to be configured in. None (Default Value)
        /// means the API Management service is not part of any Virtual
        /// Network, External means the API Management deployment is set up
        /// inside a Virtual Network having an Internet Facing Endpoint, and
        /// Internal means that API Management deployment is setup inside a
        /// Virtual Network having an Intranet Facing Endpoint only. Possible
        /// values include: 'None', 'External', 'Internal'</param>
        /// <param name="publisherEmail">Publisher email.</param>
        /// <param name="publisherName">Publisher name.</param>
        /// <param name="sku">SKU properties of the API Management
        /// service.</param>
        /// <param name="identity">Managed service identity of the Api
        /// Management service.</param>
        /// <param name="etag">ETag of the resource.</param>
        public ApiManagementServiceUpdateParameters(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string notificationSenderEmail = default(string), string provisioningState = default(string), string targetProvisioningState = default(string), System.DateTime? createdAtUtc = default(System.DateTime?), string gatewayUrl = default(string), string gatewayRegionalUrl = default(string), string portalUrl = default(string), string managementApiUrl = default(string), string scmUrl = default(string), IList<HostnameConfiguration> hostnameConfigurations = default(IList<HostnameConfiguration>), IList<string> publicIPAddresses = default(IList<string>), IList<string> privateIPAddresses = default(IList<string>), VirtualNetworkConfiguration virtualNetworkConfiguration = default(VirtualNetworkConfiguration), IList<AdditionalLocation> additionalLocations = default(IList<AdditionalLocation>), IDictionary<string, string> customProperties = default(IDictionary<string, string>), IList<CertificateConfiguration> certificates = default(IList<CertificateConfiguration>), string virtualNetworkType = default(string), string publisherEmail = default(string), string publisherName = default(string), ApiManagementServiceSkuProperties sku = default(ApiManagementServiceSkuProperties), ApiManagementServiceIdentity identity = default(ApiManagementServiceIdentity), string etag = default(string))
            : base(id, name, type, tags)
        {
            NotificationSenderEmail = notificationSenderEmail;
            ProvisioningState = provisioningState;
            TargetProvisioningState = targetProvisioningState;
            CreatedAtUtc = createdAtUtc;
            GatewayUrl = gatewayUrl;
            GatewayRegionalUrl = gatewayRegionalUrl;
            PortalUrl = portalUrl;
            ManagementApiUrl = managementApiUrl;
            ScmUrl = scmUrl;
            HostnameConfigurations = hostnameConfigurations;
            PublicIPAddresses = publicIPAddresses;
            PrivateIPAddresses = privateIPAddresses;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            AdditionalLocations = additionalLocations;
            CustomProperties = customProperties;
            Certificates = certificates;
            VirtualNetworkType = virtualNetworkType;
            PublisherEmail = publisherEmail;
            PublisherName = publisherName;
            Sku = sku;
            Identity = identity;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets email address from which the notification will be
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationSenderEmail")]
        public string NotificationSenderEmail { get; set; }

        /// <summary>
        /// Gets the current provisioning state of the API Management service
        /// which can be one of the following:
        /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the API Management service, which is
        /// targeted by the long running operation started on the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetProvisioningState")]
        public string TargetProvisioningState { get; private set; }

        /// <summary>
        /// Gets creation UTC date of the API Management service.The date
        /// conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
        /// specified by the ISO 8601 standard.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAtUtc")]
        public System.DateTime? CreatedAtUtc { get; private set; }

        /// <summary>
        /// Gets gateway URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayUrl")]
        public string GatewayUrl { get; private set; }

        /// <summary>
        /// Gets gateway URL of the API Management service in the Default
        /// Region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayRegionalUrl")]
        public string GatewayRegionalUrl { get; private set; }

        /// <summary>
        /// Gets publisher portal endpoint Url of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.portalUrl")]
        public string PortalUrl { get; private set; }

        /// <summary>
        /// Gets management API endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managementApiUrl")]
        public string ManagementApiUrl { get; private set; }

        /// <summary>
        /// Gets SCM endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmUrl")]
        public string ScmUrl { get; private set; }

        /// <summary>
        /// Gets or sets custom hostname configuration of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostnameConfigurations")]
        public IList<HostnameConfiguration> HostnameConfigurations { get; set; }

        /// <summary>
        /// Gets public Static Load Balanced IP addresses of the API Management
        /// service in Primary region. Available only for Basic, Standard and
        /// Premium SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddresses")]
        public IList<string> PublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets private Static Load Balanced IP addresses of the API
        /// Management service in Primary region which is deployed in an
        /// Internal Virtual Network. Available only for Basic, Standard and
        /// Premium SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddresses")]
        public IList<string> PrivateIPAddresses { get; private set; }

        /// <summary>
        /// Gets or sets virtual network configuration of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkConfiguration")]
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets additional datacenter locations of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalLocations")]
        public IList<AdditionalLocation> AdditionalLocations { get; set; }

        /// <summary>
        /// Gets or sets custom properties of the API Management service.
        /// Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168`
        /// will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all
        /// TLS(1.0, 1.1 and 1.2). Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11`
        /// can be used to disable just TLS 1.1 and setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10`
        /// can be used to disable TLS 1.0 on an API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customProperties")]
        public IDictionary<string, string> CustomProperties { get; set; }

        /// <summary>
        /// Gets or sets list of Certificates that need to be installed in the
        /// API Management service. Max supported certificates that can be
        /// installed is 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificates")]
        public IList<CertificateConfiguration> Certificates { get; set; }

        /// <summary>
        /// Gets or sets the type of VPN in which API Management service needs
        /// to be configured in. None (Default Value) means the API Management
        /// service is not part of any Virtual Network, External means the API
        /// Management deployment is set up inside a Virtual Network having an
        /// Internet Facing Endpoint, and Internal means that API Management
        /// deployment is setup inside a Virtual Network having an Intranet
        /// Facing Endpoint only. Possible values include: 'None', 'External',
        /// 'Internal'
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkType")]
        public string VirtualNetworkType { get; set; }

        /// <summary>
        /// Gets or sets publisher email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherEmail")]
        public string PublisherEmail { get; set; }

        /// <summary>
        /// Gets or sets publisher name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherName")]
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets or sets SKU properties of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ApiManagementServiceSkuProperties Sku { get; set; }

        /// <summary>
        /// Gets or sets managed service identity of the Api Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ApiManagementServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets eTag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NotificationSenderEmail != null)
            {
                if (NotificationSenderEmail.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "NotificationSenderEmail", 100);
                }
            }
            if (HostnameConfigurations != null)
            {
                foreach (var element in HostnameConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (VirtualNetworkConfiguration != null)
            {
                VirtualNetworkConfiguration.Validate();
            }
            if (AdditionalLocations != null)
            {
                foreach (var element1 in AdditionalLocations)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Certificates != null)
            {
                foreach (var element2 in Certificates)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (PublisherEmail != null)
            {
                if (PublisherEmail.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PublisherEmail", 100);
                }
            }
            if (PublisherName != null)
            {
                if (PublisherName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PublisherName", 100);
                }
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
