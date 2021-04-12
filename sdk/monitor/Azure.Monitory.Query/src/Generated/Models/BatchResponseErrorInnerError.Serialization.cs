// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitory.Query.Models
{
    internal partial class BatchResponseErrorInnerError
    {
        internal static BatchResponseErrorInnerError DeserializeBatchResponseErrorInnerError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<ErrorDetails>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorDetails> array = new List<ErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorDetails.DeserializeErrorDetails(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new BatchResponseErrorInnerError(code.Value, message.Value, Optional.ToList(details));
        }
    }
}
