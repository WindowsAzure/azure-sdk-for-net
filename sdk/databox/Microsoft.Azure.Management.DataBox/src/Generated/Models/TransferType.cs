// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TransferType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransferType
    {
        /// <summary>
        /// Import data to azure.
        /// </summary>
        [EnumMember(Value = "ImportToAzure")]
        ImportToAzure,
        /// <summary>
        /// Export data from azure.
        /// </summary>
        [EnumMember(Value = "ExportFromAzure")]
        ExportFromAzure
    }
    internal static class TransferTypeEnumExtension
    {
        internal static string ToSerializedValue(this TransferType? value)
        {
            return value == null ? null : ((TransferType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TransferType value)
        {
            switch( value )
            {
                case TransferType.ImportToAzure:
                    return "ImportToAzure";
                case TransferType.ExportFromAzure:
                    return "ExportFromAzure";
            }
            return null;
        }

        internal static TransferType? ParseTransferType(this string value)
        {
            switch( value )
            {
                case "ImportToAzure":
                    return TransferType.ImportToAzure;
                case "ExportFromAzure":
                    return TransferType.ExportFromAzure;
            }
            return null;
        }
    }
}
