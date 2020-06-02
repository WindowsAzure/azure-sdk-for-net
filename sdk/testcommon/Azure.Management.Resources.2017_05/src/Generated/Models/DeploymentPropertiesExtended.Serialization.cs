// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class DeploymentPropertiesExtended
    {
        internal static DeploymentPropertiesExtended DeserializeDeploymentPropertiesExtended(JsonElement element)
        {
            string provisioningState = default;
            string correlationId = default;
            DateTimeOffset? timestamp = default;
            object outputs = default;
            IReadOnlyList<Provider> providers = default;
            IReadOnlyList<Dependency> dependencies = default;
            object template = default;
            TemplateLink templateLink = default;
            object parameters = default;
            ParametersLink parametersLink = default;
            DeploymentMode? mode = default;
            DebugSetting debugSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputs = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("providers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Provider> array = new List<Provider>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Provider.DeserializeProvider(item));
                        }
                    }
                    providers = array;
                    continue;
                }
                if (property.NameEquals("dependencies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Dependency> array = new List<Dependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Dependency.DeserializeDependency(item));
                        }
                    }
                    dependencies = array;
                    continue;
                }
                if (property.NameEquals("template"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("templateLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateLink = TemplateLink.DeserializeTemplateLink(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("parametersLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parametersLink = ParametersLink.DeserializeParametersLink(property.Value);
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = property.Value.GetString().ToDeploymentMode();
                    continue;
                }
                if (property.NameEquals("debugSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSetting = DebugSetting.DeserializeDebugSetting(property.Value);
                    continue;
                }
            }
            return new DeploymentPropertiesExtended(provisioningState, correlationId, timestamp, outputs, providers, dependencies, template, templateLink, parameters, parametersLink, mode, debugSetting);
        }
    }
}
