// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class InstancesSuggestResponse
    {
        internal static InstancesSuggestResponse DeserializeInstancesSuggestResponse(JsonElement element)
        {
            Optional<IReadOnlyList<InstancesSearchStringSuggestion>> suggestions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("suggestions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InstancesSearchStringSuggestion> array = new List<InstancesSearchStringSuggestion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancesSearchStringSuggestion.DeserializeInstancesSearchStringSuggestion(item));
                    }
                    suggestions = array;
                    continue;
                }
            }
            return new InstancesSuggestResponse(Optional.ToList(suggestions));
        }
    }
}
