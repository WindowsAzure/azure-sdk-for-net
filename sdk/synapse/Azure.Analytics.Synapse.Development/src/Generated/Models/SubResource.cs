// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Azure Synapse nested resource, which belongs to a workspace. </summary>
    public partial class SubResource
    {
        /// <summary> Initializes a new instance of SubResource. </summary>
        public SubResource()
        {
        }

        /// <summary> Initializes a new instance of SubResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        internal SubResource(string id, string name, string type, string etag)
        {
            Id = id;
            Name = name;
            Type = type;
            Etag = etag;
        }

        /// <summary> The resource identifier. </summary>
        public string Id { get; }
        /// <summary> The resource name. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public string Type { get; }
        /// <summary> Etag identifies change in the resource. </summary>
        public string Etag { get; }
    }
}
