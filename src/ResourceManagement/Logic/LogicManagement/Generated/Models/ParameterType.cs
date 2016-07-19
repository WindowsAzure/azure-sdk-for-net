// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ParameterType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParameterType
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "String")]
        String,
        [EnumMember(Value = "SecureString")]
        SecureString,
        [EnumMember(Value = "Int")]
        Int,
        [EnumMember(Value = "Float")]
        Float,
        [EnumMember(Value = "Bool")]
        Bool,
        [EnumMember(Value = "Array")]
        Array,
        [EnumMember(Value = "Object")]
        Object,
        [EnumMember(Value = "SecureObject")]
        SecureObject
    }
}
