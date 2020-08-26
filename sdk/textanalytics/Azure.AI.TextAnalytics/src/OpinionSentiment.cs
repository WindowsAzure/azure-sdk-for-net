﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Contains the predicted sentiment, confidence scores, and other information about the opinion of an aspect.
    /// For example, in the sentence "The food is good", the opinion of the
    /// aspect 'food' is 'good'.
    /// </summary>
    public readonly struct OpinionSentiment
    {
        internal OpinionSentiment(TextSentiment sentiment, double positiveScore, double negativeScore, string text, bool isNegated)
        {
            Sentiment = sentiment;
            ConfidenceScores = new SentimentConfidenceScores(positiveScore, 0d, negativeScore);
            Text = text;
            IsNegated = isNegated;
        }

        internal OpinionSentiment(SentenceOpinion opinion)
        {
            Text = opinion.Text;
            ConfidenceScores = new SentimentConfidenceScores(opinion.ConfidenceScores.Positive, 0d, opinion.ConfidenceScores.Negative);
            Sentiment = (TextSentiment)Enum.Parse(typeof(TextSentiment), opinion.Sentiment, ignoreCase: true);
            IsNegated = opinion.IsNegated;
        }

        /// <summary>
        /// Gets the predicted Sentiment for the opinion. Possible values
        /// include 'positive', 'mixed', and 'negative'.
        /// </summary>
        public TextSentiment Sentiment { get; }

        /// <summary>
        /// Gets the sentiment confidence score (Softmax score) between 0 and 1,
        /// for the opinion for 'positive' and 'negative' labels. Its score
        /// for 'neutral' will always be 0.
        /// Higher values signify higher confidence.
        /// </summary>
        public SentimentConfidenceScores ConfidenceScores { get; }

        /// <summary>
        /// Gets the opinion text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Whether the opinion is negated. For example, in
        /// "The food is not good", the opinion "good" is negated.
        /// </summary>
        public bool IsNegated { get; }
    }
}
