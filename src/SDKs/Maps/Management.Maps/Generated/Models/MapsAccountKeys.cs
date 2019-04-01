// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The set of keys which can be used to access the Maps REST APIs. Two
    /// keys are provided for key rotation without interruption.
    /// </summary>
    public partial class MapsAccountKeys
    {
        /// <summary>
        /// Initializes a new instance of the MapsAccountKeys class.
        /// </summary>
        public MapsAccountKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapsAccountKeys class.
        /// </summary>
        /// <param name="id">The full Azure resource identifier of the Maps
        /// Account.</param>
        /// <param name="primaryKey">The primary key for accessing the Maps
        /// REST APIs.</param>
        /// <param name="secondaryKey">The secondary key for accessing the Maps
        /// REST APIs.</param>
        public MapsAccountKeys(string id = default(string), string primaryKey = default(string), string secondaryKey = default(string))
        {
            Id = id;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the full Azure resource identifier of the Maps Account.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the primary key for accessing the Maps REST APIs.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; private set; }

        /// <summary>
        /// Gets the secondary key for accessing the Maps REST APIs.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; private set; }

    }
}
