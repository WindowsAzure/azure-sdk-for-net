// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class DeleteRetentionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Days))
            {
                writer.WritePropertyName("days");
                writer.WriteNumberValue(Days.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeleteRetentionPolicy DeserializeDeleteRetentionPolicy(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<int> days = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("days"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    days = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeleteRetentionPolicy(Optional.ToNullable(enabled), Optional.ToNullable(days));
        }
    }
}
