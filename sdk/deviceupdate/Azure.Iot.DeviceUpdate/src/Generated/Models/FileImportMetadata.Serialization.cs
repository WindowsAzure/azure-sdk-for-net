// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class FileImportMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filename");
            writer.WriteStringValue(Filename);
            writer.WritePropertyName("url");
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }
    }
}
