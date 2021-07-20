// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure SQL Database datastore configuration.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSqlDatabase")]
    public partial class AzureSqlDatabaseContents : DatastoreContents
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlDatabaseContents class.
        /// </summary>
        public AzureSqlDatabaseContents()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlDatabaseContents class.
        /// </summary>
        /// <param name="credentials">Account credentials.</param>
        /// <param name="databaseName">Azure SQL database name.</param>
        /// <param name="endpoint">Azure cloud endpoint for the
        /// database.</param>
        /// <param name="portNumber">Azure SQL server port.</param>
        /// <param name="serverName">Azure SQL server name.</param>
        public AzureSqlDatabaseContents(DatastoreCredentials credentials, string databaseName, string endpoint, int portNumber, string serverName)
        {
            Credentials = credentials;
            DatabaseName = databaseName;
            Endpoint = endpoint;
            PortNumber = portNumber;
            ServerName = serverName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account credentials.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public DatastoreCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or sets azure SQL database name.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets azure cloud endpoint for the database.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets azure SQL server port.
        /// </summary>
        [JsonProperty(PropertyName = "portNumber")]
        public int PortNumber { get; set; }

        /// <summary>
        /// Gets or sets azure SQL server name.
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Credentials == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Credentials");
            }
            if (DatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseName");
            }
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (ServerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServerName");
            }
            if (DatabaseName != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(DatabaseName, "[a-zA-Z0-9_]"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "DatabaseName", "[a-zA-Z0-9_]");
                }
            }
            if (Endpoint != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Endpoint, "[a-zA-Z0-9_]"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Endpoint", "[a-zA-Z0-9_]");
                }
            }
            if (ServerName != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ServerName, "[a-zA-Z0-9_]"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ServerName", "[a-zA-Z0-9_]");
                }
            }
        }
    }
}
