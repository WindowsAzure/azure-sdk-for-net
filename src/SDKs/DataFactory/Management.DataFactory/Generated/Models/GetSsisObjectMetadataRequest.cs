// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request payload of get SSIS object metadata.
    /// </summary>
    public partial class GetSsisObjectMetadataRequest
    {
        /// <summary>
        /// Initializes a new instance of the GetSsisObjectMetadataRequest
        /// class.
        /// </summary>
        public GetSsisObjectMetadataRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetSsisObjectMetadataRequest
        /// class.
        /// </summary>
        /// <param name="metadataPath">Metadata path.</param>
        public GetSsisObjectMetadataRequest(string metadataPath = default(string))
        {
            MetadataPath = metadataPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets metadata path.
        /// </summary>
        [JsonProperty(PropertyName = "metadataPath")]
        public string MetadataPath { get; set; }

    }
}
