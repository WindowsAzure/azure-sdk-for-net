// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobTarget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MembershipType))
            {
                writer.WritePropertyName("membershipType");
                writer.WriteStringValue(MembershipType.Value.ToSerialString());
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName");
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName");
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName");
                writer.WriteStringValue(ElasticPoolName);
            }
            if (Optional.IsDefined(ShardMapName))
            {
                writer.WritePropertyName("shardMapName");
                writer.WriteStringValue(ShardMapName);
            }
            if (Optional.IsDefined(RefreshCredential))
            {
                writer.WritePropertyName("refreshCredential");
                writer.WriteStringValue(RefreshCredential);
            }
            writer.WriteEndObject();
        }

        internal static JobTarget DeserializeJobTarget(JsonElement element)
        {
            Optional<JobTargetGroupMembershipType> membershipType = default;
            JobTargetType type = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            Optional<string> elasticPoolName = default;
            Optional<string> shardMapName = default;
            Optional<string> refreshCredential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("membershipType"))
                {
                    membershipType = property.Value.GetString().ToJobTargetGroupMembershipType();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new JobTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticPoolName"))
                {
                    elasticPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardMapName"))
                {
                    shardMapName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshCredential"))
                {
                    refreshCredential = property.Value.GetString();
                    continue;
                }
            }
            return new JobTarget(Optional.ToNullable(membershipType), type, serverName.Value, databaseName.Value, elasticPoolName.Value, shardMapName.Value, refreshCredential.Value);
        }
    }
}
