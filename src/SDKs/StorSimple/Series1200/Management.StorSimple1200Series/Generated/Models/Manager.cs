// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The StorSimple Manager
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Manager : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Manager class.
        /// </summary>
        public Manager()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Manager class.
        /// </summary>
        /// <param name="location">The Geo location of the Manager</param>
        /// <param name="id">The Resource Id</param>
        /// <param name="name">The Resource Name</param>
        /// <param name="type">The Resource type</param>
        /// <param name="tags">Tags attached to the Manager</param>
        /// <param name="cisIntrinsicSettings">Specifies if the Manager is
        /// Garda or Helsinki</param>
        /// <param name="provisioningState">Specifies the state of the resource
        /// as it is getting provisioned. Value of "Succeeded" means the
        /// Manager was successfully created</param>
        /// <param name="etag">ETag of the Manager</param>
        public Manager(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ManagerIntrinsicSettings cisIntrinsicSettings = default(ManagerIntrinsicSettings), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            CisIntrinsicSettings = cisIntrinsicSettings;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for Manager class.
        /// </summary>
        static Manager()
        {
            Sku = new ManagerSku();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies if the Manager is Garda or Helsinki
        /// </summary>
        [JsonProperty(PropertyName = "properties.cisIntrinsicSettings")]
        public ManagerIntrinsicSettings CisIntrinsicSettings { get; set; }

        /// <summary>
        /// Gets specifies the state of the resource as it is getting
        /// provisioned. Value of "Succeeded" means the Manager was
        /// successfully created
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets eTag of the Manager
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Specifies the Sku
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public static ManagerSku Sku { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CisIntrinsicSettings != null)
            {
                CisIntrinsicSettings.Validate();
            }
        }
    }
}
