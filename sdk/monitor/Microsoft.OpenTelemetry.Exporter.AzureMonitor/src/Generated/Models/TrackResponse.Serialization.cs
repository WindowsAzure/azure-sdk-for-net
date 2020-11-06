// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    public partial class TrackResponse
    {
        internal static TrackResponse DeserializeTrackResponse(JsonElement element)
        {
            Optional<int> itemsReceived = default;
            Optional<int> itemsAccepted = default;
            Optional<IReadOnlyList<TelemetryErrorDetails>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("itemsReceived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    itemsReceived = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("itemsAccepted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    itemsAccepted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TelemetryErrorDetails> array = new List<TelemetryErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TelemetryErrorDetails.DeserializeTelemetryErrorDetails(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new TrackResponse(Optional.ToNullable(itemsReceived), Optional.ToNullable(itemsAccepted), Optional.ToList(errors));
        }
    }
}
