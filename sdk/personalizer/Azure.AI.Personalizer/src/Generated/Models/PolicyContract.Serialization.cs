// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer.Models
{
    public partial class PolicyContract : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("arguments");
            writer.WriteStringValue(Arguments);
            writer.WriteEndObject();
        }

        internal static PolicyContract DeserializePolicyContract(JsonElement element)
        {
            string name = default;
            string arguments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"))
                {
                    arguments = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyContract(name, arguments);
        }
    }
}
