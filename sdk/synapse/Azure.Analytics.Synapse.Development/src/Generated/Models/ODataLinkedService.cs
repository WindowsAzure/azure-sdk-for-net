// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Open Data Protocol (OData) linked service. </summary>
    public partial class ODataLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of ODataLinkedService. </summary>
        /// <param name="url"> The URL of the OData service endpoint. Type: string (or Expression with resultType string). </param>
        public ODataLinkedService(object url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Url = url;
            Type = "OData";
        }

        /// <summary> Initializes a new instance of ODataLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="url"> The URL of the OData service endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the OData service. </param>
        /// <param name="userName"> User name of the OData service. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password of the OData service. </param>
        /// <param name="tenant"> Specify the tenant information (domain name or tenant ID) under which your application resides. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> Specify the application id of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="aadResourceId"> Specify the resource you are requesting authorization to use Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="aadServicePrincipalCredentialType"> Specify the credential type (key or cert) is used for service principal. </param>
        /// <param name="servicePrincipalKey"> Specify the secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalEmbeddedCert"> Specify the base64 encoded certificate of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalEmbeddedCertPassword"> Specify the password of your certificate if your certificate has a password and you are using AadServicePrincipal authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal ODataLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object url, ODataAuthenticationType? authenticationType, object userName, SecretBase password, object tenant, object servicePrincipalId, object aadResourceId, ODataAadServicePrincipalCredentialType? aadServicePrincipalCredentialType, SecretBase servicePrincipalKey, SecretBase servicePrincipalEmbeddedCert, SecretBase servicePrincipalEmbeddedCertPassword, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Url = url;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            Tenant = tenant;
            ServicePrincipalId = servicePrincipalId;
            AadResourceId = aadResourceId;
            AadServicePrincipalCredentialType = aadServicePrincipalCredentialType;
            ServicePrincipalKey = servicePrincipalKey;
            ServicePrincipalEmbeddedCert = servicePrincipalEmbeddedCert;
            ServicePrincipalEmbeddedCertPassword = servicePrincipalEmbeddedCertPassword;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "OData";
        }

        /// <summary> The URL of the OData service endpoint. Type: string (or Expression with resultType string). </summary>
        public object Url { get; set; }
        /// <summary> Type of authentication used to connect to the OData service. </summary>
        public ODataAuthenticationType? AuthenticationType { get; set; }
        /// <summary> User name of the OData service. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary> Password of the OData service. </summary>
        public SecretBase Password { get; set; }
        /// <summary> Specify the tenant information (domain name or tenant ID) under which your application resides. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> Specify the application id of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary> Specify the resource you are requesting authorization to use Directory. Type: string (or Expression with resultType string). </summary>
        public object AadResourceId { get; set; }
        /// <summary> Specify the credential type (key or cert) is used for service principal. </summary>
        public ODataAadServicePrincipalCredentialType? AadServicePrincipalCredentialType { get; set; }
        /// <summary> Specify the secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> Specify the base64 encoded certificate of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public SecretBase ServicePrincipalEmbeddedCert { get; set; }
        /// <summary> Specify the password of your certificate if your certificate has a password and you are using AadServicePrincipal authentication. Type: string (or Expression with resultType string). </summary>
        public SecretBase ServicePrincipalEmbeddedCertPassword { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
