// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.QuestionAnswering.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.QuestionAnswering
{
    internal partial class KnowledgebaseRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of KnowledgebaseRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt; qnamaker-resource-name &gt;.api.cognitiveservices.azure.com). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public KnowledgebaseRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListAllRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all knowledgebases for a user. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<KnowledgebasesDTO>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListAllRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KnowledgebasesDTO value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = KnowledgebasesDTO.DeserializeKnowledgebasesDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all knowledgebases for a user. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<KnowledgebasesDTO> ListAll(CancellationToken cancellationToken = default)
        {
            using var message = CreateListAllRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KnowledgebasesDTO value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = KnowledgebasesDTO.DeserializeKnowledgebasesDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDetailsRequest(string kbId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets details of a specific knowledgebase. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public async Task<Response<Knowledgebase>> GetDetailsAsync(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateGetDetailsRequest(kbId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Knowledgebase value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Knowledgebase.DeserializeKnowledgebase(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets details of a specific knowledgebase. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public Response<Knowledgebase> GetDetails(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateGetDetailsRequest(kbId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Knowledgebase value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Knowledgebase.DeserializeKnowledgebase(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string kbId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes the knowledgebase and all its data. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public async Task<Response> DeleteAsync(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateDeleteRequest(kbId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the knowledgebase and all its data. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public Response Delete(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateDeleteRequest(kbId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePublishRequest(string kbId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Publishes all changes in test index of a knowledgebase to its prod index. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public async Task<Response> PublishAsync(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreatePublishRequest(kbId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Publishes all changes in test index of a knowledgebase to its prod index. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public Response Publish(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreatePublishRequest(kbId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReplaceRequest(string kbId, ReplaceKbDTO replaceKb)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(replaceKb);
            request.Content = content;
            return message;
        }

        /// <summary> Replace knowledgebase contents. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="replaceKb"> An instance of ReplaceKbDTO which contains list of qnas to be uploaded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="replaceKb"/> is null. </exception>
        public async Task<Response> ReplaceAsync(string kbId, ReplaceKbDTO replaceKb, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (replaceKb == null)
            {
                throw new ArgumentNullException(nameof(replaceKb));
            }

            using var message = CreateReplaceRequest(kbId, replaceKb);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Replace knowledgebase contents. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="replaceKb"> An instance of ReplaceKbDTO which contains list of qnas to be uploaded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="replaceKb"/> is null. </exception>
        public Response Replace(string kbId, ReplaceKbDTO replaceKb, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (replaceKb == null)
            {
                throw new ArgumentNullException(nameof(replaceKb));
            }

            using var message = CreateReplaceRequest(kbId, replaceKb);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string kbId, UpdateKbOperationDTO updateKb)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(updateKb);
            request.Content = content;
            return message;
        }

        /// <summary> Asynchronous operation to modify a knowledgebase. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="updateKb"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="updateKb"/> is null. </exception>
        public async Task<ResponseWithHeaders<Models.Operation, KnowledgebaseUpdateHeaders>> UpdateAsync(string kbId, UpdateKbOperationDTO updateKb, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (updateKb == null)
            {
                throw new ArgumentNullException(nameof(updateKb));
            }

            using var message = CreateUpdateRequest(kbId, updateKb);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new KnowledgebaseUpdateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        Models.Operation value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.Operation.DeserializeOperation(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Asynchronous operation to modify a knowledgebase. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="updateKb"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="updateKb"/> is null. </exception>
        public ResponseWithHeaders<Models.Operation, KnowledgebaseUpdateHeaders> Update(string kbId, UpdateKbOperationDTO updateKb, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (updateKb == null)
            {
                throw new ArgumentNullException(nameof(updateKb));
            }

            using var message = CreateUpdateRequest(kbId, updateKb);
            _pipeline.Send(message, cancellationToken);
            var headers = new KnowledgebaseUpdateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        Models.Operation value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.Operation.DeserializeOperation(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(CreateKnowledgebaseParameters createKbPayload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/create", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createKbPayload);
            request.Content = content;
            return message;
        }

        /// <summary> Asynchronous operation to create a new knowledgebase. </summary>
        /// <param name="createKbPayload"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createKbPayload"/> is null. </exception>
        public async Task<Response<Models.Operation>> CreateAsync(CreateKnowledgebaseParameters createKbPayload, CancellationToken cancellationToken = default)
        {
            if (createKbPayload == null)
            {
                throw new ArgumentNullException(nameof(createKbPayload));
            }

            using var message = CreateCreateRequest(createKbPayload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        Models.Operation value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.Operation.DeserializeOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Asynchronous operation to create a new knowledgebase. </summary>
        /// <param name="createKbPayload"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createKbPayload"/> is null. </exception>
        public Response<Models.Operation> Create(CreateKnowledgebaseParameters createKbPayload, CancellationToken cancellationToken = default)
        {
            if (createKbPayload == null)
            {
                throw new ArgumentNullException(nameof(createKbPayload));
            }

            using var message = CreateCreateRequest(createKbPayload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        Models.Operation value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.Operation.DeserializeOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDownloadRequest(string kbId, EnvironmentType environment, string source, string changedSince)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            uri.AppendPath("/", false);
            uri.AppendPath(environment.ToString(), true);
            uri.AppendPath("/qna", false);
            if (source != null)
            {
                uri.AppendQuery("source", source, true);
            }
            if (changedSince != null)
            {
                uri.AppendQuery("changedSince", changedSince, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Download the knowledgebase. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="environment"> Specifies whether environment is Test or Prod. </param>
        /// <param name="source"> The source property filter to apply. </param>
        /// <param name="changedSince"> The last changed status property filter to apply. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public async Task<Response<QnADocumentsDTO>> DownloadAsync(string kbId, EnvironmentType environment, string source = null, string changedSince = null, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateDownloadRequest(kbId, environment, source, changedSince);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QnADocumentsDTO value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QnADocumentsDTO.DeserializeQnADocumentsDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Download the knowledgebase. </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="environment"> Specifies whether environment is Test or Prod. </param>
        /// <param name="source"> The source property filter to apply. </param>
        /// <param name="changedSince"> The last changed status property filter to apply. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public Response<QnADocumentsDTO> Download(string kbId, EnvironmentType environment, string source = null, string changedSince = null, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateDownloadRequest(kbId, environment, source, changedSince);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QnADocumentsDTO value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QnADocumentsDTO.DeserializeQnADocumentsDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGenerateAnswerRequest(string kbId, QueryDTO generateAnswerPayload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            uri.AppendPath("/generateAnswer", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(generateAnswerPayload);
            request.Content = content;
            return message;
        }

        /// <summary> GenerateAnswer call to query knowledgebase (QnA Maker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="generateAnswerPayload"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="generateAnswerPayload"/> is null. </exception>
        public async Task<Response<QnASearchResultList>> GenerateAnswerAsync(string kbId, QueryDTO generateAnswerPayload, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (generateAnswerPayload == null)
            {
                throw new ArgumentNullException(nameof(generateAnswerPayload));
            }

            using var message = CreateGenerateAnswerRequest(kbId, generateAnswerPayload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QnASearchResultList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QnASearchResultList.DeserializeQnASearchResultList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> GenerateAnswer call to query knowledgebase (QnA Maker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="generateAnswerPayload"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="generateAnswerPayload"/> is null. </exception>
        public Response<QnASearchResultList> GenerateAnswer(string kbId, QueryDTO generateAnswerPayload, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (generateAnswerPayload == null)
            {
                throw new ArgumentNullException(nameof(generateAnswerPayload));
            }

            using var message = CreateGenerateAnswerRequest(kbId, generateAnswerPayload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QnASearchResultList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QnASearchResultList.DeserializeQnASearchResultList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateTrainRequest(string kbId, FeedbackRecordsDTO trainPayload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/knowledgebases/", false);
            uri.AppendPath(kbId, true);
            uri.AppendPath("/train", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(trainPayload);
            request.Content = content;
            return message;
        }

        /// <summary> Train call to add suggestions to knowledgebase (QnAMaker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="trainPayload"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="trainPayload"/> is null. </exception>
        public async Task<Response> TrainAsync(string kbId, FeedbackRecordsDTO trainPayload, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (trainPayload == null)
            {
                throw new ArgumentNullException(nameof(trainPayload));
            }

            using var message = CreateTrainRequest(kbId, trainPayload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Train call to add suggestions to knowledgebase (QnAMaker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="trainPayload"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="trainPayload"/> is null. </exception>
        public Response Train(string kbId, FeedbackRecordsDTO trainPayload, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (trainPayload == null)
            {
                throw new ArgumentNullException(nameof(trainPayload));
            }

            using var message = CreateTrainRequest(kbId, trainPayload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
