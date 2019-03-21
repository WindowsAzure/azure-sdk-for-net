// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuName
    {
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "standard2")]
        Standard2,
        [EnumMember(Value = "standard3")]
        Standard3,
        [EnumMember(Value = "storage_optimized_l1")]
        StorageOptimizedL1,
        [EnumMember(Value = "storage_optimized_l2")]
        StorageOptimizedL2
    }
    internal static class SkuNameEnumExtension
    {
        internal static string ToSerializedValue(this SkuName? value)
        {
            return value == null ? null : ((SkuName)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuName value)
        {
            switch( value )
            {
                case SkuName.Free:
                    return "free";
                case SkuName.Basic:
                    return "basic";
                case SkuName.Standard:
                    return "standard";
                case SkuName.Standard2:
                    return "standard2";
                case SkuName.Standard3:
                    return "standard3";
                case SkuName.StorageOptimizedL1:
                    return "storage_optimized_l1";
                case SkuName.StorageOptimizedL2:
                    return "storage_optimized_l2";
            }
            return null;
        }

        internal static SkuName? ParseSkuName(this string value)
        {
            switch( value )
            {
                case "free":
                    return SkuName.Free;
                case "basic":
                    return SkuName.Basic;
                case "standard":
                    return SkuName.Standard;
                case "standard2":
                    return SkuName.Standard2;
                case "standard3":
                    return SkuName.Standard3;
                case "storage_optimized_l1":
                    return SkuName.StorageOptimizedL1;
                case "storage_optimized_l2":
                    return SkuName.StorageOptimizedL2;
            }
            return null;
        }
    }
}
