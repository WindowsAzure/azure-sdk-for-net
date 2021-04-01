// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.Translator.DocumentTranslation;
using Azure.Core;

namespace Azure.AI.Translator.DocumentTranslation.Models
{
    internal partial class BatchStatusResponse
    {
        internal static BatchStatusResponse DeserializeBatchStatusResponse(JsonElement element)
        {
            IReadOnlyList<TranslationStatusResult> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TranslationStatusResult> array = new List<TranslationStatusResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranslationStatusResult.DeserializeTranslationStatusResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BatchStatusResponse(value, nextLink.Value);
        }
    }
}
