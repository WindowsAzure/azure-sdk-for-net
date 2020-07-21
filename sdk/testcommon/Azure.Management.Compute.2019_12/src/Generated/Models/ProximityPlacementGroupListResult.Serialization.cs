// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ProximityPlacementGroupListResult
    {
        internal static ProximityPlacementGroupListResult DeserializeProximityPlacementGroupListResult(JsonElement element)
        {
            IReadOnlyList<ProximityPlacementGroup> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ProximityPlacementGroup> array = new List<ProximityPlacementGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProximityPlacementGroup.DeserializeProximityPlacementGroup(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ProximityPlacementGroupListResult(value, nextLink.Value);
        }
    }
}
