// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataLakeGen2SharedKeyCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters");
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("dataSourceCredentialType");
            writer.WriteStringValue(DataSourceCredentialType.ToString());
            writer.WritePropertyName("dataSourceCredentialName");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static DataLakeGen2SharedKeyCredential DeserializeDataLakeGen2SharedKeyCredential(JsonElement element)
        {
            DataLakeGen2SharedKeyParam parameters = default;
            DataSourceCredentialType dataSourceCredentialType = default;
            Optional<string> dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            Optional<string> dataSourceCredentialDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"))
                {
                    parameters = DataLakeGen2SharedKeyParam.DeserializeDataLakeGen2SharedKeyParam(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialType"))
                {
                    dataSourceCredentialType = new DataSourceCredentialType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeGen2SharedKeyCredential(dataSourceCredentialType, dataSourceCredentialId.Value, dataSourceCredentialName, dataSourceCredentialDescription.Value, parameters);
        }
    }
}
