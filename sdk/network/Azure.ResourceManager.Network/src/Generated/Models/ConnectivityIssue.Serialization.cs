// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityIssue
    {
        internal static ConnectivityIssue DeserializeConnectivityIssue(JsonElement element)
        {
            Optional<Origin> origin = default;
            Optional<Severity> severity = default;
            Optional<IssueType> type = default;
            Optional<IReadOnlyList<IDictionary<string, string>>> context = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    origin = new Origin(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    severity = new Severity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new IssueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IDictionary<string, string>> array = new List<IDictionary<string, string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        foreach (var property0 in item.EnumerateObject())
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                        array.Add(dictionary);
                    }
                    context = array;
                    continue;
                }
            }
            return new ConnectivityIssue(Optional.ToNullable(origin), Optional.ToNullable(severity), Optional.ToNullable(type), Optional.ToList(context));
        }
    }
}
