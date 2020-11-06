// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    public partial class StackFrame : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("level");
            writer.WriteNumberValue(Level);
            writer.WritePropertyName("method");
            writer.WriteStringValue(Method);
            if (Optional.IsDefined(Assembly))
            {
                writer.WritePropertyName("assembly");
                writer.WriteStringValue(Assembly);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName");
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Line))
            {
                writer.WritePropertyName("line");
                writer.WriteNumberValue(Line.Value);
            }
            writer.WriteEndObject();
        }
    }
}
