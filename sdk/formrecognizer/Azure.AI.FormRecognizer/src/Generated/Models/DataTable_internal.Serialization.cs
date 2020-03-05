// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class DataTable_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rows");
            writer.WriteNumberValue(Rows);
            writer.WritePropertyName("columns");
            writer.WriteNumberValue(Columns);
            writer.WritePropertyName("cells");
            writer.WriteStartArray();
            foreach (var item in Cells)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
        internal static DataTable_internal DeserializeDataTable_internal(JsonElement element)
        {
            DataTable_internal result = new DataTable_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"))
                {
                    result.Rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"))
                {
                    result.Columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Cells.Add(DataTableCell_internal.DeserializeDataTableCell_internal(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
