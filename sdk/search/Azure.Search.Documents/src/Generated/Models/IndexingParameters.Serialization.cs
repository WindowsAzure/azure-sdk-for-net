// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class IndexingParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BatchSize))
            {
                if (BatchSize != null)
                {
                    writer.WritePropertyName("batchSize");
                    writer.WriteNumberValue(BatchSize.Value);
                }
                else
                {
                    writer.WriteNull("batchSize");
                }
            }
            if (Optional.IsDefined(MaxFailedItems))
            {
                if (MaxFailedItems != null)
                {
                    writer.WritePropertyName("maxFailedItems");
                    writer.WriteNumberValue(MaxFailedItems.Value);
                }
                else
                {
                    writer.WriteNull("maxFailedItems");
                }
            }
            if (Optional.IsDefined(MaxFailedItemsPerBatch))
            {
                if (MaxFailedItemsPerBatch != null)
                {
                    writer.WritePropertyName("maxFailedItemsPerBatch");
                    writer.WriteNumberValue(MaxFailedItemsPerBatch.Value);
                }
                else
                {
                    writer.WriteNull("maxFailedItemsPerBatch");
                }
            }
            if (Optional.IsDefined(IndexingParametersConfiguration))
            {
                writer.WritePropertyName("configuration");
                writer.WriteObjectValue(IndexingParametersConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static IndexingParameters DeserializeIndexingParameters(JsonElement element)
        {
            Optional<int?> batchSize = default;
            Optional<int?> maxFailedItems = default;
            Optional<int?> maxFailedItemsPerBatch = default;
            Optional<IndexingParametersConfiguration> configuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        batchSize = null;
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxFailedItems"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxFailedItems = null;
                        continue;
                    }
                    maxFailedItems = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxFailedItemsPerBatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxFailedItemsPerBatch = null;
                        continue;
                    }
                    maxFailedItemsPerBatch = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("configuration"))
                {
                    configuration = Models.IndexingParametersConfiguration.DeserializeIndexingParametersConfiguration(property.Value);
                    continue;
                }
            }
            return new IndexingParameters(Optional.ToNullable(batchSize), Optional.ToNullable(maxFailedItems), Optional.ToNullable(maxFailedItemsPerBatch), configuration.Value);
        }
    }
}
