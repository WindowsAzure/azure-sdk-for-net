﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The predicted sentiment for a given span of text.
    /// For more information regarding text sentiment, see
    /// <a href="https://docs.microsoft.com/en-us/azure/cognitive-services/Text-Analytics/how-tos/text-analytics-how-to-sentiment-analysis"/>.
    /// </summary>
    public readonly struct SentenceSentiment
    {
        internal SentenceSentiment(TextSentiment sentiment, string text, double positiveScore, double neutralScore, double negativeScore, int offset, IReadOnlyList<MinedOpinion> minedOpinions)
        {
            Sentiment = sentiment;
            Text = text;
            ConfidenceScores = new SentimentConfidenceScores(positiveScore, neutralScore, negativeScore);
            Offset = offset;
            MinedOpinions = new List<MinedOpinion>(minedOpinions);
        }

        internal SentenceSentiment(SentenceSentimentInternal sentenceSentiment, IReadOnlyList<SentenceSentimentInternal> allSentences)
        {
            // We shipped TA 5.0.0 Text == string.Empty if the service returned a null value for Text.
            // Because we don't want to introduce a breaking change, we are transforming that null to string.Empty
            Text = sentenceSentiment.Text ?? string.Empty;

            ConfidenceScores = sentenceSentiment.ConfidenceScores;
            Sentiment = (TextSentiment)Enum.Parse(typeof(TextSentiment), sentenceSentiment.Sentiment, ignoreCase: true);
            MinedOpinions = ConvertToMinedOpinions(sentenceSentiment, allSentences);
            Offset = sentenceSentiment.Offset;
        }

        /// <summary>
        /// Gets the predicted sentiment for the analyzed sentence.
        /// </summary>
        public TextSentiment Sentiment { get; }

        /// <summary>
        /// Gets the sentence text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the sentiment confidence score (Softmax score) between 0 and 1,
        /// for each sentiment. Higher values signify higher confidence.
        /// </summary>
        public SentimentConfidenceScores ConfidenceScores { get; }

        /// <summary>
        /// Gets the mined opinions of a sentence. This is only returned if
        /// <see cref="AdditionalSentimentAnalyses.OpinionMining"/> is set in <see cref="AnalyzeSentimentOptions.AdditionalSentimentAnalyses"/>.
        /// </summary>
        public IReadOnlyCollection<MinedOpinion> Opinions { get; }

        /// <summary>
        /// Gets the starting position (in UTF-16 code units) for the matching text in the sentence.
        /// </summary>
        public int Offset { get; }

        private static IReadOnlyCollection<MinedOpinion> ConvertToMinedOpinions(SentenceSentimentInternal sentence, IReadOnlyList<SentenceSentimentInternal> allSentences)
        {
            var minedOpinions = new List<MinedOpinion>();

            foreach (SentenceAspect aspects in sentence.Aspects)
            {
                var opinions = new List<OpinionDescriptionSentiment>();
                foreach (AspectRelation relation in aspects.Relations)
                {
                    if (relation.RelationType == AspectRelationType.Opinion)
                    {
                        opinions.Add(ResolveOpinionReference(allSentences, relation.Ref));
                    }
                }
                minedOpinions.Add(new MinedOpinion(new OpinionTargetSentiment(aspects), opinions));
            }

            return minedOpinions;
        }

        private static Regex _opinionRegex = new Regex(@"/documents/(?<documentIndex>\d*)/sentences/(?<sentenceIndex>\d*)/opinions/(?<opinionIndex>\d*)$", RegexOptions.Compiled, TimeSpan.FromSeconds(2));
        internal static OpinionDescriptionSentiment ResolveOpinionReference(IReadOnlyList<SentenceSentimentInternal> sentences, string reference)
        {
            // Example: the following should result in sentenceIndex = 2, opinionIndex = 1. There will not be cases where sentences from other documents are referenced.
            // "#/documents/0/sentences/2/opinions/1"

            var opinionMatch = _opinionRegex.Match(reference);
            if (opinionMatch.Success && opinionMatch.Groups.Count == 4)
            {
                int sentenceIndex = int.Parse(opinionMatch.Groups["sentenceIndex"].Value, CultureInfo.InvariantCulture);
                int opinionIndex = int.Parse(opinionMatch.Groups["opinionIndex"].Value, CultureInfo.InvariantCulture);

                if (sentenceIndex < sentences.Count)
                {
                    if (opinionIndex < sentences[sentenceIndex].Opinions.Count)
                    {
                        return new OpinionDescriptionSentiment(sentences[sentenceIndex].Opinions[opinionIndex]);
                    }
                }
            }

            throw new InvalidOperationException($"Failed to parse element reference: {reference}");
        }
    }
}
