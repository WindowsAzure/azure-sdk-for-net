﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.ResourceManager.Core
{
    internal static partial class SubscriptionStateExtensions
    {
        public static string ToSerialString(this SubscriptionState value) => value switch
        {
            SubscriptionState.Enabled => "Enabled",
            SubscriptionState.Warned => "Warned",
            SubscriptionState.PastDue => "PastDue",
            SubscriptionState.Disabled => "Disabled",
            SubscriptionState.Deleted => "Deleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SubscriptionState value.")
        };

        public static SubscriptionState ToSubscriptionState(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase))
                return SubscriptionState.Enabled;
            if (string.Equals(value, "Warned", StringComparison.InvariantCultureIgnoreCase))
                return SubscriptionState.Warned;
            if (string.Equals(value, "PastDue", StringComparison.InvariantCultureIgnoreCase))
                return SubscriptionState.PastDue;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase))
                return SubscriptionState.Disabled;
            if (string.Equals(value, "Deleted", StringComparison.InvariantCultureIgnoreCase))
                return SubscriptionState.Deleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SubscriptionState value.");
        }
    }
}
