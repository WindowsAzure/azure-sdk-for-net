// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial class TasksStateTasks
    {
        internal static TasksStateTasks DeserializeTasksStateTasks(JsonElement element)
        {
            Optional<IReadOnlyList<TaskState>> details = default;
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            Optional<IReadOnlyList<EntityRecognitionTasksItem>> entityRecognitionTasks = default;
            Optional<IReadOnlyList<EntityRecognitionPiiTasksItem>> entityRecognitionPiiTasks = default;
            Optional<IReadOnlyList<KeyPhraseExtractionTasksItem>> keyPhraseExtractionTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TaskState> array = new List<TaskState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TaskState.DeserializeTaskState(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("completed"))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityRecognitionTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityRecognitionTasksItem> array = new List<EntityRecognitionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityRecognitionTasksItem.DeserializeEntityRecognitionTasksItem(item));
                    }
                    entityRecognitionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityRecognitionPiiTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityRecognitionPiiTasksItem> array = new List<EntityRecognitionPiiTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityRecognitionPiiTasksItem.DeserializeEntityRecognitionPiiTasksItem(item));
                    }
                    entityRecognitionPiiTasks = array;
                    continue;
                }
                if (property.NameEquals("keyPhraseExtractionTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KeyPhraseExtractionTasksItem> array = new List<KeyPhraseExtractionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyPhraseExtractionTasksItem.DeserializeKeyPhraseExtractionTasksItem(item));
                    }
                    keyPhraseExtractionTasks = array;
                    continue;
                }
            }
            return new TasksStateTasks(Optional.ToList(details), completed, failed, inProgress, total, Optional.ToList(entityRecognitionTasks), Optional.ToList(entityRecognitionPiiTasks), Optional.ToList(keyPhraseExtractionTasks));
        }
    }
}
