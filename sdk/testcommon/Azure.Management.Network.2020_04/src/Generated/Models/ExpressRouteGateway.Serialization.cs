// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteGateway : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoScaleConfiguration))
            {
                writer.WritePropertyName("autoScaleConfiguration");
                writer.WriteObjectValue(AutoScaleConfiguration);
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                writer.WriteObjectValue(VirtualHub);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteGateway DeserializeExpressRouteGateway(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<ExpressRouteGatewayPropertiesAutoScaleConfiguration> autoScaleConfiguration = default;
            Optional<IList<ExpressRouteConnection>> expressRouteConnections = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<VirtualHubId> virtualHub = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("autoScaleConfiguration"))
                        {
                            autoScaleConfiguration = ExpressRouteGatewayPropertiesAutoScaleConfiguration.DeserializeExpressRouteGatewayPropertiesAutoScaleConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expressRouteConnections"))
                        {
                            List<ExpressRouteConnection> array = new List<ExpressRouteConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnection.DeserializeExpressRouteConnection(item));
                            }
                            expressRouteConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"))
                        {
                            virtualHub = VirtualHubId.DeserializeVirtualHubId(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteGateway(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, autoScaleConfiguration.Value, Optional.ToList(expressRouteConnections), Optional.ToNullable(provisioningState), virtualHub.Value);
        }
    }
}
