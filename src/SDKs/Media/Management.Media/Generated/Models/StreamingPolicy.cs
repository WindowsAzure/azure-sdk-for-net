// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Streaming Policy resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StreamingPolicy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the StreamingPolicy class.
        /// </summary>
        public StreamingPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingPolicy class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="created">Creation time of Streaming Policy</param>
        /// <param name="defaultContentKeyPolicyName">Default ContentKey used
        /// by current Streaming Policy</param>
        /// <param name="envelopeEncryption">Configuration of
        /// EnvelopeEncryption</param>
        /// <param name="commonEncryptionCenc">Configuration of
        /// CommonEncryptionCenc</param>
        /// <param name="commonEncryptionCbcs">Configuration of
        /// CommonEncryptionCbcs</param>
        /// <param name="noEncryption">Configurations of NoEncryption</param>
        public StreamingPolicy(string id = default(string), string name = default(string), string type = default(string), System.DateTime created = default(System.DateTime), string defaultContentKeyPolicyName = default(string), EnvelopeEncryption envelopeEncryption = default(EnvelopeEncryption), CommonEncryptionCenc commonEncryptionCenc = default(CommonEncryptionCenc), CommonEncryptionCbcs commonEncryptionCbcs = default(CommonEncryptionCbcs), NoEncryption noEncryption = default(NoEncryption))
            : base(id, name, type)
        {
            Created = created;
            DefaultContentKeyPolicyName = defaultContentKeyPolicyName;
            EnvelopeEncryption = envelopeEncryption;
            CommonEncryptionCenc = commonEncryptionCenc;
            CommonEncryptionCbcs = commonEncryptionCbcs;
            NoEncryption = noEncryption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets creation time of Streaming Policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets or sets default ContentKey used by current Streaming Policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultContentKeyPolicyName")]
        public string DefaultContentKeyPolicyName { get; set; }

        /// <summary>
        /// Gets or sets configuration of EnvelopeEncryption
        /// </summary>
        [JsonProperty(PropertyName = "properties.envelopeEncryption")]
        public EnvelopeEncryption EnvelopeEncryption { get; set; }

        /// <summary>
        /// Gets or sets configuration of CommonEncryptionCenc
        /// </summary>
        [JsonProperty(PropertyName = "properties.commonEncryptionCenc")]
        public CommonEncryptionCenc CommonEncryptionCenc { get; set; }

        /// <summary>
        /// Gets or sets configuration of CommonEncryptionCbcs
        /// </summary>
        [JsonProperty(PropertyName = "properties.commonEncryptionCbcs")]
        public CommonEncryptionCbcs CommonEncryptionCbcs { get; set; }

        /// <summary>
        /// Gets or sets configurations of NoEncryption
        /// </summary>
        [JsonProperty(PropertyName = "properties.noEncryption")]
        public NoEncryption NoEncryption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EnvelopeEncryption != null)
            {
                EnvelopeEncryption.Validate();
            }
            if (CommonEncryptionCenc != null)
            {
                CommonEncryptionCenc.Validate();
            }
            if (CommonEncryptionCbcs != null)
            {
                CommonEncryptionCbcs.Validate();
            }
            if (NoEncryption != null)
            {
                NoEncryption.Validate();
            }
        }
    }
}
