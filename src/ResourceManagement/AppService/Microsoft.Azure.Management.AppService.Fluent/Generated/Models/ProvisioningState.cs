// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningState
    {
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Deleting")]
        Deleting
    }
}
