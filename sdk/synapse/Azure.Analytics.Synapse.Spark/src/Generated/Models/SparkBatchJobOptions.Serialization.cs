// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkBatchJobOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ArtifactId != null)
            {
                writer.WritePropertyName("artifactId");
                writer.WriteStringValue(ArtifactId);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (File != null)
            {
                writer.WritePropertyName("file");
                writer.WriteStringValue(File);
            }
            if (ClassName != null)
            {
                writer.WritePropertyName("className");
                writer.WriteStringValue(ClassName);
            }
            if (Arguments != null)
            {
                writer.WritePropertyName("args");
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Jars != null)
            {
                writer.WritePropertyName("jars");
                writer.WriteStartArray();
                foreach (var item in Jars)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (PythonFiles != null)
            {
                writer.WritePropertyName("pyFiles");
                writer.WriteStartArray();
                foreach (var item in PythonFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Files != null)
            {
                writer.WritePropertyName("files");
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Archives != null)
            {
                writer.WritePropertyName("archives");
                writer.WriteStartArray();
                foreach (var item in Archives)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Configuration != null)
            {
                writer.WritePropertyName("conf");
                writer.WriteStartObject();
                foreach (var item in Configuration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (DriverMemory != null)
            {
                writer.WritePropertyName("driverMemory");
                writer.WriteStringValue(DriverMemory);
            }
            if (DriverCores != null)
            {
                writer.WritePropertyName("driverCores");
                writer.WriteNumberValue(DriverCores.Value);
            }
            if (ExecutorMemory != null)
            {
                writer.WritePropertyName("executorMemory");
                writer.WriteStringValue(ExecutorMemory);
            }
            if (ExecutorCores != null)
            {
                writer.WritePropertyName("executorCores");
                writer.WriteNumberValue(ExecutorCores.Value);
            }
            if (ExecutorCount != null)
            {
                writer.WritePropertyName("numExecutors");
                writer.WriteNumberValue(ExecutorCount.Value);
            }
            writer.WriteEndObject();
        }
    }
}
