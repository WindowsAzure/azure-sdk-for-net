// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class DateAfterModification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("daysAfterModificationGreaterThan");
            writer.WriteNumberValue(DaysAfterModificationGreaterThan);
            writer.WriteEndObject();
        }
        internal static DateAfterModification DeserializeDateAfterModification(JsonElement element)
        {
            DateAfterModification result = new DateAfterModification();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysAfterModificationGreaterThan"))
                {
                    result.DaysAfterModificationGreaterThan = property.Value.GetSingle();
                    continue;
                }
            }
            return result;
        }
    }
}
