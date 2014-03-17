// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The SQL Database Management API includes operations for managing SQL
    /// Database servers for a subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715271.aspx for
    /// more information)
    /// </summary>
    internal partial class ServerOperations : IServiceOperations<SqlManagementClient>, Microsoft.WindowsAzure.Management.Sql.IServerOperations
    {
        /// <summary>
        /// Initializes a new instance of the ServerOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ServerOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Sets the administrative password of a SQL Database server for a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715272.aspx
        /// for more information)
        /// </summary>
        /// <param name='serverName'>
        /// The server that will have the change made to the administrative
        /// user.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Manage Administrator Password operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async System.Threading.Tasks.Task<OperationResponse> ChangeAdministratorPasswordAsync(string serverName, ServerChangeAdministratorPasswordParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.NewPassword == null)
            {
                throw new ArgumentNullException("parameters.NewPassword");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "ChangeAdministratorPasswordAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + this.Client.Credentials.SubscriptionId + "/services/sqlservers/servers/" + serverName + "?op=ResetPassword";
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement administratorLoginPasswordElement = new XElement(XName.Get("AdministratorLoginPassword", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                requestDoc.Add(administratorLoginPasswordElement);
                
                administratorLoginPasswordElement.Value = parameters.NewPassword;
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationResponse result = null;
                    result = new OperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Adds a new SQL Database server to a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715274.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Server operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response returned from the Create Server operation.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Sql.Models.ServerCreateResponse> CreateAsync(ServerCreateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.AdministratorPassword == null)
            {
                throw new ArgumentNullException("parameters.AdministratorPassword");
            }
            if (parameters.AdministratorUserName == null)
            {
                throw new ArgumentNullException("parameters.AdministratorUserName");
            }
            if (parameters.Location == null)
            {
                throw new ArgumentNullException("parameters.Location");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "CreateAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + this.Client.Credentials.SubscriptionId + "/services/sqlservers/servers";
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement serverElement = new XElement(XName.Get("Server", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                requestDoc.Add(serverElement);
                
                XElement administratorLoginElement = new XElement(XName.Get("AdministratorLogin", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                administratorLoginElement.Value = parameters.AdministratorUserName;
                serverElement.Add(administratorLoginElement);
                
                XElement administratorLoginPasswordElement = new XElement(XName.Get("AdministratorLoginPassword", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                administratorLoginPasswordElement.Value = parameters.AdministratorPassword;
                serverElement.Add(administratorLoginPasswordElement);
                
                XElement locationElement = new XElement(XName.Get("Location", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                locationElement.Value = parameters.Location;
                serverElement.Add(locationElement);
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Created)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ServerCreateResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new ServerCreateResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement serverNameElement = responseDoc.Element(XName.Get("ServerName", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                    if (serverNameElement != null && serverNameElement.IsEmpty == false)
                    {
                        result.ServerName = serverNameElement.Value;
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Drops a SQL Database server from a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715285.aspx
        /// for more information)
        /// </summary>
        /// <param name='serverName'>
        /// The name of the server to be deleted.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async System.Threading.Tasks.Task<OperationResponse> DeleteAsync(string serverName, CancellationToken cancellationToken)
        {
            // Validate
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverName", serverName);
                Tracing.Enter(invocationId, this, "DeleteAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + this.Client.Credentials.SubscriptionId + "/services/sqlservers/servers/" + serverName;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    OperationResponse result = null;
                    result = new OperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns all SQL Database servers that are provisioned for a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715269.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Sql.Models.ServerListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + this.Client.Credentials.SubscriptionId + "/services/sqlservers/servers";
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ServerListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new ServerListResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement serversSequenceElement = responseDoc.Element(XName.Get("Servers", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                    if (serversSequenceElement != null && serversSequenceElement.IsEmpty == false)
                    {
                        foreach (XElement serversElement in serversSequenceElement.Elements(XName.Get("Server", "http://schemas.microsoft.com/sqlazure/2010/12/")))
                        {
                            ServerListResponse.Server serverInstance = new ServerListResponse.Server();
                            result.Servers.Add(serverInstance);
                            
                            XElement nameElement = serversElement.Element(XName.Get("Name", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                            if (nameElement != null && nameElement.IsEmpty == false)
                            {
                                string nameInstance = nameElement.Value;
                                serverInstance.Name = nameInstance;
                            }
                            
                            XElement administratorLoginElement = serversElement.Element(XName.Get("AdministratorLogin", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                            if (administratorLoginElement != null && administratorLoginElement.IsEmpty == false)
                            {
                                string administratorLoginInstance = administratorLoginElement.Value;
                                serverInstance.AdministratorUserName = administratorLoginInstance;
                            }
                            
                            XElement locationElement = serversElement.Element(XName.Get("Location", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                            if (locationElement != null && locationElement.IsEmpty == false)
                            {
                                string locationInstance = locationElement.Value;
                                serverInstance.Location = locationInstance;
                            }
                            
                            XElement featuresSequenceElement = serversElement.Element(XName.Get("Features", "http://schemas.microsoft.com/sqlazure/2010/12/"));
                            if (featuresSequenceElement != null && featuresSequenceElement.IsEmpty == false)
                            {
                                foreach (XElement featuresElement in featuresSequenceElement.Elements(XName.Get("Feature", "http://schemas.microsoft.com/sqlazure/2010/12/")))
                                {
                                    string featuresKey = featuresElement.Element(XName.Get("Name", "http://schemas.microsoft.com/sqlazure/2010/12/")).Value;
                                    string featuresValue = featuresElement.Element(XName.Get("Value", "http://schemas.microsoft.com/sqlazure/2010/12/")).Value;
                                    serverInstance.Features.Add(featuresKey, featuresValue);
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
