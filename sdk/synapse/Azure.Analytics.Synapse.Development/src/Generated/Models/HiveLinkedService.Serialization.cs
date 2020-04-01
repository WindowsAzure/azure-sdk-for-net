// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Development.Models
{
    public partial class HiveLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Annotations != null)
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("host");
            writer.WriteObjectValue(Host);
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteObjectValue(Port);
            }
            if (ServerType != null)
            {
                writer.WritePropertyName("serverType");
                writer.WriteStringValue(ServerType.Value.ToString());
            }
            if (ThriftTransportProtocol != null)
            {
                writer.WritePropertyName("thriftTransportProtocol");
                writer.WriteStringValue(ThriftTransportProtocol.Value.ToString());
            }
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (ServiceDiscoveryMode != null)
            {
                writer.WritePropertyName("serviceDiscoveryMode");
                writer.WriteObjectValue(ServiceDiscoveryMode);
            }
            if (ZooKeeperNameSpace != null)
            {
                writer.WritePropertyName("zooKeeperNameSpace");
                writer.WriteObjectValue(ZooKeeperNameSpace);
            }
            if (UseNativeQuery != null)
            {
                writer.WritePropertyName("useNativeQuery");
                writer.WriteObjectValue(UseNativeQuery);
            }
            if (Username != null)
            {
                writer.WritePropertyName("username");
                writer.WriteObjectValue(Username);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (HttpPath != null)
            {
                writer.WritePropertyName("httpPath");
                writer.WriteObjectValue(HttpPath);
            }
            if (EnableSsl != null)
            {
                writer.WritePropertyName("enableSsl");
                writer.WriteObjectValue(EnableSsl);
            }
            if (TrustedCertPath != null)
            {
                writer.WritePropertyName("trustedCertPath");
                writer.WriteObjectValue(TrustedCertPath);
            }
            if (UseSystemTrustStore != null)
            {
                writer.WritePropertyName("useSystemTrustStore");
                writer.WriteObjectValue(UseSystemTrustStore);
            }
            if (AllowHostNameCNMismatch != null)
            {
                writer.WritePropertyName("allowHostNameCNMismatch");
                writer.WriteObjectValue(AllowHostNameCNMismatch);
            }
            if (AllowSelfSignedServerCert != null)
            {
                writer.WritePropertyName("allowSelfSignedServerCert");
                writer.WriteObjectValue(AllowSelfSignedServerCert);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HiveLinkedService DeserializeHiveLinkedService(JsonElement element)
        {
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object host = default;
            object port = default;
            HiveServerType? serverType = default;
            HiveThriftTransportProtocol? thriftTransportProtocol = default;
            HiveAuthenticationType authenticationType = default;
            object serviceDiscoveryMode = default;
            object zooKeeperNameSpace = default;
            object useNativeQuery = default;
            object username = default;
            SecretBase password = default;
            object httpPath = default;
            object enableSsl = default;
            object trustedCertPath = default;
            object useSystemTrustStore = default;
            object allowHostNameCNMismatch = default;
            object allowSelfSignedServerCert = default;
            object encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("host"))
                        {
                            host = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("serverType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverType = new HiveServerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thriftTransportProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            thriftTransportProtocol = new HiveThriftTransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new HiveAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceDiscoveryMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceDiscoveryMode = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("zooKeeperNameSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zooKeeperNameSpace = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useNativeQuery"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useNativeQuery = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("username"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableSsl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableSsl = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedCertPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useSystemTrustStore = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowHostNameCNMismatch"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowHostNameCNMismatch = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowSelfSignedServerCert"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowSelfSignedServerCert = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HiveLinkedService(type, connectVia, description, parameters, annotations, additionalProperties, host, port, serverType, thriftTransportProtocol, authenticationType, serviceDiscoveryMode, zooKeeperNameSpace, useNativeQuery, username, password, httpPath, enableSsl, trustedCertPath, useSystemTrustStore, allowHostNameCNMismatch, allowSelfSignedServerCert, encryptedCredential);
        }
    }
}
