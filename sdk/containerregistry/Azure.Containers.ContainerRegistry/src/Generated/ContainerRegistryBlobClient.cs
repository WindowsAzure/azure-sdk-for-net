// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

#pragma warning disable AZC0007

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ContainerRegistryBlob service client. </summary>
    public partial class ContainerRegistryBlobClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        protected HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://management.core.windows.net/.default" };
        private string url;
        private readonly string apiVersion;

        /// <summary> Initializes a new instance of ContainerRegistryBlobClient for mocking. </summary>
        protected ContainerRegistryBlobClient()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryBlobClient. </summary>
        /// <param name="url"> Registry login URL. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ContainerRegistryBlobClient(string url, TokenCredential credential, ContainerRegistryClientOptions options = null)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ContainerRegistryClientOptions();
            Pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, AuthorizationScopes));
            this.url = url;
            apiVersion = options.Version;
        }

        /// <summary> Retrieve the blob from the registry identified by digest. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetBlobAsync(string name, string digest, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetBlobRequest(name, digest);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieve the blob from the registry identified by digest. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetBlob(string name, string digest, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetBlobRequest(name, digest);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetBlob"/> and <see cref="GetBlobAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        protected Request CreateGetBlobRequest(string name, string digest)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/", false);
            uri.AppendPath(digest, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream");
            return request;
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckBlobExistsAsync(string name, string digest, CancellationToken cancellationToken = default)
        {
            Request req = CreateCheckBlobExistsRequest(name, digest);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckBlobExists(string name, string digest, CancellationToken cancellationToken = default)
        {
            Request req = CreateCheckBlobExistsRequest(name, digest);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CheckBlobExists"/> and <see cref="CheckBlobExistsAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        protected Request CreateCheckBlobExistsRequest(string name, string digest)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/", false);
            uri.AppendPath(digest, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Removes an already uploaded blob. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteBlobAsync(string name, string digest, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteBlobRequest(name, digest);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Removes an already uploaded blob. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteBlob(string name, string digest, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteBlobRequest(name, digest);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="DeleteBlob"/> and <see cref="DeleteBlobAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        protected Request CreateDeleteBlobRequest(string name, string digest)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/", false);
            uri.AppendPath(digest, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream");
            return request;
        }

        /// <summary> Mount a blob identified by the `mount` parameter from another repository. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="from"> Name of the source repository. </param>
        /// <param name="mount"> Digest of blob to mount from the source repository. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> MountBlobAsync(string name, string @from, string mount, CancellationToken cancellationToken = default)
        {
            Request req = CreateMountBlobRequest(name, @from, mount);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Mount a blob identified by the `mount` parameter from another repository. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="from"> Name of the source repository. </param>
        /// <param name="mount"> Digest of blob to mount from the source repository. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response MountBlob(string name, string @from, string mount, CancellationToken cancellationToken = default)
        {
            Request req = CreateMountBlobRequest(name, @from, mount);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="MountBlob"/> and <see cref="MountBlobAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="from"> Name of the source repository. </param>
        /// <param name="mount"> Digest of blob to mount from the source repository. </param>
        protected Request CreateMountBlobRequest(string name, string @from, string mount)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/uploads/", false);
            uri.AppendQuery("from", @from, true);
            uri.AppendQuery("mount", mount, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Retrieve status of upload identified by uuid. The primary purpose of this endpoint is to resolve the current status of a resumable upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetUploadStatusAsync(string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetUploadStatusRequest(location);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieve status of upload identified by uuid. The primary purpose of this endpoint is to resolve the current status of a resumable upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetUploadStatus(string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetUploadStatusRequest(location);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetUploadStatus"/> and <see cref="GetUploadStatusAsync"/> operations. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        protected Request CreateGetUploadStatusRequest(string location)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(location, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Upload a stream of data without completing the upload. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UploadChunkAsync(RequestContent requestBody, string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateUploadChunkRequest(requestBody, location);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Upload a stream of data without completing the upload. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UploadChunk(RequestContent requestBody, string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateUploadChunkRequest(requestBody, location);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="UploadChunk"/> and <see cref="UploadChunkAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        protected Request CreateUploadChunkRequest(RequestContent requestBody, string location)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(location, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/octet-stream");
            request.Content = requestBody;
            return request;
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CompleteUploadAsync(RequestContent requestBody, string digest, string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateCompleteUploadRequest(requestBody, digest, location);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CompleteUpload(RequestContent requestBody, string digest, string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateCompleteUploadRequest(requestBody, digest, location);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CompleteUpload"/> and <see cref="CompleteUploadAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        protected Request CreateCompleteUploadRequest(RequestContent requestBody, string digest, string location)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(location, false);
            uri.AppendQuery("digest", digest, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/octet-stream");
            request.Content = requestBody;
            return request;
        }

        /// <summary> Cancel outstanding upload processes, releasing associated resources. If this is not called, the unfinished uploads will eventually timeout. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelUploadAsync(string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateCancelUploadRequest(location);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Cancel outstanding upload processes, releasing associated resources. If this is not called, the unfinished uploads will eventually timeout. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelUpload(string location, CancellationToken cancellationToken = default)
        {
            Request req = CreateCancelUploadRequest(location);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CancelUpload"/> and <see cref="CancelUploadAsync"/> operations. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        protected Request CreateCancelUploadRequest(string location)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(location, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Initiate a resumable blob upload with an empty request body. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartUploadAsync(string name, CancellationToken cancellationToken = default)
        {
            Request req = CreateStartUploadRequest(name);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Initiate a resumable blob upload with an empty request body. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StartUpload(string name, CancellationToken cancellationToken = default)
        {
            Request req = CreateStartUploadRequest(name);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="StartUpload"/> and <see cref="StartUploadAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        protected Request CreateStartUploadRequest(string name)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/uploads/", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return request;
        }

        /// <summary> Retrieve the blob from the registry identified by `digest`. This endpoint may also support RFC7233 compliant range requests. Support can be detected by issuing a HEAD request. If the header `Accept-Range: bytes` is returned, range requests can be used to fetch partial content. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetChunkAsync(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetChunkRequest(name, digest, range);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieve the blob from the registry identified by `digest`. This endpoint may also support RFC7233 compliant range requests. Support can be detected by issuing a HEAD request. If the header `Accept-Range: bytes` is returned, range requests can be used to fetch partial content. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetChunk(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetChunkRequest(name, digest, range);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetChunk"/> and <see cref="GetChunkAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        protected Request CreateGetChunkRequest(string name, string digest, string range)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/", false);
            uri.AppendPath(digest, true);
            request.Uri = uri;
            request.Headers.Add("Range", range);
            request.Headers.Add("Accept", "application/octet-stream");
            return request;
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckChunkExistsAsync(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            Request req = CreateCheckChunkExistsRequest(name, digest, range);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckChunkExists(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            Request req = CreateCheckChunkExistsRequest(name, digest, range);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CheckChunkExists"/> and <see cref="CheckChunkExistsAsync"/> operations. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        protected Request CreateCheckChunkExistsRequest(string name, string digest, string range)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/blobs/", false);
            uri.AppendPath(digest, true);
            request.Uri = uri;
            request.Headers.Add("Range", range);
            request.Headers.Add("Accept", "application/json");
            return request;
        }
    }
}
