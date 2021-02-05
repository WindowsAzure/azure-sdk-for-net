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
using Azure.Communication.Identity.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Identity
{
    internal partial class CommunicationIdentityRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of CommunicationIdentityRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CommunicationIdentityRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-02-22-preview1")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateRequest(IEnumerable<CommunicationTokenScope> createTokenWithScopes)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/identities", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            CommunicationIdentityCreateRequest communicationIdentityCreateRequest = new CommunicationIdentityCreateRequest();
            foreach (var value in createTokenWithScopes)
            {
                communicationIdentityCreateRequest.CreateTokenWithScopes.Add(value);
            }
            var model = communicationIdentityCreateRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Create a new identity. </summary>
        /// <param name="createTokenWithScopes"> Also create access token for the created identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<CommunicationIdentityAccessTokenResult>> CreateAsync(IEnumerable<CommunicationTokenScope> createTokenWithScopes = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(createTokenWithScopes);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CommunicationIdentityAccessTokenResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationIdentityAccessTokenResult.DeserializeCommunicationIdentityAccessTokenResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a new identity. </summary>
        /// <param name="createTokenWithScopes"> Also create access token for the created identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<CommunicationIdentityAccessTokenResult> Create(IEnumerable<CommunicationTokenScope> createTokenWithScopes = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(createTokenWithScopes);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CommunicationIdentityAccessTokenResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationIdentityAccessTokenResult.DeserializeCommunicationIdentityAccessTokenResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/identities/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete the identity, revoke all tokens for the identity and delete all associated data. </summary>
        /// <param name="id"> Identifier of the identity to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response> DeleteAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete the identity, revoke all tokens for the identity and delete all associated data. </summary>
        /// <param name="id"> Identifier of the identity to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response Delete(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRevokeAccessTokensRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/identities/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/:revokeAccessTokens", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Revoke all access tokens for the specific identity. </summary>
        /// <param name="id"> Identifier of the identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response> RevokeAccessTokensAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateRevokeAccessTokensRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Revoke all access tokens for the specific identity. </summary>
        /// <param name="id"> Identifier of the identity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response RevokeAccessTokens(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateRevokeAccessTokensRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateIssueAccessTokenRequest(string id, IEnumerable<CommunicationTokenScope> scopes)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/identities/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/:issueAccessToken", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new CommunicationIdentityAccessTokenRequest(scopes);
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Issue a new token for an identity. </summary>
        /// <param name="id"> Identifier of the identity to issue token for. </param>
        /// <param name="scopes"> List of scopes attached to the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="scopes"/> is null. </exception>
        public async Task<Response<CommunicationIdentityAccessToken>> IssueAccessTokenAsync(string id, IEnumerable<CommunicationTokenScope> scopes, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (scopes == null)
            {
                throw new ArgumentNullException(nameof(scopes));
            }

            using var message = CreateIssueAccessTokenRequest(id, scopes);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationIdentityAccessToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Issue a new token for an identity. </summary>
        /// <param name="id"> Identifier of the identity to issue token for. </param>
        /// <param name="scopes"> List of scopes attached to the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="scopes"/> is null. </exception>
        public Response<CommunicationIdentityAccessToken> IssueAccessToken(string id, IEnumerable<CommunicationTokenScope> scopes, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (scopes == null)
            {
                throw new ArgumentNullException(nameof(scopes));
            }

            using var message = CreateIssueAccessTokenRequest(id, scopes);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationIdentityAccessToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateIssueTurnCredentialsRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/turn/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/:issueCredentials", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Issue TURN credentials for an existing identity. </summary>
        /// <param name="id"> Identifier of the existing identity to issue credentials for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<TurnCredentialsResponse>> IssueTurnCredentialsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateIssueTurnCredentialsRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TurnCredentialsResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TurnCredentialsResponse.DeserializeTurnCredentialsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Issue TURN credentials for an existing identity. </summary>
        /// <param name="id"> Identifier of the existing identity to issue credentials for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<TurnCredentialsResponse> IssueTurnCredentials(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateIssueTurnCredentialsRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TurnCredentialsResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TurnCredentialsResponse.DeserializeTurnCredentialsResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
