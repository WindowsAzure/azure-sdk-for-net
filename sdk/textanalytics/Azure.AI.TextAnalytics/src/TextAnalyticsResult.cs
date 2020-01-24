﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Net.Http.Headers;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Base type for results of text analytics operations corresponding to a
    /// single input document.  If the operation is unsuccessful, the Id and
    /// ErrorMessage fields will be populated, but not others.
    /// </summary>
    public class TextAnalyticsResult
    {
        internal TextAnalyticsResult(string id, TextDocumentStatistics statistics)
        {
            Id = id;
            Statistics = statistics;
        }

        internal TextAnalyticsResult(string id, TextAnalyticsError error)
        {
            Id = id;
            Error = error;
        }

        /// <summary>
        /// Gets the unique identifier for the input document that generated
        /// the result.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets statistics about the input document and how it was processed by
        /// the service.  This property will have a value when IncludeStatistics
        /// is set to true in the client call.
        /// </summary>
        public TextDocumentStatistics Statistics { get; }

        /// <summary>
        /// Gets the error message explaining why the operation failed on this
        /// document.  This property will have a value only when the document
        /// cannot be processed.
        /// </summary>
        public TextAnalyticsError Error { get; }

        /// <summary>
        /// Indicates that the input text was not successfully processed and an error was returned for this document.
        /// </summary>
        public bool HasError => Error.ErrorCode != default;
    }
}
