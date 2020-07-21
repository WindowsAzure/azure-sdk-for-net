// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchDocumentsResult
    {
        internal static SearchDocumentsResult DeserializeSearchDocumentsResult(JsonElement element)
        {
            Optional<long> odataCount = default;
            Optional<double> searchCoverage = default;
            Optional<IReadOnlyDictionary<string, IList<FacetResult>>> searchFacets = default;
            Optional<SearchOptions> searchNextPageParameters = default;
            IReadOnlyList<SearchResult> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.count"))
                {
                    odataCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.coverage"))
                {
                    searchCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.facets"))
                {
                    Dictionary<string, IList<FacetResult>> dictionary = new Dictionary<string, IList<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<FacetResult> array = new List<FacetResult>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(FacetResult.DeserializeFacetResult(item));
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    searchFacets = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.nextPageParameters"))
                {
                    searchNextPageParameters = SearchOptions.DeserializeSearchOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<SearchResult> array = new List<SearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchResult.DeserializeSearchResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SearchDocumentsResult(Optional.ToNullable(odataCount), Optional.ToNullable(searchCoverage), Optional.ToDictionary(searchFacets), searchNextPageParameters.Value, value, odataNextLink.Value);
        }
    }
}
