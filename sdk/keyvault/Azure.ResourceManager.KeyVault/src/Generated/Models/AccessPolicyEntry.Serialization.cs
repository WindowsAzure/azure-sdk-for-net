// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class AccessPolicyEntry : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tenantId");
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("objectId");
            writer.WriteStringValue(ObjectId);
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId");
                writer.WriteStringValue(ApplicationId.Value);
            }
            writer.WritePropertyName("permissions");
            writer.WriteObjectValue(Permissions);
            writer.WriteEndObject();
        }

        internal static AccessPolicyEntry DeserializeAccessPolicyEntry(JsonElement element)
        {
            Guid tenantId = default;
            string objectId = default;
            Optional<Guid> applicationId = default;
            Permissions permissions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("permissions"))
                {
                    permissions = Permissions.DeserializePermissions(property.Value);
                    continue;
                }
            }
            return new AccessPolicyEntry(tenantId, objectId, Optional.ToNullable(applicationId), permissions);
        }
    }
}
