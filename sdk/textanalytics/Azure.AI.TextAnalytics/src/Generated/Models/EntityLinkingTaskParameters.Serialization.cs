// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityLinkingTaskParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("model-version");
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType");
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
