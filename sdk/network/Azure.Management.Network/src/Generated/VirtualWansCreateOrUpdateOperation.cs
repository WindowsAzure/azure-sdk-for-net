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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
    public partial class VirtualWansCreateOrUpdateOperation : Operation<VirtualWAN>, IOperationSource<VirtualWAN>
    {
        private readonly ArmOperationHelpers<VirtualWAN> _operation;
        internal VirtualWansCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<VirtualWAN>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualWansCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualWAN Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualWAN>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualWAN>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualWAN IOperationSource<VirtualWAN>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return VirtualWAN.DeserializeVirtualWAN(document.RootElement);
            }
        }

        async ValueTask<VirtualWAN> IOperationSource<VirtualWAN>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return VirtualWAN.DeserializeVirtualWAN(document.RootElement);
            }
        }
    }
}
