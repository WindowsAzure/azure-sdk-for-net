﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure
{
    internal static partial class DateTimeOffsetHelpers
    {
        public static DateTimeOffset GetUtcNow() => GetUtcNowImplementation();
    }
}
