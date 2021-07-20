// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault
{
    internal static partial class SkuNameExtensions
    {
        public static string ToSerialString(this SkuName value) => value switch
        {
            SkuName.Standard => "standard",
            SkuName.Premium => "premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuName value.")
        };

        public static SkuName ToSkuName(this string value)
        {
            if (string.Equals(value, "standard", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Standard;
            if (string.Equals(value, "premium", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuName value.");
        }
    }
}
