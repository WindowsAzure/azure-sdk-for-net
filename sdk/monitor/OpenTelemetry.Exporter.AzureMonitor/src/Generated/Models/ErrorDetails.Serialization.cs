// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    public partial class ErrorDetails
    {
        internal static ErrorDetails DeserializeErrorDetails(JsonElement element)
        {
            Optional<int> index = default;
            Optional<int> statusCode = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("index"))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new ErrorDetails(Optional.ToNullable(index), Optional.ToNullable(statusCode), message.Value);
        }
    }
}
