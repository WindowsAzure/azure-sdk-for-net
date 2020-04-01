// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSessionState
    {
        internal static SparkSessionState DeserializeSparkSessionState(JsonElement element)
        {
            DateTimeOffset? notStartedAt = default;
            DateTimeOffset? startingAt = default;
            DateTimeOffset? idleAt = default;
            DateTimeOffset? deadAt = default;
            DateTimeOffset? shuttingDownAt = default;
            DateTimeOffset? killedAt = default;
            DateTimeOffset? recoveringAt = default;
            DateTimeOffset? busyAt = default;
            DateTimeOffset? errorAt = default;
            string currentState = default;
            SparkRequest jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notStartedAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("startingAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startingAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("idleAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("deadAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("shuttingDownAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shuttingDownAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("killedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    killedAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("recoveringAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveringAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("busyAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    busyAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("errorAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorAt = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkSessionState(notStartedAt, startingAt, idleAt, deadAt, shuttingDownAt, killedAt, recoveringAt, busyAt, errorAt, currentState, jobCreationRequest);
        }
    }
}
