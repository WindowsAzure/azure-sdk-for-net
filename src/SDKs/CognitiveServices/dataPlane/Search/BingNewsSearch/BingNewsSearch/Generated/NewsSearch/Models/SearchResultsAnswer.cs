// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.NewsSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a search result answer.
    /// </summary>
    public partial class SearchResultsAnswer : Answer
    {
        /// <summary>
        /// Initializes a new instance of the SearchResultsAnswer class.
        /// </summary>
        public SearchResultsAnswer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchResultsAnswer class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="totalEstimatedMatches">The estimated number of
        /// webpages that are relevant to the query. Use this number along with
        /// the count and offset query parameters to page the results.</param>
        public SearchResultsAnswer(string id = default(string), string webSearchUrl = default(string), IList<Query> followUpQueries = default(IList<Query>), long? totalEstimatedMatches = default(long?))
            : base(id, webSearchUrl, followUpQueries)
        {
            TotalEstimatedMatches = totalEstimatedMatches;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the estimated number of webpages that are relevant to the
        /// query. Use this number along with the count and offset query
        /// parameters to page the results.
        /// </summary>
        [JsonProperty(PropertyName = "totalEstimatedMatches")]
        public long? TotalEstimatedMatches { get; private set; }

    }
}
