// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters for filtering, sorting, fuzzy matching, and other
    /// suggestions query behaviors.
    /// </summary>
    public partial class SuggestParametersPayload
    {
        /// <summary>
        /// Initializes a new instance of the SuggestParametersPayload class.
        /// </summary>
        public SuggestParametersPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SuggestParametersPayload class.
        /// </summary>
        /// <param name="filter">The OData $filter expression to apply to the
        /// suggestions query.</param>
        /// <param name="fuzzy">A value indicating whether to use fuzzy
        /// matching for the suggestion query. Default is false. when set to
        /// true, the query will find suggestions even if there's a substituted
        /// or missing character in the search text. While this provides a
        /// better experience in some scenarios it comes at a performance cost
        /// as fuzzy suggestion searches are slower and consume more
        /// resources.</param>
        /// <param name="highlightPostTag">A string tag that is appended to hit
        /// highlights. Must be set with HighlightPreTag. If omitted, hit
        /// highlighting of suggestions is disabled.</param>
        /// <param name="highlightPreTag">A string tag that is prepended to hit
        /// highlights. Must be set with HighlightPostTag. If omitted, hit
        /// highlighting of suggestions is disabled.</param>
        /// <param name="minimumCoverage">A number between 0 and 100 indicating
        /// the percentage of the index that must be covered by a suggestion
        /// query in order for the query to be reported as a success. This
        /// parameter can be useful for ensuring search availability even for
        /// services with only one replica. The default is 80.</param>
        /// <param name="orderBy">The comma-separated list of OData $orderby
        /// expressions by which to sort the results. Each expression can be
        /// either a field name or a call to the geo.distance() function. Each
        /// expression can be followed by asc to indicate ascending, and desc
        /// to indicate descending. The default is ascending order. Ties will
        /// be broken by the match scores of documents. If no OrderBy is
        /// specified, the default sort order is descending by document match
        /// score. There can be at most 32 Orderby clauses.</param>
        /// <param name="search">The search text on which to base
        /// suggestions.</param>
        /// <param name="searchFields">The comma-separated list of field names
        /// to consider when querying for suggestions.</param>
        /// <param name="select">The comma-separated list of fields to
        /// retrieve. If unspecified, all fields marked as retrievable in the
        /// schema are included.</param>
        /// <param name="suggesterName">The name of the suggester as specified
        /// in the suggesters collection that's part of the index
        /// definition.</param>
        /// <param name="top">The number of suggestions to retrieve. This must
        /// be a value between 1 and 100. The default is to 5.</param>
        public SuggestParametersPayload(string filter = default(string), bool? fuzzy = default(bool?), string highlightPostTag = default(string), string highlightPreTag = default(string), double? minimumCoverage = default(double?), string orderBy = default(string), string search = default(string), string searchFields = default(string), string select = default(string), string suggesterName = default(string), int? top = default(int?))
        {
            Filter = filter;
            Fuzzy = fuzzy;
            HighlightPostTag = highlightPostTag;
            HighlightPreTag = highlightPreTag;
            MinimumCoverage = minimumCoverage;
            OrderBy = orderBy;
            Search = search;
            SearchFields = searchFields;
            Select = select;
            SuggesterName = suggesterName;
            Top = top;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the OData $filter expression to apply to the
        /// suggestions query.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use fuzzy matching for
        /// the suggestion query. Default is false. when set to true, the query
        /// will find suggestions even if there's a substituted or missing
        /// character in the search text. While this provides a better
        /// experience in some scenarios it comes at a performance cost as
        /// fuzzy suggestion searches are slower and consume more resources.
        /// </summary>
        [JsonProperty(PropertyName = "fuzzy")]
        public bool? Fuzzy { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is appended to hit highlights. Must
        /// be set with HighlightPreTag. If omitted, hit highlighting of
        /// suggestions is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "highlightPostTag")]
        public string HighlightPostTag { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is prepended to hit highlights. Must
        /// be set with HighlightPostTag. If omitted, hit highlighting of
        /// suggestions is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "highlightPreTag")]
        public string HighlightPreTag { get; set; }

        /// <summary>
        /// Gets or sets a number between 0 and 100 indicating the percentage
        /// of the index that must be covered by a suggestion query in order
        /// for the query to be reported as a success. This parameter can be
        /// useful for ensuring search availability even for services with only
        /// one replica. The default is 80.
        /// </summary>
        [JsonProperty(PropertyName = "minimumCoverage")]
        public double? MinimumCoverage { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of OData $orderby expressions
        /// by which to sort the results. Each expression can be either a field
        /// name or a call to the geo.distance() function. Each expression can
        /// be followed by asc to indicate ascending, and desc to indicate
        /// descending. The default is ascending order. Ties will be broken by
        /// the match scores of documents. If no OrderBy is specified, the
        /// default sort order is descending by document match score. There can
        /// be at most 32 Orderby clauses.
        /// </summary>
        [JsonProperty(PropertyName = "orderby")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets the search text on which to base suggestions.
        /// </summary>
        [JsonProperty(PropertyName = "search")]
        public string Search { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of field names to consider
        /// when querying for suggestions.
        /// </summary>
        [JsonProperty(PropertyName = "searchFields")]
        public string SearchFields { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of fields to retrieve. If
        /// unspecified, all fields marked as retrievable in the schema are
        /// included.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        /// <summary>
        /// Gets or sets the name of the suggester as specified in the
        /// suggesters collection that's part of the index definition.
        /// </summary>
        [JsonProperty(PropertyName = "suggesterName")]
        public string SuggesterName { get; set; }

        /// <summary>
        /// Gets or sets the number of suggestions to retrieve. This must be a
        /// value between 1 and 100. The default is to 5.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }

    }
}
