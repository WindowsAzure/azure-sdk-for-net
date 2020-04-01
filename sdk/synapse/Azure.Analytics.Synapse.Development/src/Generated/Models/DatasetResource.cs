// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Dataset resource type. </summary>
    public partial class DatasetResource : SubResource
    {
        /// <summary> Initializes a new instance of DatasetResource. </summary>
        /// <param name="properties"> Dataset properties. </param>
        public DatasetResource(Dataset properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DatasetResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="properties"> Dataset properties. </param>
        internal DatasetResource(string id, string name, string type, string etag, Dataset properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Dataset properties. </summary>
        public Dataset Properties { get; set; }
    }
}
