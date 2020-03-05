// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class ErrorResponse_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("error");
            writer.WriteObjectValue(Error);
            writer.WriteEndObject();
        }
        internal static ErrorResponse_internal DeserializeErrorResponse_internal(JsonElement element)
        {
            ErrorResponse_internal result = new ErrorResponse_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    result.Error = FormRecognizerError.DeserializeFormRecognizerError(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
