// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class BlobRestoreRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startRange");
            writer.WriteStringValue(StartRange);
            writer.WritePropertyName("endRange");
            writer.WriteStringValue(EndRange);
            writer.WriteEndObject();
        }
        internal static BlobRestoreRange DeserializeBlobRestoreRange(JsonElement element)
        {
            BlobRestoreRange result = new BlobRestoreRange();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startRange"))
                {
                    result.StartRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endRange"))
                {
                    result.EndRange = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
