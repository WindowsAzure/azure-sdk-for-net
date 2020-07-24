// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class CloudToDeviceMethodResponse
    {
        internal static CloudToDeviceMethodResponse DeserializeCloudToDeviceMethodResponse(JsonElement element)
        {
            Optional<int> status = default;
            Optional<object> payload = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("payload"))
                {
                    payload = property.Value.GetObject();
                    continue;
                }
            }
            return new CloudToDeviceMethodResponse(Optional.ToNullable(status), payload.Value);
        }
    }
}
