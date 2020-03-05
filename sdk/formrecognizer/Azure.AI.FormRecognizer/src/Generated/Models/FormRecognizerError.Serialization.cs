// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class FormRecognizerError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("code");
            writer.WriteStringValue(Code);
            writer.WritePropertyName("message");
            writer.WriteStringValue(Message);
            writer.WriteEndObject();
        }
        internal static FormRecognizerError DeserializeFormRecognizerError(JsonElement element)
        {
            FormRecognizerError result = new FormRecognizerError();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    result.Code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    result.Message = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
