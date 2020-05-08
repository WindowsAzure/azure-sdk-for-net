// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response of the List Namespace IDs operation
    /// </summary>
    public partial class EHNamespaceIdListResult
    {
        /// <summary>
        /// Initializes a new instance of the EHNamespaceIdListResult class.
        /// </summary>
        public EHNamespaceIdListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EHNamespaceIdListResult class.
        /// </summary>
        /// <param name="value">Result of the List Namespace IDs
        /// operation</param>
        public EHNamespaceIdListResult(IList<EHNamespaceIdContainer> value = default(IList<EHNamespaceIdContainer>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets result of the List Namespace IDs operation
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<EHNamespaceIdContainer> Value { get; set; }

    }
}
