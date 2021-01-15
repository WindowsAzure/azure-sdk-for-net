// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class InstanceHitHighlights
    {
        internal static InstanceHitHighlights DeserializeInstanceHitHighlights(JsonElement element)
        {
            Optional<IReadOnlyList<string>> timeSeriesId = default;
            Optional<string> typeName = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<string>> hierarchyIds = default;
            Optional<IReadOnlyList<string>> hierarchyNames = default;
            Optional<IReadOnlyList<string>> instanceFieldNames = default;
            Optional<IReadOnlyList<string>> instanceFieldValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeSeriesId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    timeSeriesId = array;
                    continue;
                }
                if (property.NameEquals("typeName"))
                {
                    typeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hierarchyIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hierarchyIds = array;
                    continue;
                }
                if (property.NameEquals("hierarchyNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hierarchyNames = array;
                    continue;
                }
                if (property.NameEquals("instanceFieldNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    instanceFieldNames = array;
                    continue;
                }
                if (property.NameEquals("instanceFieldValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    instanceFieldValues = array;
                    continue;
                }
            }
            return new InstanceHitHighlights(Optional.ToList(timeSeriesId), typeName.Value, name.Value, description.Value, Optional.ToList(hierarchyIds), Optional.ToList(hierarchyNames), Optional.ToList(instanceFieldNames), Optional.ToList(instanceFieldValues));
        }
    }
}
