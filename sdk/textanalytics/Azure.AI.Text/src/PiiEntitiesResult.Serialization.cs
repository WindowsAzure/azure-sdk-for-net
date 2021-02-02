// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.Text.Models
{
    internal partial class PiiEntitiesResult
    {
        internal static PiiEntitiesResult DeserializePiiEntitiesResult(JsonElement element)
        {
            IReadOnlyList<PiiDocumentEntities> documents = default;
            IReadOnlyList<DocumentError> errors = default;
            Optional<TextDocumentBatchStatistics> statistics = default;
            string modelVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"))
                {
                    List<PiiDocumentEntities> array = new List<PiiDocumentEntities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PiiDocumentEntities.DeserializePiiDocumentEntities(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
            }
            return new PiiEntitiesResult(documents, errors, statistics.Value, modelVersion);
        }
    }
}
