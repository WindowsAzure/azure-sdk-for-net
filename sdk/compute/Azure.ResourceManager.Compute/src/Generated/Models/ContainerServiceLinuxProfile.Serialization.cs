// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ContainerServiceLinuxProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("adminUsername");
            writer.WriteStringValue(AdminUsername);
            writer.WritePropertyName("ssh");
            writer.WriteObjectValue(Ssh);
            writer.WriteEndObject();
        }

        internal static ContainerServiceLinuxProfile DeserializeContainerServiceLinuxProfile(JsonElement element)
        {
            string adminUsername = default;
            ContainerServiceSshConfiguration ssh = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ssh"))
                {
                    ssh = ContainerServiceSshConfiguration.DeserializeContainerServiceSshConfiguration(property.Value);
                    continue;
                }
            }
            return new ContainerServiceLinuxProfile(adminUsername, ssh);
        }
    }
}
