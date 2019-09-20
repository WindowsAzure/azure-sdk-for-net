﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Pipeline;

namespace Azure.Security.KeyVault
{
    internal interface IKeyVaultPipeline
    {
        DiagnosticScope CreateScope(string name);
    }
}
