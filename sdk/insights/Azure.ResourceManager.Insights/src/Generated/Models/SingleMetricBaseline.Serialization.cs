// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class SingleMetricBaseline
    {
        internal static SingleMetricBaseline DeserializeSingleMetricBaseline(JsonElement element)
        {
            string id = default;
            string type = default;
            string name = default;
            string timespan = default;
            TimeSpan interval = default;
            Optional<string> @namespace = default;
            IReadOnlyList<TimeSeriesBaseline> baselines = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("timespan"))
                        {
                            timespan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interval"))
                        {
                            interval = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("namespace"))
                        {
                            @namespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baselines"))
                        {
                            List<TimeSeriesBaseline> array = new List<TimeSeriesBaseline>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TimeSeriesBaseline.DeserializeTimeSeriesBaseline(item));
                            }
                            baselines = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SingleMetricBaseline(id, type, name, timespan, interval, @namespace.Value, baselines);
        }
    }
}
