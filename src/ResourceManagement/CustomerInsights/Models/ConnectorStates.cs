// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ConnectorStates.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorStates
    {
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Ready")]
        Ready,
        [EnumMember(Value = "Expiring")]
        Expiring,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class ConnectorStatesEnumExtension
    {
        internal static string ToSerializedValue(this ConnectorStates? value)
        {
            return value == null ? null : ((ConnectorStates)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ConnectorStates value)
        {
            switch( value )
            {
                case ConnectorStates.Creating:
                    return "Creating";
                case ConnectorStates.Created:
                    return "Created";
                case ConnectorStates.Ready:
                    return "Ready";
                case ConnectorStates.Expiring:
                    return "Expiring";
                case ConnectorStates.Deleting:
                    return "Deleting";
                case ConnectorStates.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static ConnectorStates? ParseConnectorStates(this string value)
        {
            switch( value )
            {
                case "Creating":
                    return ConnectorStates.Creating;
                case "Created":
                    return ConnectorStates.Created;
                case "Ready":
                    return ConnectorStates.Ready;
                case "Expiring":
                    return ConnectorStates.Expiring;
                case "Deleting":
                    return ConnectorStates.Deleting;
                case "Failed":
                    return ConnectorStates.Failed;
            }
            return null;
        }
    }
}
