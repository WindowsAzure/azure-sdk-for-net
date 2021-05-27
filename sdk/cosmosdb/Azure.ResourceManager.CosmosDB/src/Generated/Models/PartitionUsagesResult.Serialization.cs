// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class PartitionUsagesResult
    {
        internal static PartitionUsagesResult DeserializePartitionUsagesResult(JsonElement element)
        {
            Optional<IReadOnlyList<PartitionUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PartitionUsage> array = new List<PartitionUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PartitionUsage.DeserializePartitionUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PartitionUsagesResult(Optional.ToList(value));
        }
    }
}
