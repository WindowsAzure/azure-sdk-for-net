// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A Class representing a DeletedVault along with the instance operations that can be performed on it. </summary>
    public class DeletedVault : DeletedVaultOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "DeletedVault"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DeletedVault(OperationsBase options, DeletedVaultData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the DeletedVaultData. </summary>
        public DeletedVaultData Data { get; private set; }
    }
}
