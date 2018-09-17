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
    /// Defines values for JobType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobType
    {
        [EnumMember(Value = "Backup")]
        Backup,
        [EnumMember(Value = "Clone")]
        Clone,
        [EnumMember(Value = "Failover")]
        Failover,
        [EnumMember(Value = "DownloadUpdates")]
        DownloadUpdates,
        [EnumMember(Value = "InstallUpdates")]
        InstallUpdates
    }
    internal static class JobTypeEnumExtension
    {
        internal static string ToSerializedValue(this JobType? value)
        {
            return value == null ? null : ((JobType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobType value)
        {
            switch( value )
            {
                case JobType.Backup:
                    return "Backup";
                case JobType.Clone:
                    return "Clone";
                case JobType.Failover:
                    return "Failover";
                case JobType.DownloadUpdates:
                    return "DownloadUpdates";
                case JobType.InstallUpdates:
                    return "InstallUpdates";
            }
            return null;
        }

        internal static JobType? ParseJobType(this string value)
        {
            switch( value )
            {
                case "Backup":
                    return JobType.Backup;
                case "Clone":
                    return JobType.Clone;
                case "Failover":
                    return JobType.Failover;
                case "DownloadUpdates":
                    return JobType.DownloadUpdates;
                case "InstallUpdates":
                    return JobType.InstallUpdates;
            }
            return null;
        }
    }
}
