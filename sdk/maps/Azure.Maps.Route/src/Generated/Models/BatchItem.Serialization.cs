// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    public partial class BatchItem
    {
        internal static BatchItem DeserializeBatchItem(JsonElement element)
        {
            Optional<float> statusCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusCode = property.Value.GetSingle();
                    continue;
                }
            }
            return new BatchItem(Optional.ToNullable(statusCode));
        }
    }
}
