// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The restriction because of which SKU cannot be used.
    /// </summary>
    public partial class Restriction
    {
        /// <summary>
        /// Initializes a new instance of the Restriction class.
        /// </summary>
        public Restriction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Restriction class.
        /// </summary>
        /// <param name="type">The type of restrictions. As of now only
        /// possible value for this is location.</param>
        /// <param name="values">The value of restrictions. If the restriction
        /// type is set to location. This would be different locations where
        /// the SKU is restricted.</param>
        /// <param name="reasonCode">The reason for the restriction. As of now
        /// this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is
        /// set when the SKU has requiredQuotas parameter as the subscription
        /// does not belong to that quota. The "NotAvailableForSubscription" is
        /// related to capacity at DC. Possible values include: 'QuotaId',
        /// 'NotAvailableForSubscription'</param>
        public Restriction(string type = default(string), IList<string> values = default(IList<string>), string reasonCode = default(string))
        {
            Type = type;
            Values = values;
            ReasonCode = reasonCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of restrictions. As of now only possible value for
        /// this is location.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is
        /// restricted.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the restriction. As of now this can be
        /// "QuotaId" or "NotAvailableForSubscription". Quota Id is set when
        /// the SKU has requiredQuotas parameter as the subscription does not
        /// belong to that quota. The "NotAvailableForSubscription" is related
        /// to capacity at DC. Possible values include: 'QuotaId',
        /// 'NotAvailableForSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public string ReasonCode { get; set; }

    }
}
