// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class OAuth2PermissionGrant : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OdataType))
            {
                writer.WritePropertyName("odata.type");
                writer.WriteStringValue(OdataType);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId");
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(ConsentType))
            {
                writer.WritePropertyName("consentType");
                writer.WriteStringValue(ConsentType.Value.ToString());
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime);
            }
            if (Optional.IsDefined(ExpiryTime))
            {
                writer.WritePropertyName("expiryTime");
                writer.WriteStringValue(ExpiryTime);
            }
            writer.WriteEndObject();
        }

        internal static OAuth2PermissionGrant DeserializeOAuth2PermissionGrant(JsonElement element)
        {
            Optional<string> odataType = default;
            Optional<string> clientId = default;
            Optional<string> objectId = default;
            Optional<ConsentType> consentType = default;
            Optional<string> principalId = default;
            Optional<string> resourceId = default;
            Optional<string> scope = default;
            Optional<string> startTime = default;
            Optional<string> expiryTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    consentType = new ConsentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTime"))
                {
                    expiryTime = property.Value.GetString();
                    continue;
                }
            }
            return new OAuth2PermissionGrant(odataType.Value, clientId.Value, objectId.Value, Optional.ToNullable(consentType), principalId.Value, resourceId.Value, scope.Value, startTime.Value, expiryTime.Value);
        }
    }
}
