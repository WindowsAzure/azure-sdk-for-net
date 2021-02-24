﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net;
using System.Threading.Tasks;

namespace Azure.Iot.ModelsRepository.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using AzureEventSourceListener listener = AzureEventSourceListener.CreateTraceLogger(EventLevel.Verbose);

            await ResolveExistingAsync();
            await TryResolveButNotFoundAsync();
        }

        private static async Task ResolveExistingAsync()
        {
            var dtmi = "dtmi:com:example:TemperatureController;1";
            var client = new ModelsRepositoryClient();

            IDictionary<string, string> models = await client.ResolveAsync(dtmi).ConfigureAwait(false);

            Console.WriteLine($"{dtmi} resolved in {models.Count} interfaces.");
        }

        private static async Task TryResolveButNotFoundAsync()
        {
            var dtmi = "dtmi:com:example:NotFound;1";
            var client = new ModelsRepositoryClient();

            try
            {
                IDictionary<string, string> models = await client.ResolveAsync(dtmi).ConfigureAwait(false);
                Console.WriteLine($"{dtmi} resolved in {models.Count} interfaces.");
            }
            catch (RequestFailedException ex) when (ex.Status == (int)HttpStatusCode.NotFound)
            {
                Console.WriteLine($"{dtmi} was not found in the default public models repository: {ex.Message}");
            }
        }
    }
}
