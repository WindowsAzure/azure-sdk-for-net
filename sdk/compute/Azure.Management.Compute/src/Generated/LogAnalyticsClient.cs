// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The LogAnalytics service client. </summary>
    public partial class LogAnalyticsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LogAnalyticsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of LogAnalyticsClient for mocking. </summary>
        protected LogAnalyticsClient()
        {
        }
        /// <summary> Initializes a new instance of LogAnalyticsClient. </summary>
        internal LogAnalyticsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new LogAnalyticsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Export logs that show Api requests made by this subscription in the given time window to show throttling activities. </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getRequestRateByInterval Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<LogAnalyticsExportRequestRateByIntervalOperation> StartExportRequestRateByIntervalAsync(string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogAnalyticsClient.StartExportRequestRateByInterval");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ExportRequestRateByIntervalAsync(location, parameters, cancellationToken).ConfigureAwait(false);
                return new LogAnalyticsExportRequestRateByIntervalOperation(_clientDiagnostics, _pipeline, RestClient.CreateExportRequestRateByIntervalRequest(location, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export logs that show Api requests made by this subscription in the given time window to show throttling activities. </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getRequestRateByInterval Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual LogAnalyticsExportRequestRateByIntervalOperation StartExportRequestRateByInterval(string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogAnalyticsClient.StartExportRequestRateByInterval");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ExportRequestRateByInterval(location, parameters, cancellationToken);
                return new LogAnalyticsExportRequestRateByIntervalOperation(_clientDiagnostics, _pipeline, RestClient.CreateExportRequestRateByIntervalRequest(location, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export logs that show total throttled Api requests for this subscription in the given time window. </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getThrottledRequests Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<LogAnalyticsExportThrottledRequestsOperation> StartExportThrottledRequestsAsync(string location, LogAnalyticsInputBase parameters, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogAnalyticsClient.StartExportThrottledRequests");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ExportThrottledRequestsAsync(location, parameters, cancellationToken).ConfigureAwait(false);
                return new LogAnalyticsExportThrottledRequestsOperation(_clientDiagnostics, _pipeline, RestClient.CreateExportThrottledRequestsRequest(location, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export logs that show total throttled Api requests for this subscription in the given time window. </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getThrottledRequests Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual LogAnalyticsExportThrottledRequestsOperation StartExportThrottledRequests(string location, LogAnalyticsInputBase parameters, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogAnalyticsClient.StartExportThrottledRequests");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ExportThrottledRequests(location, parameters, cancellationToken);
                return new LogAnalyticsExportThrottledRequestsOperation(_clientDiagnostics, _pipeline, RestClient.CreateExportThrottledRequestsRequest(location, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
