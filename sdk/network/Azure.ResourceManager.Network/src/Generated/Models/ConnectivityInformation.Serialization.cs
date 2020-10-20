// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityInformation
    {
        internal static ConnectivityInformation DeserializeConnectivityInformation(JsonElement element)
        {
            Optional<IReadOnlyList<ConnectivityHop>> hops = default;
            Optional<ConnectionStatus> connectionStatus = default;
            Optional<int> avgLatencyInMs = default;
            Optional<int> minLatencyInMs = default;
            Optional<int> maxLatencyInMs = default;
            Optional<int> probesSent = default;
            Optional<int> probesFailed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hops"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectivityHop> array = new List<ConnectivityHop>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityHop.DeserializeConnectivityHop(item));
                    }
                    hops = array;
                    continue;
                }
                if (property.NameEquals("connectionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectionStatus = new ConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("avgLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    avgLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesSent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    probesSent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesFailed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    probesFailed = property.Value.GetInt32();
                    continue;
                }
            }
            return new ConnectivityInformation(Optional.ToList(hops), Optional.ToNullable(connectionStatus), Optional.ToNullable(avgLatencyInMs), Optional.ToNullable(minLatencyInMs), Optional.ToNullable(maxLatencyInMs), Optional.ToNullable(probesSent), Optional.ToNullable(probesFailed));
        }
    }
}
