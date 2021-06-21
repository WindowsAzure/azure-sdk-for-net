// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class KnowledgeStoreStorageProjectionSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageContainer");
            writer.WriteStringValue(StorageContainer);
            if (Optional.IsDefined(ReferenceKeyName))
            {
                writer.WritePropertyName("referenceKeyName");
                writer.WriteStringValue(ReferenceKeyName);
            }
            if (Optional.IsDefined(GeneratedKeyName))
            {
                writer.WritePropertyName("generatedKeyName");
                writer.WriteStringValue(GeneratedKeyName);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(SourceContext))
            {
                writer.WritePropertyName("sourceContext");
                writer.WriteStringValue(SourceContext);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KnowledgeStoreStorageProjectionSelector DeserializeKnowledgeStoreStorageProjectionSelector(JsonElement element)
        {
            throw new NotSupportedException("Deserialization of abstract type 'global::Azure.Search.Documents.Indexes.Models.KnowledgeStoreStorageProjectionSelector' not supported.");
        }
    }
}
