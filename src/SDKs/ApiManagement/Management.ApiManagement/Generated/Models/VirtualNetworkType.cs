// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VirtualNetworkType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VirtualNetworkType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "External")]
        External,
        [EnumMember(Value = "Internal")]
        Internal
    }
}
