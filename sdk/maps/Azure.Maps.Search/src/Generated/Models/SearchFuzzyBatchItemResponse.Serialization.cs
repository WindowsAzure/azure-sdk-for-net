// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class SearchFuzzyBatchItemResponse
    {
        internal static SearchFuzzyBatchItemResponse DeserializeSearchFuzzyBatchItemResponse(JsonElement element)
        {
            Optional<ErrorDetail> error = default;
            Optional<SearchCommonSummary> summary = default;
            Optional<IReadOnlyList<SearchCommonResult>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("summary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    summary = SearchCommonSummary.DeserializeSearchCommonSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SearchCommonResult> array = new List<SearchCommonResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchCommonResult.DeserializeSearchCommonResult(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new SearchFuzzyBatchItemResponse(summary.Value, Optional.ToList(results), error.Value);
        }
    }
}
