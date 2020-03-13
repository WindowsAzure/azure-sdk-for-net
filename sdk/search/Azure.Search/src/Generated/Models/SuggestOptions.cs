// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search
{
    /// <summary> Parameters for filtering, sorting, fuzzy matching, and other suggestions query behaviors. </summary>
    public partial class SuggestOptions
    {
        /// <summary> A value indicating whether to use fuzzy matching for the suggestion query. Default is false. When set to true, the query will find suggestions even if there&apos;s a substituted or missing character in the search text. While this provides a better experience in some scenarios, it comes at a performance cost as fuzzy suggestion searches are slower and consume more resources. </summary>
        public bool? UseFuzzyMatching { get; set; }
        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. If omitted, hit highlighting of suggestions is disabled. </summary>
        public string HighlightPostTag { get; set; }
        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. If omitted, hit highlighting of suggestions is disabled. </summary>
        public string HighlightPreTag { get; set; }
        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by a suggestion query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 80. </summary>
        public double? MinimumCoverage { get; set; }
    }
}
