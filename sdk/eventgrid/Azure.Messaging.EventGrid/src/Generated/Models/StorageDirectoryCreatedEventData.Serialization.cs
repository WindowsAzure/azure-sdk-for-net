// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageDirectoryCreatedEventDataConverter))]
    public partial class StorageDirectoryCreatedEventData
    {
        internal static StorageDirectoryCreatedEventData DeserializeStorageDirectoryCreatedEventData(JsonElement element)
        {
            Optional<string> api = default;
            Optional<string> clientRequestId = default;
            Optional<string> requestId = default;
            Optional<string> eTag = default;
            Optional<string> url = default;
            Optional<string> sequencer = default;
            Optional<string> identity = default;
            Optional<object> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageDirectoryCreatedEventData(api.Value, clientRequestId.Value, requestId.Value, eTag.Value, url.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }

        internal partial class StorageDirectoryCreatedEventDataConverter : JsonConverter<StorageDirectoryCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageDirectoryCreatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StorageDirectoryCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageDirectoryCreatedEventData(document.RootElement);
            }
        }
    }
}
