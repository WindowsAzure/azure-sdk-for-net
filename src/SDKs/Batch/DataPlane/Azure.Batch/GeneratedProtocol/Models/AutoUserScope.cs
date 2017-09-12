// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutoUserScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoUserScope
    {
        [EnumMember(Value = "task")]
        Task,
        [EnumMember(Value = "pool")]
        Pool
    }
    internal static class AutoUserScopeEnumExtension
    {
        internal static string ToSerializedValue(this AutoUserScope? value)  =>
            value == null ? null : ((AutoUserScope)value).ToSerializedValue();

        internal static string ToSerializedValue(this AutoUserScope value)
        {
            switch( value )
            {
                case AutoUserScope.Task:
                    return "task";
                case AutoUserScope.Pool:
                    return "pool";
            }
            return null;
        }

        internal static AutoUserScope? ParseAutoUserScope(this string value)
        {
            switch( value )
            {
                case "task":
                    return AutoUserScope.Task;
                case "pool":
                    return AutoUserScope.Pool;
            }
            return null;
        }
    }
}
