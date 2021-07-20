// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class BooleanTypeStyleRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rules");
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("keyName");
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WriteEndObject();
        }

        internal static BooleanTypeStyleRule DeserializeBooleanTypeStyleRule(JsonElement element)
        {
            IList<BooleanRuleObject> rules = default;
            string keyName = default;
            StyleObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"))
                {
                    List<BooleanRuleObject> array = new List<BooleanRuleObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BooleanRuleObject.DeserializeBooleanRuleObject(item));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new StyleObjectType(property.Value.GetString());
                    continue;
                }
            }
            return new BooleanTypeStyleRule(keyName, type, rules);
        }
    }
}
