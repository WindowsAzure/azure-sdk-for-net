﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Test.Perf;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Sample.Perf
{
    public class HttpClientGetTest : PerfTest<UrlOptions>
    {
        private static HttpClient _httpClient;

        public HttpClientGetTest(UrlOptions options) : base(options)
        {
        }

        public override Task GlobalSetupAsync()
        {
            if (Options.Insecure)
            {
                var httpClientHandler = new HttpClientHandler();
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                _httpClient = new HttpClient(httpClientHandler);
            }
            else
            {
                _httpClient = new HttpClient();
            }

            return Task.CompletedTask;
        }

        public override void Run(CancellationToken cancellationToken)
        {
            _httpClient.GetStringAsync(Options.Url).Wait();
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await _httpClient.GetStringAsync(Options.Url);
        }
    }
}
