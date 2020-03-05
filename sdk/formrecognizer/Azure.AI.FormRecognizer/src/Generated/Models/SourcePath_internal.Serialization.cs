// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class SourcePath_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Source != null)
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            writer.WriteEndObject();
        }
        internal static SourcePath_internal DeserializeSourcePath_internal(JsonElement element)
        {
            SourcePath_internal result = new SourcePath_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Source = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
