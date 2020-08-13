// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Core
{
    /// <summary>
    ///  Provides a container for content encoded using multipart/form-data MIME type.
    /// </summary>
    internal class RequestContentContent : RequestContent
    {
        #region Fields

        private const string SP = " ";
        private const string ColonSP = ": ";
        private const string CRLF = "\r\n";
        private const int DefaultHeaderAllocation = 2 * 1024;
        private const string DefaultMediaType = "application/http";

        private readonly Request request;

        #endregion Fields

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContentContent"/> class.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> instance to encapsulate.</param>
        public RequestContentContent(Request request) : this(request, default)
        { }


        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContentContent"/> class.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> instance to encapsulate.</param>
        /// <param name="headers">Additional headers to apply to the request content.</param>
        public RequestContentContent(Request request, Dictionary<string, string>? headers)
        {
            Argument.AssertNotNull(request, nameof(request));

            Headers = new Dictionary<string, string>
            {
                ["Content-Type"] = DefaultMediaType
            };

            if (headers != null)
            {
                foreach (var key in headers.Keys)
                {
                    Headers[key] = headers[key];
                }
            }

            this.request = request;
        }

        #endregion Construction

        #region Dispose

        /// <summary>
        ///  Frees resources held by the <see cref="MultipartContent"/> object.
        /// </summary>
        public override void Dispose()
        {
            request.Dispose();
        }

        #endregion Dispose

        #region Serialization

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellationToken)
        {
            Argument.AssertNotNull(stream, nameof(stream));

            byte[] header = SerializeHeader();
            await stream.WriteAsync(header, 0, header.Length);

            if (request.Content != null)
            {
                await request.Content.WriteToAsync(stream, cancellationToken);
            }
        }

        public override void WriteTo(Stream stream, CancellationToken cancellationToken)
        {
            Argument.AssertNotNull(stream, nameof(stream));

            byte[] header = SerializeHeader();
            stream.Write(header, 0, header.Length);

            if (request.Content != null)
            {
                request.Content.WriteTo(stream, cancellationToken);
            }
        }

        /// <summary>
        /// Computes the length of the stream if possible.
        /// </summary>
        /// <param name="length">The computed length of the stream.</param>
        /// <returns><c>true</c> if the length has been computed; otherwise <c>false</c>.</returns>
        public override bool TryComputeLength(out long length)
        {
            // We have four states we could be in:
            //   1. We have content and the stream came back as a null or non-seekable
            //   2. We have content and the stream is seekable, so we know its length
            //   3. We don't have content
            //
            // For #1, we return false.
            // For #2, we return true & the size of our headers + the content length
            // For #3, we return true & the size of our headers

            bool hasContent = request.Content != null;
            length = 0;

            // Cases #1, #2, #3
            if (hasContent)
            {
                if (!request!.Content!.TryComputeLength(out length))
                {
                    length = 0;
                    return false;
                }
            }

            // We serialize header to a StringBuilder so that we can determine the length
            // following the pattern for HttpContent to try and determine the message length.
            // The perf overhead is no larger than for the other HttpContent implementations.
            byte[] header = SerializeHeader();
            length += header.Length;
            return true;
        }

        private byte[] SerializeHeader()
        {
            StringBuilder message = new StringBuilder(DefaultHeaderAllocation);

            SerializeRequestLine(message, request);
            SerializeHeaderFields(message, request.Headers);
            message.Append(CRLF);
            return Encoding.UTF8.GetBytes(message.ToString());
        }

        /// <summary>
        /// Serializes the HTTP request line.
        /// </summary>
        /// <param name="message">Where to write the request line.</param>
        /// <param name="request">The HTTP request.</param>
        private static void SerializeRequestLine(StringBuilder message, Request request)
        {
            Argument.AssertNotNull(message, nameof(message));
            message.Append(request.Method + SP);
            message.Append(request.Uri.ToString() + SP);
            message.Append("HTTP/1.1" + CRLF);

            // Only insert host header if not already present.
            if (!request.Headers.TryGetValue(HttpHeader.Names.Host, out _))
            {
                message.Append(HttpHeader.Names.Host + ColonSP + request.Uri.Host + CRLF);
            }
        }

        /// <summary>
        /// Serializes the header fields.
        /// </summary>
        /// <param name="message">Where to write the status line.</param>
        /// <param name="headers">The headers to write.</param>
        private static void SerializeHeaderFields(StringBuilder message, RequestHeaders headers)
        {
            Argument.AssertNotNull(message, nameof(message));
            foreach (HttpHeader header in headers)
            {
                message.Append(header.Name + ColonSP + header.Value + CRLF);
            }
        }

        #endregion Serialization
    }
}
