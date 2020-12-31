// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RunCommandParameterDefinition
    {
        internal static RunCommandParameterDefinition DeserializeRunCommandParameterDefinition(JsonElement element)
        {
            string name = default;
            string type = default;
            Optional<string> defaultValue = default;
            Optional<bool> required = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RunCommandParameterDefinition(name, type, defaultValue.Value, Optional.ToNullable(required));
        }
    }
}
