﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The result of the extract key phrases operation on a single document,
    /// containing a collection of the key phrases identified in that document.
    /// </summary>
    public class ExtractKeyPhrasesResult : TextAnalyticsResult
    {
        private ReadOnlyCollection<string> _keyPhrases;

        internal ExtractKeyPhrasesResult(string id, TextDocumentStatistics statistics, IList<string> keyPhrases)
            : base(id, statistics)
        {
            _keyPhrases = new ReadOnlyCollection<string>(keyPhrases);
        }

        internal ExtractKeyPhrasesResult(string id, TextAnalyticsError error)
            : base(id, error)
        {
        }

        /// <summary>
        /// Gets the collection of key phrases identified in the input document.
        /// </summary>
        public IReadOnlyCollection<string> KeyPhrases
        {
            get
            {
                if (Error.ErrorCode != default)
                {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                    throw new InvalidOperationException($"Cannot access result for this document, due to error {Error.ErrorCode}: {Error.Message}");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
                }
                return _keyPhrases;
            }
        }
    }
}
