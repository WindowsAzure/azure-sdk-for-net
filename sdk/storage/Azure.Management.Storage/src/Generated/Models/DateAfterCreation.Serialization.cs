// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class DateAfterCreation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("daysAfterCreationGreaterThan");
            writer.WriteNumberValue(DaysAfterCreationGreaterThan);
            writer.WriteEndObject();
        }
        internal static DateAfterCreation DeserializeDateAfterCreation(JsonElement element)
        {
            DateAfterCreation result = new DateAfterCreation();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysAfterCreationGreaterThan"))
                {
                    result.DaysAfterCreationGreaterThan = property.Value.GetSingle();
                    continue;
                }
            }
            return result;
        }
    }
}
