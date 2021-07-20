// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Render.Models
{
    public partial class RegionCopyrightsCountry
    {
        internal static RegionCopyrightsCountry DeserializeRegionCopyrightsCountry(JsonElement element)
        {
            Optional<string> iSO3 = default;
            Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ISO3"))
                {
                    iSO3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new RegionCopyrightsCountry(iSO3.Value, label.Value);
        }
    }
}
