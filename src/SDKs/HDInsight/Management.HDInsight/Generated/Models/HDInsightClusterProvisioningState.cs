// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight.Models
{
    using Microsoft.HDInsight;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HDInsightClusterProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HDInsightClusterProvisioningState
    {
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Deleting")]
        Deleting
    }
}
