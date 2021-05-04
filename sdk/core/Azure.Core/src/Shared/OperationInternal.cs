// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    internal class OperationInternal<TResult>
    {
        private const string RetryAfterHeaderName = "Retry-After";

        private readonly object SetStateLock = new object();

        private readonly IOperation<TResult> _operation;

        private TResult _value;

        private RequestFailedException _operationFailedException;

        public OperationInternal(ClientDiagnostics clientDiagnostics, IOperation<TResult> operation)
        {
            _operation = operation;
            OperationTypeName = operation.GetType().Name;
            ClientDiagnostics = clientDiagnostics;
            DefaultPollingInterval = TimeSpan.FromSeconds(1);
            ScopeAttributes = new Dictionary<string, string>();
        }

        public IDictionary<string, string> ScopeAttributes { get; }

        public bool HasValue { get; private set; }

        public bool HasCompleted { get; set; }

        public TResult Value
        {
            get
            {
                if (HasValue)
                {
                    return _value;
                }
                else if (OperationFailedException != null)
                {
                    throw OperationFailedException;
                }
                else
                {
                    throw new InvalidOperationException("The operation has not completed yet.");
                }
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Value));
                }

                _value = value;
                HasValue = true;
            }
        }

        public Response RawResponse { get; set; }

        public string OperationTypeName { get; set; }

        public TimeSpan DefaultPollingInterval { get; set; }

        private ClientDiagnostics ClientDiagnostics { get; }

        private RequestFailedException OperationFailedException
        {
            get => _operationFailedException;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _operationFailedException = value;
            }
        }

        public async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken) =>
            await UpdateStatusAsync(async: true, cancellationToken).ConfigureAwait(false);

        public Response UpdateStatus(CancellationToken cancellationToken) =>
            UpdateStatusAsync(async: false, cancellationToken).EnsureCompleted();

        public async ValueTask<Response<TResult>> WaitForCompletionAsync(CancellationToken cancellationToken) =>
            await WaitForCompletionAsync(DefaultPollingInterval, cancellationToken).ConfigureAwait(false);

        public async ValueTask<Response<TResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken)
        {
            while (true)
            {
                Response response = await UpdateStatusAsync(cancellationToken).ConfigureAwait(false);

                if (HasCompleted)
                {
                    return Response.FromValue(Value, response);
                }

                var serverDelay = response.Headers.TryGetValue(RetryAfterHeaderName, out string retryAfterValue)
                    && int.TryParse(retryAfterValue, out int serverDelayInSeconds)
                    ? TimeSpan.FromSeconds(serverDelayInSeconds) : TimeSpan.Zero;

                var delay = serverDelay > pollingInterval
                    ? serverDelay : pollingInterval;

                await WaitAsync(delay, cancellationToken).ConfigureAwait(false);
            }
        }

        protected virtual async Task WaitAsync(TimeSpan delay, CancellationToken cancellationToken) =>
            await Task.Delay(delay, cancellationToken);

        private async ValueTask<Response> UpdateStatusAsync(bool async, CancellationToken cancellationToken)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope($"{OperationTypeName}.UpdateStatus");

            foreach (KeyValuePair<string, string> attribute in ScopeAttributes)
            {
                scope.AddAttribute(attribute.Key, attribute.Value);
            }

            scope.Start();

            try
            {
                return await UpdateStateAsync(async, cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e)
            {
                scope.Failed(e);
                throw;
            }
            catch (Exception e)
            {
                var requestFailedException = new RequestFailedException("Unexpected failure.", e);
                scope.Failed(requestFailedException);
                throw requestFailedException;
            }
        }

        private async ValueTask<Response> UpdateStateAsync(bool async, CancellationToken cancellationToken)
        {
            var state = await _operation.UpdateStateAsync(async, cancellationToken).ConfigureAwait(false);

            lock (SetStateLock)
            {
                RawResponse = state.RawResponse;

                if (state.Succeeded == true)
                {
                    Value = state.Value;
                    HasCompleted = true;
                }
                else if (state.Succeeded == false)
                {
                    OperationFailedException = state.OperationFailedException;
                    HasCompleted = true;

                    throw OperationFailedException;
                }
            }

            return state.RawResponse;
        }
    }

    internal interface IOperation<TResult>
    {
        ValueTask<OperationState<TResult>> UpdateStateAsync(bool async, CancellationToken cancellationToken);
    }

    internal readonly struct OperationState<TResult>
    {
        private OperationState(Response rawResponse, bool? succeeded, TResult value, RequestFailedException operationFailedException)
        {
            RawResponse = rawResponse;
            Succeeded = succeeded;
            Value = value;
            OperationFailedException = operationFailedException;
        }

        public Response RawResponse { get; }

        public bool? Succeeded { get; }

        public TResult Value { get; }

        public RequestFailedException OperationFailedException { get; }

        public static OperationState<TResult> Success(Response rawResponse, TResult value) =>
            new OperationState<TResult>(rawResponse, true, value, default);

        public static OperationState<TResult> Failure(Response rawResponse, RequestFailedException operationFailedException) =>
            new OperationState<TResult>(rawResponse, false, default, operationFailedException);

        public static OperationState<TResult> Pending(Response rawResponse) =>
            new OperationState<TResult>(rawResponse, default, default, default);
    }
}
