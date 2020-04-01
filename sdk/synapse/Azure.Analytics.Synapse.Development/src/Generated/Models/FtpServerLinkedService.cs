// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> A FTP server Linked Service. </summary>
    public partial class FtpServerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of FtpServerLinkedService. </summary>
        /// <param name="host"> Host name of the FTP server. Type: string (or Expression with resultType string). </param>
        public FtpServerLinkedService(object host)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            Host = host;
            Type = "FtpServer";
        }

        /// <summary> Initializes a new instance of FtpServerLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="host"> Host name of the FTP server. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the FTP server uses to listen for client connections. Default value is 21. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the FTP server. </param>
        /// <param name="userName"> Username to logon the FTP server. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to logon the FTP server. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="enableSsl"> If true, connect to the FTP server over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="enableServerCertificateValidation"> If true, validate the FTP server SSL certificate when connect over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        internal FtpServerLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object port, FtpAuthenticationType? authenticationType, object userName, SecretBase password, object encryptedCredential, object enableSsl, object enableServerCertificateValidation) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            EnableSsl = enableSsl;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            Type = type ?? "FtpServer";
        }

        /// <summary> Host name of the FTP server. Type: string (or Expression with resultType string). </summary>
        public object Host { get; set; }
        /// <summary> The TCP port number that the FTP server uses to listen for client connections. Default value is 21. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object Port { get; set; }
        /// <summary> The authentication type to be used to connect to the FTP server. </summary>
        public FtpAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username to logon the FTP server. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary> Password to logon the FTP server. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> If true, connect to the FTP server over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableSsl { get; set; }
        /// <summary> If true, validate the FTP server SSL certificate when connect over SSL/TLS channel. Default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableServerCertificateValidation { get; set; }
    }
}
