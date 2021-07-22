// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer.Models
{
    public partial class Evaluation
    {
        internal static Evaluation DeserializeEvaluation(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> jobId = default;
            Optional<EvaluationJobStatus> status = default;
            Optional<IReadOnlyList<PolicyResult>> policyResults = default;
            Optional<IReadOnlyList<IList<string>>> featureImportance = default;
            Optional<EvaluationType> evaluationType = default;
            Optional<string> optimalPolicy = default;
            Optional<DateTimeOffset> creationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new EvaluationJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicyResult> array = new List<PolicyResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyResult.DeserializePolicyResult(item));
                    }
                    policyResults = array;
                    continue;
                }
                if (property.NameEquals("featureImportance"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<string> array0 = new List<string>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(item0.GetString());
                        }
                        array.Add(array0);
                    }
                    featureImportance = array;
                    continue;
                }
                if (property.NameEquals("evaluationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    evaluationType = new EvaluationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optimalPolicy"))
                {
                    optimalPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new Evaluation(id.Value, name.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), jobId.Value, Optional.ToNullable(status), Optional.ToList(policyResults), Optional.ToList(featureImportance), Optional.ToNullable(evaluationType), optimalPolicy.Value, Optional.ToNullable(creationTime));
        }
    }
}
