// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Development.Models
{
    public partial class StagingSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Path != null)
            {
                writer.WritePropertyName("path");
                writer.WriteObjectValue(Path);
            }
            if (EnableCompression != null)
            {
                writer.WritePropertyName("enableCompression");
                writer.WriteObjectValue(EnableCompression);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static StagingSettings DeserializeStagingSettings(JsonElement element)
        {
            LinkedServiceReference linkedServiceName = default;
            object path = default;
            object enableCompression = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    path = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enableCompression"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCompression = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new StagingSettings(linkedServiceName, path, enableCompression, additionalProperties);
        }
    }
}
