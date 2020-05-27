// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayFirewallExclusion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable");
            writer.WriteStringValue(MatchVariable);
            writer.WritePropertyName("selectorMatchOperator");
            writer.WriteStringValue(SelectorMatchOperator);
            writer.WritePropertyName("selector");
            writer.WriteStringValue(Selector);
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayFirewallExclusion DeserializeApplicationGatewayFirewallExclusion(JsonElement element)
        {
            string matchVariable = default;
            string selectorMatchOperator = default;
            string selector = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"))
                {
                    matchVariable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"))
                {
                    selectorMatchOperator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selector"))
                {
                    selector = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayFirewallExclusion(matchVariable, selectorMatchOperator, selector);
        }
    }
}
