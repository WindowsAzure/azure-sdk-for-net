// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class AzureAppPushReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("emailAddress");
            writer.WriteStringValue(EmailAddress);
            writer.WriteEndObject();
        }

        internal static AzureAppPushReceiver DeserializeAzureAppPushReceiver(JsonElement element)
        {
            string name = default;
            string emailAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailAddress"))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
            }
            return new AzureAppPushReceiver(name, emailAddress);
        }
    }
}
