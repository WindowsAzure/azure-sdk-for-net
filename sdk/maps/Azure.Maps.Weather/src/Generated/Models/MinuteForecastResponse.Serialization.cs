// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Weather.Models
{
    public partial class MinuteForecastResponse
    {
        internal static MinuteForecastResponse DeserializeMinuteForecastResponse(JsonElement element)
        {
            Optional<MinuteForecastSummary> summary = default;
            Optional<IReadOnlyList<IntervalSummary>> intervalSummaries = default;
            Optional<IReadOnlyList<ForecastInterval>> intervals = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    summary = MinuteForecastSummary.DeserializeMinuteForecastSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("intervalSummaries"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IntervalSummary> array = new List<IntervalSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntervalSummary.DeserializeIntervalSummary(item));
                    }
                    intervalSummaries = array;
                    continue;
                }
                if (property.NameEquals("intervals"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ForecastInterval> array = new List<ForecastInterval>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ForecastInterval.DeserializeForecastInterval(item));
                    }
                    intervals = array;
                    continue;
                }
            }
            return new MinuteForecastResponse(summary.Value, Optional.ToList(intervalSummaries), Optional.ToList(intervals));
        }
    }
}
