// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer.Models
{
    public partial class PolicyResultTotalSummary
    {
        internal static PolicyResultTotalSummary DeserializePolicyResultTotalSummary(JsonElement element)
        {
            Optional<DateTimeOffset> timeStamp = default;
            Optional<float> ipsEstimatorNumerator = default;
            Optional<float> ipsEstimatorDenominator = default;
            Optional<float> snipsEstimatorDenominator = default;
            Optional<TimeSpan> aggregateTimeWindow = default;
            Optional<float> nonZeroProbability = default;
            Optional<float> sumOfSquares = default;
            Optional<float> confidenceInterval = default;
            Optional<float> averageReward = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeStamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("ipsEstimatorNumerator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ipsEstimatorNumerator = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ipsEstimatorDenominator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ipsEstimatorDenominator = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("snipsEstimatorDenominator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    snipsEstimatorDenominator = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aggregateTimeWindow"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aggregateTimeWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("nonZeroProbability"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nonZeroProbability = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sumOfSquares"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sumOfSquares = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("confidenceInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    confidenceInterval = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("averageReward"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    averageReward = property.Value.GetSingle();
                    continue;
                }
            }
            return new PolicyResultTotalSummary(Optional.ToNullable(timeStamp), Optional.ToNullable(ipsEstimatorNumerator), Optional.ToNullable(ipsEstimatorDenominator), Optional.ToNullable(snipsEstimatorDenominator), Optional.ToNullable(aggregateTimeWindow), Optional.ToNullable(nonZeroProbability), Optional.ToNullable(sumOfSquares), Optional.ToNullable(confidenceInterval), Optional.ToNullable(averageReward));
        }
    }
}
