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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This activity evaluates an expression and executes activities under the
    /// cases property that correspond to the expression evaluation expected in
    /// the equals property.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Switch")]
    [Rest.Serialization.JsonTransformation]
    public partial class SwitchActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the SwitchActivity class.
        /// </summary>
        public SwitchActivity()
        {
            On = new Expression();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwitchActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="on">An expression that would evaluate to a string or
        /// integer. This is used to determine the block of activities in cases
        /// that will be executed.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="cases">List of cases that correspond to expected
        /// values of the 'on' property. This is an optional property and if
        /// not provided, the activity will execute activities provided in
        /// defaultActivities.</param>
        /// <param name="defaultActivities">List of activities to execute if no
        /// case condition is satisfied. This is an optional property and if
        /// not provided, the activity will exit without any action.</param>
        public SwitchActivity(string name, Expression on, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), IList<SwitchCase> cases = default(IList<SwitchCase>), IList<Activity> defaultActivities = default(IList<Activity>))
            : base(name, additionalProperties, description, dependsOn, userProperties)
        {
            On = on;
            Cases = cases;
            DefaultActivities = defaultActivities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an expression that would evaluate to a string or
        /// integer. This is used to determine the block of activities in cases
        /// that will be executed.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.on")]
        public Expression On { get; set; }

        /// <summary>
        /// Gets or sets list of cases that correspond to expected values of
        /// the 'on' property. This is an optional property and if not
        /// provided, the activity will execute activities provided in
        /// defaultActivities.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.cases")]
        public IList<SwitchCase> Cases { get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute if no case condition is
        /// satisfied. This is an optional property and if not provided, the
        /// activity will exit without any action.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defaultActivities")]
        public IList<Activity> DefaultActivities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (On == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "On");
            }
            if (On != null)
            {
                On.Validate();
            }
            if (DefaultActivities != null)
            {
                foreach (var element in DefaultActivities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
