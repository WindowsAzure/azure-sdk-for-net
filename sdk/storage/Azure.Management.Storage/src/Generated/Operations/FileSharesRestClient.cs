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
using Azure.Management.Storage.Models;

namespace Azure.Management.Storage
{
    internal partial class FileSharesRestClient
    {
        private string subscriptionId;
        private string host;
        private string ApiVersion;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of FileSharesRestClient. </summary>
        public FileSharesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com", string ApiVersion = "2019-06-01")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (ApiVersion == null)
            {
                throw new ArgumentNullException(nameof(ApiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.host = host;
            this.ApiVersion = ApiVersion;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateListRequest(string resourceGroupName, string accountName, string maxpagesize, string filter)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/default/shares", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", maxpagesize, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            return message;
        }
        /// <summary> Lists all shares. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only container names starting with the filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<FileShareItems>> ListAsync(string resourceGroupName, string accountName, string maxpagesize, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(resourceGroupName, accountName, maxpagesize, filter);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = FileShareItems.DeserializeFileShareItems(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Lists all shares. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only container names starting with the filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FileShareItems> List(string resourceGroupName, string accountName, string maxpagesize, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(resourceGroupName, accountName, maxpagesize, filter);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = FileShareItems.DeserializeFileShareItems(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateCreateRequest(string resourceGroupName, string accountName, string shareName, FileShare fileShare)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/default/shares/", false);
            uri.AppendPath(shareName, true);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(fileShare);
            request.Content = content;
            return message;
        }
        /// <summary> Creates a new share under the specified account as described by request body. The share resource includes metadata and properties for that share. It does not include a list of the files contained by the share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="fileShare"> Properties of the file share to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<FileShare>> CreateAsync(string resourceGroupName, string accountName, string shareName, FileShare fileShare, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Create");
            scope.Start();
            try
            {
                using var message = CreateCreateRequest(resourceGroupName, accountName, shareName, fileShare);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = FileShare.DeserializeFileShare(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Creates a new share under the specified account as described by request body. The share resource includes metadata and properties for that share. It does not include a list of the files contained by the share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="fileShare"> Properties of the file share to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FileShare> Create(string resourceGroupName, string accountName, string shareName, FileShare fileShare, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Create");
            scope.Start();
            try
            {
                using var message = CreateCreateRequest(resourceGroupName, accountName, shareName, fileShare);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = FileShare.DeserializeFileShare(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string accountName, string shareName, FileShare fileShare)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/default/shares/", false);
            uri.AppendPath(shareName, true);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(fileShare);
            request.Content = content;
            return message;
        }
        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="fileShare"> Properties of the file share to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<FileShare>> UpdateAsync(string resourceGroupName, string accountName, string shareName, FileShare fileShare, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Update");
            scope.Start();
            try
            {
                using var message = CreateUpdateRequest(resourceGroupName, accountName, shareName, fileShare);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = FileShare.DeserializeFileShare(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="fileShare"> Properties of the file share to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FileShare> Update(string resourceGroupName, string accountName, string shareName, FileShare fileShare, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Update");
            scope.Start();
            try
            {
                using var message = CreateUpdateRequest(resourceGroupName, accountName, shareName, fileShare);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = FileShare.DeserializeFileShare(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGetRequest(string resourceGroupName, string accountName, string shareName)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/default/shares/", false);
            uri.AppendPath(shareName, true);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            return message;
        }
        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<FileShare>> GetAsync(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, accountName, shareName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = FileShare.DeserializeFileShare(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FileShare> Get(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, accountName, shareName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = FileShare.DeserializeFileShare(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string accountName, string shareName)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/default/shares/", false);
            uri.AppendPath(shareName, true);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            return message;
        }
        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, accountName, shareName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, accountName, shareName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(nextLink, false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Lists all shares. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<FileShareItems>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = FileShareItems.DeserializeFileShareItems(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Lists all shares. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FileShareItems> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("FileSharesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = FileShareItems.DeserializeFileShareItems(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
