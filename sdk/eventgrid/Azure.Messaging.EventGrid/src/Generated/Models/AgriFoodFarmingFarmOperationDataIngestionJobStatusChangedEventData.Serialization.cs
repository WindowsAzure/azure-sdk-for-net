// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventDataConverter))]
    public partial class AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData
    {
        internal static AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData DeserializeAgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData(JsonElement element)
        {
            Optional<string> farmerId = default;
            Optional<string> message = default;
            Optional<AgriFoodFarmingJobStatus> status = default;
            Optional<DateTimeOffset> lastActionDateTime = default;
            Optional<bool> isCancellationRequested = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("farmerId"))
                {
                    farmerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new AgriFoodFarmingJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isCancellationRequested"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCancellationRequested = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    properties = dictionary;
                    continue;
                }
            }
            return new AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData(farmerId.Value, message.Value, Optional.ToNullable(status), Optional.ToNullable(lastActionDateTime), Optional.ToNullable(isCancellationRequested), id.Value, name.Value, description.Value, Optional.ToNullable(createdDateTime), Optional.ToDictionary(properties));
        }

        internal partial class AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventDataConverter : JsonConverter<AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAgriFoodFarmingFarmOperationDataIngestionJobStatusChangedEventData(document.RootElement);
            }
        }
    }
}
