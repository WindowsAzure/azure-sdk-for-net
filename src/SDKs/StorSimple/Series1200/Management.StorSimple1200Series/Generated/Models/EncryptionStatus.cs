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
    /// Defines values for EncryptionStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionStatus
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class EncryptionStatusEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionStatus? value)
        {
            return value == null ? null : ((EncryptionStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncryptionStatus value)
        {
            switch( value )
            {
                case EncryptionStatus.Enabled:
                    return "Enabled";
                case EncryptionStatus.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static EncryptionStatus? ParseEncryptionStatus(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return EncryptionStatus.Enabled;
                case "Disabled":
                    return EncryptionStatus.Disabled;
            }
            return null;
        }
    }
}
