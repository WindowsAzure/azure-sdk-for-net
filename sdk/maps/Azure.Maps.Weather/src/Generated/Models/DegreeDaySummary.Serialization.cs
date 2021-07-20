// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Weather.Models
{
    public partial class DegreeDaySummary
    {
        internal static DegreeDaySummary DeserializeDegreeDaySummary(JsonElement element)
        {
            Optional<WeatherUnit> heating = default;
            Optional<WeatherUnit> cooling = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("heating"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    heating = WeatherUnit.DeserializeWeatherUnit(property.Value);
                    continue;
                }
                if (property.NameEquals("cooling"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cooling = WeatherUnit.DeserializeWeatherUnit(property.Value);
                    continue;
                }
            }
            return new DegreeDaySummary(heating.Value, cooling.Value);
        }
    }
}
