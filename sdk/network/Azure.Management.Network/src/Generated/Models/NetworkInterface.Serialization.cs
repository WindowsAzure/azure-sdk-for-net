// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkInterface : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
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
            if (VirtualMachine != null)
            {
                writer.WritePropertyName("virtualMachine");
                writer.WriteObjectValue(VirtualMachine);
            }
            if (NetworkSecurityGroup != null)
            {
                writer.WritePropertyName("networkSecurityGroup");
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (PrivateEndpoint != null)
            {
                writer.WritePropertyName("privateEndpoint");
                writer.WriteObjectValue(PrivateEndpoint);
            }
            if (IpConfigurations != null)
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TapConfigurations != null)
            {
                writer.WritePropertyName("tapConfigurations");
                writer.WriteStartArray();
                foreach (var item in TapConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (MacAddress != null)
            {
                writer.WritePropertyName("macAddress");
                writer.WriteStringValue(MacAddress);
            }
            if (Primary != null)
            {
                writer.WritePropertyName("primary");
                writer.WriteBooleanValue(Primary.Value);
            }
            if (EnableAcceleratedNetworking != null)
            {
                writer.WritePropertyName("enableAcceleratedNetworking");
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (EnableIPForwarding != null)
            {
                writer.WritePropertyName("enableIPForwarding");
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            if (HostedWorkloads != null)
            {
                writer.WritePropertyName("hostedWorkloads");
                writer.WriteStartArray();
                foreach (var item in HostedWorkloads)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkInterface DeserializeNetworkInterface(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            SubResource virtualMachine = default;
            NetworkSecurityGroup networkSecurityGroup = default;
            PrivateEndpoint privateEndpoint = default;
            IList<NetworkInterfaceIPConfiguration> ipConfigurations = default;
            IList<NetworkInterfaceTapConfiguration> tapConfigurations = default;
            NetworkInterfaceDnsSettings dnsSettings = default;
            string macAddress = default;
            bool? primary = default;
            bool? enableAcceleratedNetworking = default;
            bool? enableIPForwarding = default;
            IList<string> hostedWorkloads = default;
            string resourceGuid = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualMachine"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachine = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityGroup = NetworkSecurityGroup.DeserializeNetworkSecurityGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpoint = PrivateEndpoint.DeserializePrivateEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceIPConfiguration> array = new List<NetworkInterfaceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(item));
                                }
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("tapConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceTapConfiguration> array = new List<NetworkInterfaceTapConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(NetworkInterfaceTapConfiguration.DeserializeNetworkInterfaceTapConfiguration(item));
                                }
                            }
                            tapConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = NetworkInterfaceDnsSettings.DeserializeNetworkInterfaceDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("macAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            macAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableIPForwarding"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableIPForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostedWorkloads"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            hostedWorkloads = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkInterface(id, name, type, location, tags, etag, virtualMachine, networkSecurityGroup, privateEndpoint, ipConfigurations, tapConfigurations, dnsSettings, macAddress, primary, enableAcceleratedNetworking, enableIPForwarding, hostedWorkloads, resourceGuid, provisioningState);
        }
    }
}
