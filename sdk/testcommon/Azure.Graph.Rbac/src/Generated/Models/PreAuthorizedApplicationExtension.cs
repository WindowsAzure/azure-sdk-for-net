// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Representation of an app PreAuthorizedApplicationExtension required by a pre authorized client app. </summary>
    public partial class PreAuthorizedApplicationExtension
    {
        /// <summary> Initializes a new instance of PreAuthorizedApplicationExtension. </summary>
        public PreAuthorizedApplicationExtension()
        {
        }

        /// <summary> Initializes a new instance of PreAuthorizedApplicationExtension. </summary>
        /// <param name="conditions"> The extension&apos;s conditions. </param>
        internal PreAuthorizedApplicationExtension(IList<string> conditions)
        {
            Conditions = conditions;
        }

        /// <summary> The extension&apos;s conditions. </summary>
        public IList<string> Conditions { get; set; }
    }
}
