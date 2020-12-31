// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role definition permissions. </summary>
    public partial class KeyVaultPermission
    {
        /// <summary> Initializes a new instance of KeyVaultPermission. </summary>
        public KeyVaultPermission()
        {
            AllowActions = new ChangeTrackingList<string>();
            DenyActions = new ChangeTrackingList<string>();
            AllowDataActions = new ChangeTrackingList<string>();
            DenyDataActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of KeyVaultPermission. </summary>
        /// <param name="allowActions"> Allowed actions. </param>
        /// <param name="denyActions"> Denied actions. </param>
        /// <param name="allowDataActions"> Allowed Data actions. </param>
        /// <param name="denyDataActions"> Denied Data actions. </param>
        internal KeyVaultPermission(IList<string> allowActions, IList<string> denyActions, IList<string> allowDataActions, IList<string> denyDataActions)
        {
            AllowActions = allowActions;
            DenyActions = denyActions;
            AllowDataActions = allowDataActions;
            DenyDataActions = denyDataActions;
        }
    }
}
