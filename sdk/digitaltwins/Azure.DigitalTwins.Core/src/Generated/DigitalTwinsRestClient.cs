// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.DigitalTwins.Core.Models;

namespace Azure.DigitalTwins.Core
{
    internal partial class DigitalTwinsRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DigitalTwinsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public DigitalTwinsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-05-31-preview")
        {
            endpoint ??= new Uri("https://digitaltwins-name.digitaltwins.azure.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetByIdRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string id, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            return message;
        }

        /// <summary>
        /// Deletes a digital twin. All relationships referencing the digital twin must already be deleted.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Deletes a digital twin. All relationships referencing the digital twin must already be deleted.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string id, IEnumerable<object> patchDocument, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json-patch+json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartArray();
            foreach (var item in patchDocument)
            {
                content.JsonWriter.WriteObjectValue(item);
            }
            content.JsonWriter.WriteEndArray();
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetRelationshipByIdRequest(string id, string relationshipId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/relationships/", false);
            uri.AppendPath(relationshipId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        internal HttpMessage CreateAddRelationshipRequest(string id, string relationshipId, object relationship)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/relationships/", false);
            uri.AppendPath(relationshipId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("If-None-Match", "*");
            request.Headers.Add("Content-Type", "application/json");
            if (relationship != null)
            {
                using var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(relationship);
                request.Content = content;
            }
            return message;
        }

        internal HttpMessage CreateDeleteRelationshipRequest(string id, string relationshipId, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/relationships/", false);
            uri.AppendPath(relationshipId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            return message;
        }

        /// <summary>
        /// Deletes a relationship between two digital twins.
        /// Status codes:
        /// 200 (OK): Success.
        /// 404 (Not Found): There is either no digital twin or relationship with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="relationshipId"> The id of the relationship. The id is unique within the digital twin and case sensitive. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteRelationshipAsync(string id, string relationshipId, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (relationshipId == null)
            {
                throw new ArgumentNullException(nameof(relationshipId));
            }

            using var message = CreateDeleteRelationshipRequest(id, relationshipId, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Deletes a relationship between two digital twins.
        /// Status codes:
        /// 200 (OK): Success.
        /// 404 (Not Found): There is either no digital twin or relationship with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="relationshipId"> The id of the relationship. The id is unique within the digital twin and case sensitive. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteRelationship(string id, string relationshipId, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (relationshipId == null)
            {
                throw new ArgumentNullException(nameof(relationshipId));
            }

            using var message = CreateDeleteRelationshipRequest(id, relationshipId, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRelationshipRequest(string id, string relationshipId, string ifMatch, IEnumerable<object> patchDocument)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/relationships/", false);
            uri.AppendPath(relationshipId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json-patch+json");
            if (patchDocument != null)
            {
                using var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in patchDocument)
                {
                    content.JsonWriter.WriteObjectValue(item);
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            return message;
        }

        internal HttpMessage CreateListRelationshipsRequest(string id, string relationshipName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/relationships", false);
            if (relationshipName != null)
            {
                uri.AppendQuery("relationshipName", relationshipName, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary>
        /// Retrieves the relationships from a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="relationshipName"> The name of the relationship. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<RelationshipCollection>> ListRelationshipsAsync(string id, string relationshipName = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListRelationshipsRequest(id, relationshipName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RelationshipCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = RelationshipCollection.DeserializeRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves the relationships from a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="relationshipName"> The name of the relationship. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<RelationshipCollection> ListRelationships(string id, string relationshipName = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListRelationshipsRequest(id, relationshipName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RelationshipCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = RelationshipCollection.DeserializeRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListIncomingRelationshipsRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/incomingrelationships", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary>
        /// Retrieves all incoming relationship for a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IncomingRelationshipCollection>> ListIncomingRelationshipsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListIncomingRelationshipsRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IncomingRelationshipCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = IncomingRelationshipCollection.DeserializeIncomingRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves all incoming relationship for a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IncomingRelationshipCollection> ListIncomingRelationships(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListIncomingRelationshipsRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IncomingRelationshipCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = IncomingRelationshipCollection.DeserializeIncomingRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSendTelemetryRequest(string id, string dtId, object telemetry, string dtTimestamp)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/telemetry", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("dt-id", dtId);
            if (dtTimestamp != null)
            {
                request.Headers.Add("dt-timestamp", dtTimestamp);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(telemetry);
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateSendComponentTelemetryRequest(string id, string componentPath, string dtId, object telemetry, string dtTimestamp)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentPath, true);
            uri.AppendPath("/telemetry", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("dt-id", dtId);
            if (dtTimestamp != null)
            {
                request.Headers.Add("dt-timestamp", dtTimestamp);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(telemetry);
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetComponentRequest(string id, string componentPath)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentPath, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        internal HttpMessage CreateUpdateComponentRequest(string id, string componentPath, string ifMatch, IEnumerable<object> patchDocument)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/digitaltwins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentPath, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json-patch+json");
            if (patchDocument != null)
            {
                using var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in patchDocument)
                {
                    content.JsonWriter.WriteObjectValue(item);
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            return message;
        }

        internal HttpMessage CreateListRelationshipsNextPageRequest(string nextLink, string id, string relationshipName)
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

        /// <summary>
        /// Retrieves the relationships from a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="relationshipName"> The name of the relationship. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<RelationshipCollection>> ListRelationshipsNextPageAsync(string nextLink, string id, string relationshipName = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListRelationshipsNextPageRequest(nextLink, id, relationshipName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RelationshipCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = RelationshipCollection.DeserializeRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves the relationships from a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="relationshipName"> The name of the relationship. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<RelationshipCollection> ListRelationshipsNextPage(string nextLink, string id, string relationshipName = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListRelationshipsNextPageRequest(nextLink, id, relationshipName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RelationshipCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = RelationshipCollection.DeserializeRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListIncomingRelationshipsNextPageRequest(string nextLink, string id)
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

        /// <summary>
        /// Retrieves all incoming relationship for a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IncomingRelationshipCollection>> ListIncomingRelationshipsNextPageAsync(string nextLink, string id, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListIncomingRelationshipsNextPageRequest(nextLink, id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IncomingRelationshipCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = IncomingRelationshipCollection.DeserializeIncomingRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Retrieves all incoming relationship for a digital twin.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// 404 (Not Found): There is no digital twin with the provided id.
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="id"> The id of the digital twin. The id is unique within the service and case sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IncomingRelationshipCollection> ListIncomingRelationshipsNextPage(string nextLink, string id, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateListIncomingRelationshipsNextPageRequest(nextLink, id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IncomingRelationshipCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = IncomingRelationshipCollection.DeserializeIncomingRelationshipCollection(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
