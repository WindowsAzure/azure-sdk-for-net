// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resources.Models
{
    /// <summary> The alias type. </summary>
    public partial class AliasType
    {
        /// <summary> Initializes a new instance of AliasType. </summary>
        internal AliasType()
        {
        }

        /// <summary> Initializes a new instance of AliasType. </summary>
        /// <param name="name"> The alias name. </param>
        /// <param name="paths"> The paths for an alias. </param>
        internal AliasType(string name, IReadOnlyList<AliasPathType> paths)
        {
            Name = name;
            Paths = paths;
        }

        /// <summary> The alias name. </summary>
        public string Name { get; }
        /// <summary> The paths for an alias. </summary>
        public IReadOnlyList<AliasPathType> Paths { get; }
    }
}
