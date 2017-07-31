// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CachingTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CachingTypes
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ReadOnly")]
        ReadOnly,
        [EnumMember(Value = "ReadWrite")]
        ReadWrite
    }
    internal static class CachingTypesEnumExtension
    {
        internal static string ToSerializedValue(this CachingTypes? value)  =>
            value == null ? null : ((CachingTypes)value).ToSerializedValue();

        internal static string ToSerializedValue(this CachingTypes value)
        {
            switch( value )
            {
                case CachingTypes.None:
                    return "None";
                case CachingTypes.ReadOnly:
                    return "ReadOnly";
                case CachingTypes.ReadWrite:
                    return "ReadWrite";
            }
            return null;
        }

        internal static CachingTypes? ParseCachingTypes(this string value)
        {
            switch( value )
            {
                case "None":
                    return CachingTypes.None;
                case "ReadOnly":
                    return CachingTypes.ReadOnly;
                case "ReadWrite":
                    return CachingTypes.ReadWrite;
            }
            return null;
        }
    }
}
