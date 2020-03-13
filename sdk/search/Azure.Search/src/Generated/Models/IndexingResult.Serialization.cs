// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class IndexingResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("key");
            writer.WriteStringValue(Key);
            if (ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage");
                writer.WriteStringValue(ErrorMessage);
            }
            writer.WritePropertyName("status");
            writer.WriteBooleanValue(Succeeded);
            writer.WritePropertyName("statusCode");
            writer.WriteNumberValue(Status);
            writer.WriteEndObject();
        }
        internal static IndexingResult DeserializeIndexingResult(JsonElement element)
        {
            IndexingResult result = new IndexingResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    result.Key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    result.Succeeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    result.Status = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}
