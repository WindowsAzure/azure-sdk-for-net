// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class RecurrentSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timeZone");
            writer.WriteStringValue(TimeZone);
            writer.WritePropertyName("days");
            writer.WriteStartArray();
            foreach (var item in Days)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("hours");
            writer.WriteStartArray();
            foreach (var item in Hours)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("minutes");
            writer.WriteStartArray();
            foreach (var item in Minutes)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static RecurrentSchedule DeserializeRecurrentSchedule(JsonElement element)
        {
            string timeZone = default;
            IList<string> days = default;
            IList<int> hours = default;
            IList<int> minutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeZone"))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("days"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    days = array;
                    continue;
                }
                if (property.NameEquals("hours"))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    hours = array;
                    continue;
                }
                if (property.NameEquals("minutes"))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    minutes = array;
                    continue;
                }
            }
            return new RecurrentSchedule(timeZone, days, hours, minutes);
        }
    }
}
