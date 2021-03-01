// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareAssertion
    {
        internal static HealthcareAssertion DeserializeHealthcareAssertion(JsonElement element)
        {
            Optional<Conditionality> conditionality = default;
            Optional<Certainty> certainty = default;
            Optional<Association> association = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionality"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    conditionality = property.Value.GetString().ToConditionality();
                    continue;
                }
                if (property.NameEquals("certainty"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certainty = property.Value.GetString().ToCertainty();
                    continue;
                }
                if (property.NameEquals("association"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    association = property.Value.GetString().ToAssociation();
                    continue;
                }
            }
            return new HealthcareAssertion(Optional.ToNullable(conditionality), Optional.ToNullable(certainty), Optional.ToNullable(association));
        }
    }
}
