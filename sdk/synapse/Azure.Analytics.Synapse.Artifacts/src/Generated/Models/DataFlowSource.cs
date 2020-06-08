// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Transformation for data flow source. </summary>
    public partial class DataFlowSource : Transformation
    {
        /// <summary> Initializes a new instance of DataFlowSource. </summary>
        /// <param name="name"> Transformation name. </param>
        public DataFlowSource(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

        /// <summary> Initializes a new instance of DataFlowSource. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        /// <param name="dataset"> Dataset reference. </param>
        internal DataFlowSource(string name, string description, DatasetReference dataset) : base(name, description)
        {
            Dataset = dataset;
        }

        /// <summary> Dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
    }
}
