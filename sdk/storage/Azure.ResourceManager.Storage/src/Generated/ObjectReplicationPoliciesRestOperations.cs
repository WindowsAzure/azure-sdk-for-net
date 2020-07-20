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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    internal partial class ObjectReplicationPoliciesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ObjectReplicationPoliciesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ObjectReplicationPoliciesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-06-01")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string accountName)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/objectReplicationPolicies", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List the object replication policies associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ObjectReplicationPolicies>> ListAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateListRequest(resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ObjectReplicationPolicies value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ObjectReplicationPolicies.DeserializeObjectReplicationPolicies(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List the object replication policies associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ObjectReplicationPolicies> List(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateListRequest(resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ObjectReplicationPolicies value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ObjectReplicationPolicies.DeserializeObjectReplicationPolicies(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string accountName, string objectReplicationPolicyId)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/objectReplicationPolicies/", false);
            uri.AppendPath(objectReplicationPolicyId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get the object replication policy of the storage account by policy ID. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ObjectReplicationPolicy>> GetAsync(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (objectReplicationPolicyId == null)
            {
                throw new ArgumentNullException(nameof(objectReplicationPolicyId));
            }

            using var message = CreateGetRequest(resourceGroupName, accountName, objectReplicationPolicyId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ObjectReplicationPolicy value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ObjectReplicationPolicy.DeserializeObjectReplicationPolicy(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the object replication policy of the storage account by policy ID. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ObjectReplicationPolicy> Get(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (objectReplicationPolicyId == null)
            {
                throw new ArgumentNullException(nameof(objectReplicationPolicyId));
            }

            using var message = CreateGetRequest(resourceGroupName, accountName, objectReplicationPolicyId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ObjectReplicationPolicy value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ObjectReplicationPolicy.DeserializeObjectReplicationPolicy(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string accountName, string objectReplicationPolicyId, ObjectReplicationPolicy properties)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/objectReplicationPolicies/", false);
            uri.AppendPath(objectReplicationPolicyId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(properties);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update the object replication policy of the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ObjectReplicationPolicy>> CreateOrUpdateAsync(string resourceGroupName, string accountName, string objectReplicationPolicyId, ObjectReplicationPolicy properties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (objectReplicationPolicyId == null)
            {
                throw new ArgumentNullException(nameof(objectReplicationPolicyId));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, accountName, objectReplicationPolicyId, properties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ObjectReplicationPolicy value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ObjectReplicationPolicy.DeserializeObjectReplicationPolicy(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update the object replication policy of the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ObjectReplicationPolicy> CreateOrUpdate(string resourceGroupName, string accountName, string objectReplicationPolicyId, ObjectReplicationPolicy properties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (objectReplicationPolicyId == null)
            {
                throw new ArgumentNullException(nameof(objectReplicationPolicyId));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, accountName, objectReplicationPolicyId, properties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ObjectReplicationPolicy value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ObjectReplicationPolicy.DeserializeObjectReplicationPolicy(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string accountName, string objectReplicationPolicyId)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/objectReplicationPolicies/", false);
            uri.AppendPath(objectReplicationPolicyId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the object replication policy associated with the specified storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (objectReplicationPolicyId == null)
            {
                throw new ArgumentNullException(nameof(objectReplicationPolicyId));
            }

            using var message = CreateDeleteRequest(resourceGroupName, accountName, objectReplicationPolicyId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the object replication policy associated with the specified storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (objectReplicationPolicyId == null)
            {
                throw new ArgumentNullException(nameof(objectReplicationPolicyId));
            }

            using var message = CreateDeleteRequest(resourceGroupName, accountName, objectReplicationPolicyId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
