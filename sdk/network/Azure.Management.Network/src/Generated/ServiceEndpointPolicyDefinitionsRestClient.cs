// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    internal partial class ServiceEndpointPolicyDefinitionsRestClient
    {
        private string subscriptionId;
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionsRestClient. </summary>
        public ServiceEndpointPolicyDefinitionsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.subscriptionId = subscriptionId;
            this.host = host;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions/", false);
            uri.AppendPath(serviceEndpointPolicyDefinitionName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified ServiceEndpoint policy definitions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the Service Endpoint Policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified ServiceEndpoint policy definitions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the Service Endpoint Policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions/", false);
            uri.AppendPath(serviceEndpointPolicyDefinitionName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get the specified service endpoint policy definitions from service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ServiceEndpointPolicyDefinition>> GetAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateGetRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinition value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ServiceEndpointPolicyDefinition.DeserializeServiceEndpointPolicyDefinition(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the specified service endpoint policy definitions from service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ServiceEndpointPolicyDefinition> Get(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateGetRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinition value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ServiceEndpointPolicyDefinition.DeserializeServiceEndpointPolicyDefinition(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions/", false);
            uri.AppendPath(serviceEndpointPolicyDefinitionName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(serviceEndpointPolicyDefinitions);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> CreateOrUpdateAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }
            if (serviceEndpointPolicyDefinitions == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitions));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }
            if (serviceEndpointPolicyDefinitions == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitions));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string resourceGroupName, string serviceEndpointPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ServiceEndpointPolicyDefinitionListResult>> ListByResourceGroupAsync(string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName, serviceEndpointPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ServiceEndpointPolicyDefinitionListResult> ListByResourceGroup(string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName, serviceEndpointPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string resourceGroupName, string serviceEndpointPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ServiceEndpointPolicyDefinitionListResult>> ListByResourceGroupNextPageAsync(string nextLink, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, resourceGroupName, serviceEndpointPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ServiceEndpointPolicyDefinitionListResult> ListByResourceGroupNextPage(string nextLink, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, resourceGroupName, serviceEndpointPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
