// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer.Models
{
    public partial class SlotReward : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("slotId");
            writer.WriteStringValue(SlotId);
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            writer.WriteEndObject();
        }
    }
}
