// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AutoScaleProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MinNodeCount))
            {
                writer.WritePropertyName("minNodeCount");
                writer.WriteNumberValue(MinNodeCount.Value);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(MaxNodeCount))
            {
                writer.WritePropertyName("maxNodeCount");
                writer.WriteNumberValue(MaxNodeCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static AutoScaleProperties DeserializeAutoScaleProperties(JsonElement element)
        {
            Optional<int> minNodeCount = default;
            Optional<bool> enabled = default;
            Optional<int> maxNodeCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxNodeCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new AutoScaleProperties(Optional.ToNullable(minNodeCount), Optional.ToNullable(enabled), Optional.ToNullable(maxNodeCount));
        }
    }
}
