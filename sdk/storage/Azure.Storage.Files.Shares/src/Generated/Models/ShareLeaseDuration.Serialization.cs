// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    internal static class ShareLeaseDurationExtensions
    {
        public static string ToSerialString(this ShareLeaseDuration value) => value switch
        {
            ShareLeaseDuration.Infinite => "infinite",
            ShareLeaseDuration.Fixed => "fixed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareLeaseDuration value.")
        };

        public static ShareLeaseDuration ToShareLeaseDuration(this string value)
        {
            if (string.Equals(value, "infinite", StringComparison.InvariantCultureIgnoreCase)) return ShareLeaseDuration.Infinite;
            if (string.Equals(value, "fixed", StringComparison.InvariantCultureIgnoreCase)) return ShareLeaseDuration.Fixed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareLeaseDuration value.");
        }
    }
}
