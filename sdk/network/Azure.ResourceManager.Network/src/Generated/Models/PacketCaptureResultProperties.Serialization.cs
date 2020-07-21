// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureResultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("target");
            writer.WriteStringValue(Target);
            if (Optional.IsDefined(BytesToCapturePerPacket))
            {
                writer.WritePropertyName("bytesToCapturePerPacket");
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (Optional.IsDefined(TotalBytesPerSession))
            {
                writer.WritePropertyName("totalBytesPerSession");
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (Optional.IsDefined(TimeLimitInSeconds))
            {
                writer.WritePropertyName("timeLimitInSeconds");
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            writer.WritePropertyName("storageLocation");
            writer.WriteObjectValue(StorageLocation);
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters");
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PacketCaptureResultProperties DeserializePacketCaptureResultProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            string target = default;
            Optional<int> bytesToCapturePerPacket = default;
            Optional<int> totalBytesPerSession = default;
            Optional<int> timeLimitInSeconds = default;
            PacketCaptureStorageLocation storageLocation = default;
            Optional<IList<PacketCaptureFilter>> filters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bytesToCapturePerPacket"))
                {
                    bytesToCapturePerPacket = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalBytesPerSession"))
                {
                    totalBytesPerSession = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeLimitInSeconds"))
                {
                    timeLimitInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageLocation"))
                {
                    storageLocation = PacketCaptureStorageLocation.DeserializePacketCaptureStorageLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("filters"))
                {
                    List<PacketCaptureFilter> array = new List<PacketCaptureFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PacketCaptureFilter.DeserializePacketCaptureFilter(item));
                    }
                    filters = array;
                    continue;
                }
            }
            return new PacketCaptureResultProperties(target, Optional.ToNullable(bytesToCapturePerPacket), Optional.ToNullable(totalBytesPerSession), Optional.ToNullable(timeLimitInSeconds), storageLocation, Optional.ToList(filters), Optional.ToNullable(provisioningState));
        }
    }
}
