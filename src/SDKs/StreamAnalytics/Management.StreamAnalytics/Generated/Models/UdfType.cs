// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UdfType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UdfType
    {
        [EnumMember(Value = "Scalar")]
        Scalar
    }
    internal static class UdfTypeEnumExtension
    {
        internal static string ToSerializedValue(this UdfType? value)  =>
            value == null ? null : ((UdfType)value).ToSerializedValue();

        internal static string ToSerializedValue(this UdfType value)
        {
            switch( value )
            {
                case UdfType.Scalar:
                    return "Scalar";
            }
            return null;
        }

        internal static UdfType? ParseUdfType(this string value)
        {
            switch( value )
            {
                case "Scalar":
                    return UdfType.Scalar;
            }
            return null;
        }
    }
}
