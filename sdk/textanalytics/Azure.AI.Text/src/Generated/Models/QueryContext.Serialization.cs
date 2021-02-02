// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Text.Models
{
    public partial class QueryContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreviousQnaId))
            {
                writer.WritePropertyName("previousQnaId");
                writer.WriteNumberValue(PreviousQnaId.Value);
            }
            if (Optional.IsDefined(PreviousUserQuery))
            {
                writer.WritePropertyName("previousUserQuery");
                writer.WriteStringValue(PreviousUserQuery);
            }
            writer.WriteEndObject();
        }
    }
}
