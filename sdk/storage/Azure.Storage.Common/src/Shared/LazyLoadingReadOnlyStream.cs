﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Storage.Shared;

namespace Azure.Storage
{
    /// <summary>
    /// Used for Open Read APIs.
    /// </summary>
    internal class LazyLoadingReadOnlyStream<TRequestConditions> : Stream
    {
        /// <summary>
        /// The current position within the blob or file.
        /// </summary>
        private long _position;

        /// <summary>
        /// Last known length of underlying blob or file.
        /// </summary>
        private long _length;

        /// <summary>
        /// The number of bytes to download per call.
        /// </summary>
        private readonly int _bufferSize;

        /// <summary>
        /// The stream we will download to.
        /// </summary>
        private Stream _stream;

        /// <summary>
        /// Request conditions to send on the download requests.
        /// </summary>
        private readonly TRequestConditions _requestConditions;

        /// <summary>
        /// Download() function.
        /// </summary>
        private readonly Func<HttpRange, TRequestConditions, bool, bool, CancellationToken, Task<Response<IDownloadedContent>>> _downloadInternalFunc;

        public LazyLoadingReadOnlyStream(
            Func<HttpRange, TRequestConditions, bool, bool, CancellationToken, Task<Response<IDownloadedContent>>> downloadInternalFunc,
            long position = 0,
            int? bufferSize = default,
            TRequestConditions requestConditions = default)
        {
            _downloadInternalFunc = downloadInternalFunc;
            _position = position;
            _bufferSize = bufferSize ?? Constants.DefaultStreamingDownloadSize;
            _stream = new MemoryStream(_bufferSize);
            _requestConditions = requestConditions;
            _length = -1;
        }

        public override int Read(byte[] buffer, int offset, int count)
            => ReadInternal(
                buffer,
                offset,
                count,
                async: false,
                default)
            .EnsureCompleted();

        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            => await ReadInternal(
                buffer,
                offset,
                count,
                async: true,
                cancellationToken)
                .ConfigureAwait(false);

        public async Task<int> ReadInternal(byte[] buffer, int offset, int count, bool async, CancellationToken cancellationToken)
        {
            ValidateReadParameters(buffer, offset, count);

            if (_position == _length)
            {
                return 0;
            }

            if (_stream.Position == 0 || _stream.Position == _stream.Length)
            {
                int lastDownloadedBytes = await DownloadInternal(async, cancellationToken).ConfigureAwait(false);
                if (lastDownloadedBytes == 0)
                {
                    return 0;
                }
            }

            int remainingBytesInBuffer = (int)(_stream.Length - _stream.Position);

            // We will return the minimum of remainingBytesInBuffer, the count provided by the user, and the remaining bytes in the buffer.
            int bytesToWrite = Math.Min(Math.Min(remainingBytesInBuffer, count), buffer.Length - offset);

            int copiedBytes = async
                ? await _stream.ReadAsync(buffer, offset, bytesToWrite).ConfigureAwait(false)
                : _stream.Read(buffer, offset, bytesToWrite);

            _position += copiedBytes;

            return copiedBytes;
        }

        private async Task<int> DownloadInternal(bool async, CancellationToken cancellationToken)
        {
            Response<IDownloadedContent> response;

            HttpRange range = new HttpRange(_position, _bufferSize);

#pragma warning disable AZC0110 // DO NOT use await keyword in possibly synchronous scope.
            response = await _downloadInternalFunc(range, _requestConditions, default, async, cancellationToken).ConfigureAwait(false);
#pragma warning restore AZC0110 // DO NOT use await keyword in possibly synchronous scope.

            using Stream networkStream = response.Value.Content;

            _stream.SetLength(0);

            if (async)
            {
                await networkStream.CopyToAsync(
                    _stream,
                    Constants.DefaultBufferSize,
                    cancellationToken)
                    .ConfigureAwait(false);
            }
            else
            {
                networkStream.CopyTo(
                    _stream,
                    Constants.DefaultBufferSize);
            }

            networkStream.Dispose();

            _stream.Position = 0;
            _length = GetBlobLength(response);

            return response.GetRawResponse().Headers.ContentLength.GetValueOrDefault();
        }

        private static void ValidateReadParameters(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException($"{nameof(buffer)}", $"{nameof(buffer)} cannot be null.");
            }

            if (offset < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(offset)} cannot be less than 0.");
            }

            if (offset > buffer.Length)
            {
                throw new ArgumentOutOfRangeException($"{nameof(offset)} cannot exceed {nameof(buffer)} length.");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(count)} cannot be less than 0.");
            }
        }

        private static long GetBlobLength(Response<IDownloadedContent> response)
        {
            response.GetRawResponse().Headers.TryGetValue("Content-Range", out string lengthString);

            if (lengthString == null)
            {
                throw new ArgumentException("Content-Range header is mssing on download response.");
            }

            string[] split = lengthString.Split('/');
            return Convert.ToInt64(split[1], CultureInfo.InvariantCulture);
        }

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => _length;

        public override long Position
        {
            get => _position;
            set => throw new NotSupportedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        public override void Flush() { }

        public override Task FlushAsync(CancellationToken cancellationToken)
            => Task.CompletedTask;
    }
}
