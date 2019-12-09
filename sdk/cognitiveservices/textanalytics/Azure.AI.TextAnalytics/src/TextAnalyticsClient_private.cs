﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.TextAnalytics
{
    public partial class TextAnalyticsClient
    {
        private const string TextAnalyticsRoute = "/text/analytics/";

        private const string LanguagesRoute = "/languages";
        private const string EntitiesRoute = "/entities/recognition/general";
        private const string PiiEntitiesRoute = "/entities/recognition/pii";
        private const string SentimentRoute = "/sentiment";
        private const string KeyPhrasesRoute = "/keyPhrases";
        private const string EntityLinkingRoute = "/entities/linking";

        private const string ShowStatistics = "showStats";
        private const string ModelVersion = "model-version";

        #region Detect Language
        private static async Task<Response<DetectLanguageResultCollection>> CreateDetectLanguageResponseAsync(Response response, Dictionary<string, int> idToIndexMap, CancellationToken cancellation)
        {
            DetectLanguageResultCollection result = await TextAnalyticsServiceSerializer.DeserializeDetectLanguageResponseAsync(response.ContentStream, idToIndexMap, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<DetectLanguageResultCollection> CreateDetectLanguageResponse(Response response, Dictionary<string, int> idToIndexMap) =>
            Response.FromValue(TextAnalyticsServiceSerializer.DeserializeDetectLanguageResponse(response.ContentStream, idToIndexMap), response);

        #endregion

        #region Recognize Entities
        private static async Task<Response<RecognizeEntitiesResultCollection>> CreateRecognizeEntitiesResponseAsync(Response response, Dictionary<string, int> idToIndexMap, CancellationToken cancellation)
        {
            RecognizeEntitiesResultCollection result = await TextAnalyticsServiceSerializer.DeserializeRecognizeEntitiesResponseAsync(response.ContentStream, idToIndexMap, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<RecognizeEntitiesResultCollection> CreateRecognizeEntitiesResponse(Response response, Dictionary<string, int> idToIndexMap) =>
            Response.FromValue(TextAnalyticsServiceSerializer.DeserializeRecognizeEntitiesResponse(response.ContentStream, idToIndexMap), response);

        #endregion

        #region Analyze Sentiment
        private static async Task<Response<AnalyzeSentimentResultCollection>> CreateAnalyzeSentimentResponseAsync(Response response, Dictionary<string, int> idToIndexMap, CancellationToken cancellation)
        {
            AnalyzeSentimentResultCollection result = await TextAnalyticsServiceSerializer.DeserializeAnalyzeSentimentResponseAsync(response.ContentStream, idToIndexMap, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<AnalyzeSentimentResultCollection> CreateAnalyzeSentimentResponse(Response response, Dictionary<string, int> idToIndexMap) =>
            Response.FromValue(TextAnalyticsServiceSerializer.DeserializeAnalyzeSentimentResponse(response.ContentStream, idToIndexMap), response);

        #endregion  Analyze Sentiment

        #region Extract KeyPhrases
        private static async Task<Response<ExtractKeyPhrasesResultCollection>> CreateKeyPhraseResponseAsync(Response response, Dictionary<string, int> idToIndexMap, CancellationToken cancellation)
        {
            ExtractKeyPhrasesResultCollection result = await TextAnalyticsServiceSerializer.DeserializeKeyPhraseResponseAsync(response.ContentStream, idToIndexMap, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<ExtractKeyPhrasesResultCollection> CreateKeyPhraseResponse(Response response, Dictionary<string, int> idToIndexMap) =>
            Response.FromValue(TextAnalyticsServiceSerializer.DeserializeKeyPhraseResponse(response.ContentStream, idToIndexMap), response);

        #endregion Extract KeyPhrases

        #region Entity Linking
        private static async Task<Response<ExtractLinkedEntitiesResultCollection>> CreateLinkedEntityResponseAsync(Response response, Dictionary<string, int> idToIndexMap, CancellationToken cancellation)
        {
            ExtractLinkedEntitiesResultCollection result = await TextAnalyticsServiceSerializer.DeserializeLinkedEntityResponseAsync(response.ContentStream, idToIndexMap, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<ExtractLinkedEntitiesResultCollection> CreateLinkedEntityResponse(Response response, Dictionary<string, int> idToIndexMap) =>
            Response.FromValue(TextAnalyticsServiceSerializer.DeserializeLinkedEntityResponse(response.ContentStream, idToIndexMap), response);

        #endregion

        private void BuildUriForRoute(string route, RequestUriBuilder builder, TextAnalysisOptions options)
        {
            builder.Reset(_baseUri);
            builder.AppendPath(TextAnalyticsRoute, escape: false);
            builder.AppendPath(_apiVersion, escape: false);
            builder.AppendPath(route, escape: false);

            if (options.IncludeStatistics)
            {
                builder.AppendQuery(ShowStatistics, "true");
            }

            if (!string.IsNullOrEmpty(options.ModelVersion))
            {
                builder.AppendQuery(ModelVersion, options.ModelVersion);
            }
        }

        #region nobody wants to see these
        /// <summary>
        /// Check if two ConfigurationSetting instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Get a hash code for the ConfigurationSetting
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// Creates a Key Value string in reference to the ConfigurationSetting.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
        #endregion
    }
}
