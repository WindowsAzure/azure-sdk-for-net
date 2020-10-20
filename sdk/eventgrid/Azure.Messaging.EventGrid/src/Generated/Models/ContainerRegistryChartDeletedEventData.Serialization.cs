// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ContainerRegistryChartDeletedEventData
    {
        internal static ContainerRegistryChartDeletedEventData DeserializeContainerRegistryChartDeletedEventData(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> action = default;
            Optional<ContainerRegistryArtifactEventTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = ContainerRegistryArtifactEventTarget.DeserializeContainerRegistryArtifactEventTarget(property.Value);
                    continue;
                }
            }
            return new ContainerRegistryChartDeletedEventData(id.Value, Optional.ToNullable(timestamp), action.Value, target.Value);
        }
    }
}
