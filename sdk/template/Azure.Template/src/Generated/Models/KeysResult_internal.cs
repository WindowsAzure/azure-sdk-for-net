// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer
{
    /// <summary> Keys extracted by the custom model. </summary>
    public partial class KeysResult_internal
    {
        /// <summary> Object mapping clusterIds to a list of keys. </summary>
        public IDictionary<string, ICollection<string>> Clusters { get; set; } = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.ICollection<string>>();
    }
}
