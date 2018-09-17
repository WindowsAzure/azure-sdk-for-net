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
    /// Defines values for DataPolicy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataPolicy
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "Local")]
        Local,
        [EnumMember(Value = "Tiered")]
        Tiered,
        [EnumMember(Value = "Cloud")]
        Cloud
    }
    internal static class DataPolicyEnumExtension
    {
        internal static string ToSerializedValue(this DataPolicy? value)
        {
            return value == null ? null : ((DataPolicy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DataPolicy value)
        {
            switch( value )
            {
                case DataPolicy.Invalid:
                    return "Invalid";
                case DataPolicy.Local:
                    return "Local";
                case DataPolicy.Tiered:
                    return "Tiered";
                case DataPolicy.Cloud:
                    return "Cloud";
            }
            return null;
        }

        internal static DataPolicy? ParseDataPolicy(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return DataPolicy.Invalid;
                case "Local":
                    return DataPolicy.Local;
                case "Tiered":
                    return DataPolicy.Tiered;
                case "Cloud":
                    return DataPolicy.Cloud;
            }
            return null;
        }
    }
}
