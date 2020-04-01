// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Azure SQL Managed Instance linked service. </summary>
    public partial class AzureSqlMILinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AzureSqlMILinkedService. </summary>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        public AzureSqlMILinkedService(object connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            Type = "AzureSqlMI";
        }

        /// <summary> Initializes a new instance of AzureSqlMILinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="password"> The Azure key vault secret reference of password in connection string. </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against Azure SQL Managed Instance. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key of the service principal used to authenticate against Azure SQL Managed Instance. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AzureSqlMILinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, AzureKeyVaultSecretReference password, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Password = password;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AzureSqlMI";
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of password in connection string. </summary>
        public AzureKeyVaultSecretReference Password { get; set; }
        /// <summary> The ID of the service principal used to authenticate against Azure SQL Managed Instance. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary> The key of the service principal used to authenticate against Azure SQL Managed Instance. </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
