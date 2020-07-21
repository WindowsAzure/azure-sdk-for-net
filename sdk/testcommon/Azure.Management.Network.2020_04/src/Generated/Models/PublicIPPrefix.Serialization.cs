// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PublicIPPrefix : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (Optional.IsDefined(PublicIPAddressVersion))
            {
                writer.WritePropertyName("publicIPAddressVersion");
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IpTags))
            {
                writer.WritePropertyName("ipTags");
                writer.WriteStartArray();
                foreach (var item in IpTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrefixLength))
            {
                writer.WritePropertyName("prefixLength");
                writer.WriteNumberValue(PrefixLength.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicIPPrefix DeserializePublicIPPrefix(JsonElement element)
        {
            Optional<PublicIPPrefixSku> sku = default;
            Optional<string> etag = default;
            Optional<IList<string>> zones = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IPVersion> publicIPAddressVersion = default;
            Optional<IList<IpTag>> ipTags = default;
            Optional<int> prefixLength = default;
            Optional<string> ipPrefix = default;
            Optional<IList<ReferencedPublicIpAddress>> publicIPAddresses = default;
            Optional<SubResource> loadBalancerFrontendIpConfiguration = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = PublicIPPrefixSku.DeserializePublicIPPrefixSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                        if (property0.NameEquals("publicIPAddressVersion"))
                        {
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipTags"))
                        {
                            List<IpTag> array = new List<IpTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpTag.DeserializeIpTag(item));
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("prefixLength"))
                        {
                            prefixLength = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipPrefix"))
                        {
                            ipPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddresses"))
                        {
                            List<ReferencedPublicIpAddress> array = new List<ReferencedPublicIpAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ReferencedPublicIpAddress.DeserializeReferencedPublicIpAddress(item));
                            }
                            publicIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerFrontendIpConfiguration"))
                        {
                            loadBalancerFrontendIpConfiguration = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicIPPrefix(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), sku.Value, etag.Value, Optional.ToList(zones), Optional.ToNullable(publicIPAddressVersion), Optional.ToList(ipTags), Optional.ToNullable(prefixLength), ipPrefix.Value, Optional.ToList(publicIPAddresses), loadBalancerFrontendIpConfiguration.Value, resourceGuid.Value, Optional.ToNullable(provisioningState));
        }
    }
}
