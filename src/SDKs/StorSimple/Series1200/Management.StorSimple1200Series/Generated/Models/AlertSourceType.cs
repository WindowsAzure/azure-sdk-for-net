// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertSourceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertSourceType
    {
        [EnumMember(Value = "Resource")]
        Resource,
        [EnumMember(Value = "Device")]
        Device
    }
    internal static class AlertSourceTypeEnumExtension
    {
        internal static string ToSerializedValue(this AlertSourceType? value)
        {
            return value == null ? null : ((AlertSourceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertSourceType value)
        {
            switch( value )
            {
                case AlertSourceType.Resource:
                    return "Resource";
                case AlertSourceType.Device:
                    return "Device";
            }
            return null;
        }

        internal static AlertSourceType? ParseAlertSourceType(this string value)
        {
            switch( value )
            {
                case "Resource":
                    return AlertSourceType.Resource;
                case "Device":
                    return AlertSourceType.Device;
            }
            return null;
        }
    }
}
