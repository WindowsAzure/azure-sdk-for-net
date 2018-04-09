// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PolyBase settings.
    /// </summary>
    public partial class PolybaseSettings
    {
        /// <summary>
        /// Initializes a new instance of the PolybaseSettings class.
        /// </summary>
        public PolybaseSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolybaseSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="rejectType">Reject type. Possible values include:
        /// 'value', 'percentage'</param>
        /// <param name="rejectValue">Specifies the value or the percentage of
        /// rows that can be rejected before the query fails. Type: number (or
        /// Expression with resultType number), minimum: 0.</param>
        /// <param name="rejectSampleValue">Determines the number of rows to
        /// attempt to retrieve before the PolyBase recalculates the percentage
        /// of rejected rows. Type: integer (or Expression with resultType
        /// integer), minimum: 0.</param>
        /// <param name="useTypeDefault">Specifies how to handle missing values
        /// in delimited text files when PolyBase retrieves data from the text
        /// file. Type: boolean (or Expression with resultType
        /// boolean).</param>
        public PolybaseSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string rejectType = default(string), object rejectValue = default(object), object rejectSampleValue = default(object), object useTypeDefault = default(object))
        {
            AdditionalProperties = additionalProperties;
            RejectType = rejectType;
            RejectValue = rejectValue;
            RejectSampleValue = rejectSampleValue;
            UseTypeDefault = useTypeDefault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets reject type. Possible values include: 'value',
        /// 'percentage'
        /// </summary>
        [JsonProperty(PropertyName = "rejectType")]
        public string RejectType { get; set; }

        /// <summary>
        /// Gets or sets specifies the value or the percentage of rows that can
        /// be rejected before the query fails. Type: number (or Expression
        /// with resultType number), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "rejectValue")]
        public object RejectValue { get; set; }

        /// <summary>
        /// Gets or sets determines the number of rows to attempt to retrieve
        /// before the PolyBase recalculates the percentage of rejected rows.
        /// Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "rejectSampleValue")]
        public object RejectSampleValue { get; set; }

        /// <summary>
        /// Gets or sets specifies how to handle missing values in delimited
        /// text files when PolyBase retrieves data from the text file. Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "useTypeDefault")]
        public object UseTypeDefault { get; set; }

    }
}
