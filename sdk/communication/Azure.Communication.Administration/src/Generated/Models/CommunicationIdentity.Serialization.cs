// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    internal partial class CommunicationIdentity
    {
        internal static CommunicationIdentity DeserializeCommunicationIdentity(JsonElement element)
        {
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new CommunicationIdentity(id);
        }
    }
}
