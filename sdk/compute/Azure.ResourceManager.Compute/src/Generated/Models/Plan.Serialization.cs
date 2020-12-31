// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class Plan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher");
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product");
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(PromotionCode))
            {
                writer.WritePropertyName("promotionCode");
                writer.WriteStringValue(PromotionCode);
            }
            writer.WriteEndObject();
        }

        internal static Plan DeserializePlan(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> publisher = default;
            Optional<string> product = default;
            Optional<string> promotionCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product"))
                {
                    product = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("promotionCode"))
                {
                    promotionCode = property.Value.GetString();
                    continue;
                }
            }
            return new Plan(name.Value, publisher.Value, product.Value, promotionCode.Value);
        }
    }
}
