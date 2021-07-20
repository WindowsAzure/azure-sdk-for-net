// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class GreatCircleDistanceResponseSummary
    {
        internal static GreatCircleDistanceResponseSummary DeserializeGreatCircleDistanceResponseSummary(JsonElement element)
        {
            Optional<SpatialCoordinate> sourcePoint = default;
            Optional<SpatialCoordinate> targetPoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourcePoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourcePoint = SpatialCoordinate.DeserializeSpatialCoordinate(property.Value);
                    continue;
                }
                if (property.NameEquals("targetPoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetPoint = SpatialCoordinate.DeserializeSpatialCoordinate(property.Value);
                    continue;
                }
            }
            return new GreatCircleDistanceResponseSummary(sourcePoint.Value, targetPoint.Value);
        }
    }
}
