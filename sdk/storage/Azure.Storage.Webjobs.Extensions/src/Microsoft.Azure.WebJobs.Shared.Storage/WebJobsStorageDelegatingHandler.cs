﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Storage.Common
{
    // TODO (kasobol-msft) see todo below before deleting this type
    internal class WebJobsStorageDelegatingHandler : DelegatingHandler
    {
        private bool _isInnerHandlerConfigured = false;

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!_isInnerHandlerConfigured)
            {
                InitializeInnerHandler();

                _isInnerHandlerConfigured = true;
            }

            return base.SendAsync(request, cancellationToken);
        }

        private void InitializeInnerHandler()
        {
            try
            {
                // Storage ensures that the inner handler is an HttpClientHandler
                if (!(InnerHandler is HttpClientHandler innerHandler))
                {
                    throw new InvalidOperationException("The inner handler has not been initialized by the Storage SDK.");
                }

                // TODO (kasobol-msft) find out how to cap this with V12 SDK (this is going to be pipeline configuration)
                innerHandler.MaxConnectionsPerServer = 50;
            }
            catch (InvalidOperationException)
            {
                // This exception is thrown if there's a race and this was set by another thread.
            }
        }
    }
}
