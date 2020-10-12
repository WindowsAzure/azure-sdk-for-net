// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureApplicationInsightsParameter. </summary>
    internal partial class AzureApplicationInsightsParameter
    {
        /// <summary> Initializes a new instance of AzureApplicationInsightsParameter. </summary>
        /// <param name="azureCloud"> Azure cloud environment. </param>
        /// <param name="applicationId"> Azure Application Insights ID. </param>
        /// <param name="apiKey"> API Key. </param>
        /// <param name="query"> Query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureCloud"/>, <paramref name="applicationId"/>, <paramref name="apiKey"/>, or <paramref name="query"/> is null. </exception>
        public AzureApplicationInsightsParameter(string azureCloud, string applicationId, string apiKey, string query)
        {
            if (azureCloud == null)
            {
                throw new ArgumentNullException(nameof(azureCloud));
            }
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }
            if (apiKey == null)
            {
                throw new ArgumentNullException(nameof(apiKey));
            }
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            AzureCloud = azureCloud;
            ApplicationId = applicationId;
            ApiKey = apiKey;
            Query = query;
        }

        /// <summary> Azure cloud environment. </summary>
        public string AzureCloud { get; set; }
        /// <summary> Azure Application Insights ID. </summary>
        public string ApplicationId { get; set; }
        /// <summary> API Key. </summary>
        public string ApiKey { get; set; }
        /// <summary> Query. </summary>
        public string Query { get; set; }
    }
}
