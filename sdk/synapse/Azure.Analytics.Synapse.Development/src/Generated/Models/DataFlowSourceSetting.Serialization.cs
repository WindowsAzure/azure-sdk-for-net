// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Development.Models
{
    public partial class DataFlowSourceSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SourceName != null)
            {
                writer.WritePropertyName("sourceName");
                writer.WriteStringValue(SourceName);
            }
            if (RowLimit != null)
            {
                writer.WritePropertyName("rowLimit");
                writer.WriteNumberValue(RowLimit.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
    }
}
