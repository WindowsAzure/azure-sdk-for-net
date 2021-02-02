// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Text.Models
{
    /// <summary> The DocumentSentiment. </summary>
    internal partial class DocumentSentiment
    {
        /// <summary> Initializes a new instance of DocumentSentiment. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="confidenceScores"/>, <paramref name="sentences"/>, or <paramref name="warnings"/> is null. </exception>
        internal DocumentSentiment(string id, DocumentSentimentValue sentiment, SentimentConfidenceScorePerLabel confidenceScores, IEnumerable<SentenceSentiment> sentences, IEnumerable<TextAnalyticsWarning> warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (confidenceScores == null)
            {
                throw new ArgumentNullException(nameof(confidenceScores));
            }
            if (sentences == null)
            {
                throw new ArgumentNullException(nameof(sentences));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            Id = id;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Sentences = sentences.ToList();
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of DocumentSentiment. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="confidenceScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        internal DocumentSentiment(string id, DocumentSentimentValue sentiment, DocumentStatistics statistics, SentimentConfidenceScorePerLabel confidenceScores, IReadOnlyList<SentenceSentiment> sentences, IReadOnlyList<TextAnalyticsWarning> warnings)
        {
            Id = id;
            Sentiment = sentiment;
            Statistics = statistics;
            ConfidenceScores = confidenceScores;
            Sentences = sentences;
            Warnings = warnings;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </summary>
        public DocumentSentimentValue Sentiment { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
        /// <summary> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </summary>
        public SentimentConfidenceScorePerLabel ConfidenceScores { get; }
        /// <summary> Sentence level sentiment analysis. </summary>
        public IReadOnlyList<SentenceSentiment> Sentences { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<TextAnalyticsWarning> Warnings { get; }
    }
}
