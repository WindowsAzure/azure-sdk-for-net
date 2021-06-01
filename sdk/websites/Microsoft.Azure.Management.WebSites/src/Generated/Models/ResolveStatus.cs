// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResolveStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResolveStatus
    {
        [EnumMember(Value = "Initialized")]
        Initialized,
        [EnumMember(Value = "Resolved")]
        Resolved,
        [EnumMember(Value = "InvalidSyntax")]
        InvalidSyntax,
        [EnumMember(Value = "MSINotEnabled")]
        MSINotEnabled,
        [EnumMember(Value = "VaultNotFound")]
        VaultNotFound,
        [EnumMember(Value = "SecretNotFound")]
        SecretNotFound,
        [EnumMember(Value = "SecretVersionNotFound")]
        SecretVersionNotFound,
        [EnumMember(Value = "AccessToKeyVaultDenied")]
        AccessToKeyVaultDenied,
        [EnumMember(Value = "OtherReasons")]
        OtherReasons,
        [EnumMember(Value = "FetchTimedOut")]
        FetchTimedOut,
        [EnumMember(Value = "UnauthorizedClient")]
        UnauthorizedClient
    }
    internal static class ResolveStatusEnumExtension
    {
        internal static string ToSerializedValue(this ResolveStatus? value)
        {
            return value == null ? null : ((ResolveStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResolveStatus value)
        {
            switch( value )
            {
                case ResolveStatus.Initialized:
                    return "Initialized";
                case ResolveStatus.Resolved:
                    return "Resolved";
                case ResolveStatus.InvalidSyntax:
                    return "InvalidSyntax";
                case ResolveStatus.MSINotEnabled:
                    return "MSINotEnabled";
                case ResolveStatus.VaultNotFound:
                    return "VaultNotFound";
                case ResolveStatus.SecretNotFound:
                    return "SecretNotFound";
                case ResolveStatus.SecretVersionNotFound:
                    return "SecretVersionNotFound";
                case ResolveStatus.AccessToKeyVaultDenied:
                    return "AccessToKeyVaultDenied";
                case ResolveStatus.OtherReasons:
                    return "OtherReasons";
                case ResolveStatus.FetchTimedOut:
                    return "FetchTimedOut";
                case ResolveStatus.UnauthorizedClient:
                    return "UnauthorizedClient";
            }
            return null;
        }

        internal static ResolveStatus? ParseResolveStatus(this string value)
        {
            switch( value )
            {
                case "Initialized":
                    return ResolveStatus.Initialized;
                case "Resolved":
                    return ResolveStatus.Resolved;
                case "InvalidSyntax":
                    return ResolveStatus.InvalidSyntax;
                case "MSINotEnabled":
                    return ResolveStatus.MSINotEnabled;
                case "VaultNotFound":
                    return ResolveStatus.VaultNotFound;
                case "SecretNotFound":
                    return ResolveStatus.SecretNotFound;
                case "SecretVersionNotFound":
                    return ResolveStatus.SecretVersionNotFound;
                case "AccessToKeyVaultDenied":
                    return ResolveStatus.AccessToKeyVaultDenied;
                case "OtherReasons":
                    return ResolveStatus.OtherReasons;
                case "FetchTimedOut":
                    return ResolveStatus.FetchTimedOut;
                case "UnauthorizedClient":
                    return ResolveStatus.UnauthorizedClient;
            }
            return null;
        }
    }
}
