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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VirtualHubsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VirtualHubsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public VirtualHubsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string virtualHubName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<VirtualHub>> GetAsync(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateGetRequest(resourceGroupName, virtualHubName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualHub value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualHub.DeserializeVirtualHub(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<VirtualHub> Get(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateGetRequest(resourceGroupName, virtualHubName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualHub value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualHub.DeserializeVirtualHub(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(virtualHubParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a VirtualHub resource if it doesn&apos;t exist else updates the existing VirtualHub. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="virtualHubParameters"> Parameters supplied to create or update VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualHubName, virtualHubParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a VirtualHub resource if it doesn&apos;t exist else updates the existing VirtualHub. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="virtualHubParameters"> Parameters supplied to create or update VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualHubName, virtualHubParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateTagsRequest(string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(virtualHubParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Updates VirtualHub tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="virtualHubParameters"> Parameters supplied to update VirtualHub tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<VirtualHub>> UpdateTagsAsync(string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, virtualHubName, virtualHubParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualHub value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualHub.DeserializeVirtualHub(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates VirtualHub tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="virtualHubParameters"> Parameters supplied to update VirtualHub tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<VirtualHub> UpdateTags(string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, virtualHubName, virtualHubParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualHub value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualHub.DeserializeVirtualHub(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string virtualHubName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, virtualHubName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, virtualHubName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all the VirtualHubs in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListVirtualHubsResult>> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the VirtualHubs in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListVirtualHubsResult> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all the VirtualHubs in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListVirtualHubsResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the VirtualHubs in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListVirtualHubsResult> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all the VirtualHubs in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListVirtualHubsResult>> ListByResourceGroupNextPageAsync(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the VirtualHubs in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListVirtualHubsResult> ListByResourceGroupNextPage(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all the VirtualHubs in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListVirtualHubsResult>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the VirtualHubs in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListVirtualHubsResult> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualHubsResult.DeserializeListVirtualHubsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
