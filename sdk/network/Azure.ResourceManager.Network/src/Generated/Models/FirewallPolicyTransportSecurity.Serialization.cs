// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyTransportSecurity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateAuthority))
            {
                writer.WritePropertyName("certificateAuthority");
                writer.WriteObjectValue(CertificateAuthority);
            }
            if (Optional.IsCollectionDefined(ExcludedDomains))
            {
                writer.WritePropertyName("excludedDomains");
                writer.WriteStartArray();
                foreach (var item in ExcludedDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrustedRootCertificates))
            {
                writer.WritePropertyName("trustedRootCertificates");
                writer.WriteStartArray();
                foreach (var item in TrustedRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyTransportSecurity DeserializeFirewallPolicyTransportSecurity(JsonElement element)
        {
            Optional<FirewallPolicyCertificateAuthority> certificateAuthority = default;
            Optional<IList<string>> excludedDomains = default;
            Optional<IList<FirewallPolicyTrustedRootCertificate>> trustedRootCertificates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateAuthority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificateAuthority = FirewallPolicyCertificateAuthority.DeserializeFirewallPolicyCertificateAuthority(property.Value);
                    continue;
                }
                if (property.NameEquals("excludedDomains"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedDomains = array;
                    continue;
                }
                if (property.NameEquals("trustedRootCertificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FirewallPolicyTrustedRootCertificate> array = new List<FirewallPolicyTrustedRootCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyTrustedRootCertificate.DeserializeFirewallPolicyTrustedRootCertificate(item));
                    }
                    trustedRootCertificates = array;
                    continue;
                }
            }
            return new FirewallPolicyTransportSecurity(certificateAuthority.Value, Optional.ToList(excludedDomains), Optional.ToList(trustedRootCertificates));
        }
    }
}
