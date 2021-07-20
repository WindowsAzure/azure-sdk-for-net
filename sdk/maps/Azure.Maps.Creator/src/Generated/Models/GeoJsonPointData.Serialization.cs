// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class GeoJsonPointData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("coordinates");
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GeoJsonPointData DeserializeGeoJsonPointData(JsonElement element)
        {
            IList<double> coordinates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    coordinates = array;
                    continue;
                }
            }
            return new GeoJsonPointData(coordinates);
        }
    }
}
