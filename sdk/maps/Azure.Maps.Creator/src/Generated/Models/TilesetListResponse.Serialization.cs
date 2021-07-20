// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    internal partial class TilesetListResponse
    {
        internal static TilesetListResponse DeserializeTilesetListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<TilesetDetailInfo>> tilesets = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tilesets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TilesetDetailInfo> array = new List<TilesetDetailInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TilesetDetailInfo.DeserializeTilesetDetailInfo(item));
                    }
                    tilesets = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TilesetListResponse(Optional.ToList(tilesets), nextLink.Value);
        }
    }
}
