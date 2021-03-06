// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class Update
    {
        internal static Update DeserializeUpdate(JsonElement element)
        {
            UpdateId updateId = default;
            string updateType = default;
            string installedCriteria = default;
            IReadOnlyList<Compatibility> compatibility = default;
            string manifestVersion = default;
            DateTimeOffset importedDateTime = default;
            DateTimeOffset createdDateTime = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("updateId"))
                {
                    updateId = UpdateId.DeserializeUpdateId(property.Value);
                    continue;
                }
                if (property.NameEquals("updateType"))
                {
                    updateType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installedCriteria"))
                {
                    installedCriteria = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("compatibility"))
                {
                    List<Compatibility> array = new List<Compatibility>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.Compatibility.DeserializeCompatibility(item));
                    }
                    compatibility = array;
                    continue;
                }
                if (property.NameEquals("manifestVersion"))
                {
                    manifestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("importedDateTime"))
                {
                    importedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new Update(updateId, updateType, installedCriteria, compatibility, manifestVersion, importedDateTime, createdDateTime, etag.Value);
        }
    }
}
