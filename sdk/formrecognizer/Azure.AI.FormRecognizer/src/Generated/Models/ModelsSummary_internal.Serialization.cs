// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    internal partial class ModelsSummary_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("count");
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("limit");
            writer.WriteNumberValue(Limit);
            writer.WritePropertyName("lastUpdatedDateTime");
            writer.WriteStringValue(LastUpdatedDateTime, "S");
            writer.WriteEndObject();
        }
        internal static ModelsSummary_internal DeserializeModelsSummary_internal(JsonElement element)
        {
            ModelsSummary_internal result = new ModelsSummary_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    result.Count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    result.Limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"))
                {
                    result.LastUpdatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
            }
            return result;
        }
    }
}
