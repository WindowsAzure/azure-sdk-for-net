// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class AnalyzeOperationResult_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToSerialString());
            writer.WritePropertyName("createdDateTime");
            writer.WriteStringValue(CreatedDateTime, "S");
            writer.WritePropertyName("lastUpdatedDateTime");
            writer.WriteStringValue(LastUpdatedDateTime, "S");
            if (AnalyzeResult != null)
            {
                writer.WritePropertyName("analyzeResult");
                writer.WriteObjectValue(AnalyzeResult);
            }
            writer.WriteEndObject();
        }
        internal static AnalyzeOperationResult_internal DeserializeAnalyzeOperationResult_internal(JsonElement element)
        {
            AnalyzeOperationResult_internal result = new AnalyzeOperationResult_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    result.Status = property.Value.GetString().ToOperationStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    result.CreatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"))
                {
                    result.LastUpdatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("analyzeResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AnalyzeResult = AnalyzeResult_internal.DeserializeAnalyzeResult_internal(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
