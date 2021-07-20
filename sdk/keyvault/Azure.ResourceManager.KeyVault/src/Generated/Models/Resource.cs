// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> Key Vault resource. </summary>
    public partial class Resource : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        internal Resource(ResourceGroupResourceIdentifier id, string name, ResourceType type, string location, IReadOnlyDictionary<string, string> tags) : base(id, name, type)
        {
            Location = location;
            Tags = tags;
        }

        /// <summary> Azure location of the key vault resource. </summary>
        public string Location { get; }
        /// <summary> Tags assigned to the key vault resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
