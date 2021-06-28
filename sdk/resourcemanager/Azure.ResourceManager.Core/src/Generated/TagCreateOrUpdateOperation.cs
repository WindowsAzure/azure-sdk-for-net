﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    /// <summary> Create or update a Tag. </summary>
    public class TagCreateOrUpdateOperation : Operation<Tags>
    {
        private readonly OperationOrResponseInternals<Tags> _operation;

        /// <summary> Initializes a new instance of ResourcesCreateOrUpdateByIdOperation for mocking. </summary>
        protected TagCreateOrUpdateOperation()
        {
        }

        internal TagCreateOrUpdateOperation(ResourceOperationsBase parentOperation, Response<TagsData> response)
        {
            _operation = new OperationOrResponseInternals<Tags>(Response.FromValue(new Tags(parentOperation, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => "";

        /// <inheritdoc />
        public override Tags Value => _operation.Value;

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
        public override ValueTask<Response<Tags>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Tags>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
