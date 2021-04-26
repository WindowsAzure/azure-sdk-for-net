// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class DetectionResultSummary
    {
        internal static DetectionResultSummary DeserializeDetectionResultSummary(JsonElement element)
        {
            DetectionStatus status = default;
            Optional<IReadOnlyList<ErrorResponse>> errors = default;
            Optional<IReadOnlyList<VariableState>> variableStates = default;
            DetectionRequest setupInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToDetectionStatus();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorResponse.DeserializeErrorResponse(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("variableStates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VariableState> array = new List<VariableState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VariableState.DeserializeVariableState(item));
                    }
                    variableStates = array;
                    continue;
                }
                if (property.NameEquals("setupInfo"))
                {
                    setupInfo = DetectionRequest.DeserializeDetectionRequest(property.Value);
                    continue;
                }
            }
            return new DetectionResultSummary(status, Optional.ToList(errors), Optional.ToList(variableStates), setupInfo);
        }
    }
}
