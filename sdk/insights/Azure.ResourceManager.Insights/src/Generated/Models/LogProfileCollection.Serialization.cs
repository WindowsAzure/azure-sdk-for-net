// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    internal partial class LogProfileCollection
    {
        internal static LogProfileCollection DeserializeLogProfileCollection(JsonElement element)
        {
            IReadOnlyList<LogProfileResource> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LogProfileResource> array = new List<LogProfileResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogProfileResource.DeserializeLogProfileResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LogProfileCollection(value);
        }
    }
}
