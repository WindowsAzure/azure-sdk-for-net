﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.Testing;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void ExtractEntityLinking()
        {
            string endpoint = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_SUBSCRIPTION_KEY");

            #region Snippet:TextAnalyticsSample6CreateClient
            var client = new TextAnalyticsClient(new Uri(endpoint), new TextAnalyticsSubscriptionKeyCredential(subscriptionKey));
            #endregion

            #region Snippet:RecognizeLinkedEntities
            string input = "Microsoft was founded by Bill Gates and Paul Allen.";

            IEnumerable<LinkedEntity> entities = client.InferEntityLinks(input).Value;

            Console.WriteLine($"Extracted {entities.Count()} linked entit{(entities.Count() > 1 ? "ies" : "y")}:");
            foreach (LinkedEntity linkedEntity in entities)
            {
                Console.WriteLine($"Name: {linkedEntity.Name}, Id: {linkedEntity.Id}, Language: {linkedEntity.Language}, Data Source: {linkedEntity.DataSource}, Uri: {linkedEntity.Uri.ToString()}");
                foreach (LinkedEntityMatch match in linkedEntity.Matches)
                {
                    Console.WriteLine($"    Match Text: {match.Text}, Score: {match.Score:0.00}, Offset: {match.Offset}, Length: {match.Length}.");
                }
            }
            #endregion
        }
    }
}
