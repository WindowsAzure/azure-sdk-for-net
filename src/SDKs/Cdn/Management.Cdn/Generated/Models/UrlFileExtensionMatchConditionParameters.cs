// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the parameters for UrlFileExtension match conditions
    /// </summary>
    public partial class UrlFileExtensionMatchConditionParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UrlFileExtensionMatchConditionParameters class.
        /// </summary>
        public UrlFileExtensionMatchConditionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UrlFileExtensionMatchConditionParameters class.
        /// </summary>
        /// <param name="operatorProperty">Describes operator to be matched.
        /// Possible values include: 'Any', 'Equal', 'Contains', 'BeginsWith',
        /// 'EndsWith', 'LessThan', 'LessThanOrEqual', 'GreaterThan',
        /// 'GreaterThanOrEqual'</param>
        /// <param name="matchValues">The match value for the condition of the
        /// delivery rule</param>
        /// <param name="negateCondition">Describes if this is negate condition
        /// or not</param>
        /// <param name="transforms">List of transforms</param>
        public UrlFileExtensionMatchConditionParameters(string operatorProperty, IList<string> matchValues, bool? negateCondition = default(bool?), IList<string> transforms = default(IList<string>))
        {
            OperatorProperty = operatorProperty;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for UrlFileExtensionMatchConditionParameters
        /// class.
        /// </summary>
        static UrlFileExtensionMatchConditionParameters()
        {
            Odatatype = "#Microsoft.Azure.Cdn.Models.DeliveryRuleUrlFileExtensionMatchConditionParameters";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes operator to be matched. Possible values
        /// include: 'Any', 'Equal', 'Contains', 'BeginsWith', 'EndsWith',
        /// 'LessThan', 'LessThanOrEqual', 'GreaterThan', 'GreaterThanOrEqual'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets describes if this is negate condition or not
        /// </summary>
        [JsonProperty(PropertyName = "negateCondition")]
        public bool? NegateCondition { get; set; }

        /// <summary>
        /// Gets or sets the match value for the condition of the delivery rule
        /// </summary>
        [JsonProperty(PropertyName = "matchValues")]
        public IList<string> MatchValues { get; set; }

        /// <summary>
        /// Gets or sets list of transforms
        /// </summary>
        [JsonProperty(PropertyName = "transforms")]
        public IList<string> Transforms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.type")]
        public static string Odatatype { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OperatorProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatorProperty");
            }
            if (MatchValues == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchValues");
            }
        }
    }
}
