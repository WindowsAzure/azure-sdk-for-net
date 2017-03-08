// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// Description of a NotificationHub PNS Credentials.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class PnsCredentialsResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PnsCredentialsResource class.
        /// </summary>
        public PnsCredentialsResource() { }

        /// <summary>
        /// Initializes a new instance of the PnsCredentialsResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The sku of the created namespace</param>
        /// <param name="apnsCredential">The ApnsCredential of the created
        /// NotificationHub</param>
        /// <param name="wnsCredential">The WnsCredential of the created
        /// NotificationHub</param>
        /// <param name="gcmCredential">The GcmCredential of the created
        /// NotificationHub</param>
        /// <param name="mpnsCredential">The MpnsCredential of the created
        /// NotificationHub</param>
        /// <param name="admCredential">The AdmCredential of the created
        /// NotificationHub</param>
        /// <param name="baiduCredential">The BaiduCredential of the created
        /// NotificationHub</param>
        public PnsCredentialsResource(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Sku sku = default(Sku), ApnsCredential apnsCredential = default(ApnsCredential), WnsCredential wnsCredential = default(WnsCredential), GcmCredential gcmCredential = default(GcmCredential), MpnsCredential mpnsCredential = default(MpnsCredential), AdmCredential admCredential = default(AdmCredential), BaiduCredential baiduCredential = default(BaiduCredential))
            : base(location, id, name, type, tags, sku)
        {
            ApnsCredential = apnsCredential;
            WnsCredential = wnsCredential;
            GcmCredential = gcmCredential;
            MpnsCredential = mpnsCredential;
            AdmCredential = admCredential;
            BaiduCredential = baiduCredential;
        }

        /// <summary>
        /// Gets or sets the ApnsCredential of the created NotificationHub
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.apnsCredential")]
        public ApnsCredential ApnsCredential { get; set; }

        /// <summary>
        /// Gets or sets the WnsCredential of the created NotificationHub
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.wnsCredential")]
        public WnsCredential WnsCredential { get; set; }

        /// <summary>
        /// Gets or sets the GcmCredential of the created NotificationHub
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gcmCredential")]
        public GcmCredential GcmCredential { get; set; }

        /// <summary>
        /// Gets or sets the MpnsCredential of the created NotificationHub
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.mpnsCredential")]
        public MpnsCredential MpnsCredential { get; set; }

        /// <summary>
        /// Gets or sets the AdmCredential of the created NotificationHub
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.admCredential")]
        public AdmCredential AdmCredential { get; set; }

        /// <summary>
        /// Gets or sets the BaiduCredential of the created NotificationHub
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.baiduCredential")]
        public BaiduCredential BaiduCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
