// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.ChangeAnalysis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data of a property change.
    /// </summary>
    public partial class PropertyChange
    {
        /// <summary>
        /// Initializes a new instance of the PropertyChange class.
        /// </summary>
        public PropertyChange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PropertyChange class.
        /// </summary>
        /// <param name="changeType">Possible values include: 'Add', 'Remove',
        /// 'Update'</param>
        /// <param name="changeCategory">The change category. Possible values
        /// include: 'User', 'System'</param>
        /// <param name="jsonPath">The json path of the changed
        /// property.</param>
        /// <param name="displayName">The enhanced display name of the json
        /// path. E.g., the json path value[0].properties will be translated to
        /// something meaningful like slots["Staging"].properties.</param>
        /// <param name="level">Possible values include: 'Noisy', 'Normal',
        /// 'Important'</param>
        /// <param name="description">The description of the changed
        /// property.</param>
        /// <param name="oldValue">The value of the property before the
        /// change.</param>
        /// <param name="newValue">The value of the property after the
        /// change.</param>
        /// <param name="isDataMasked">The boolean indicating whether the
        /// oldValue and newValue are masked. The values are masked if it
        /// contains sensitive information that the user doesn't have access
        /// to.</param>
        public PropertyChange(string changeType = default(string), ChangeCategory? changeCategory = default(ChangeCategory?), string jsonPath = default(string), string displayName = default(string), string level = default(string), string description = default(string), string oldValue = default(string), string newValue = default(string), bool? isDataMasked = default(bool?))
        {
            ChangeType = changeType;
            ChangeCategory = changeCategory;
            JsonPath = jsonPath;
            DisplayName = displayName;
            Level = level;
            Description = description;
            OldValue = oldValue;
            NewValue = newValue;
            IsDataMasked = isDataMasked;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Add', 'Remove', 'Update'
        /// </summary>
        [JsonProperty(PropertyName = "changeType")]
        public string ChangeType { get; set; }

        /// <summary>
        /// Gets or sets the change category. Possible values include: 'User',
        /// 'System'
        /// </summary>
        [JsonProperty(PropertyName = "changeCategory")]
        public ChangeCategory? ChangeCategory { get; set; }

        /// <summary>
        /// Gets or sets the json path of the changed property.
        /// </summary>
        [JsonProperty(PropertyName = "jsonPath")]
        public string JsonPath { get; set; }

        /// <summary>
        /// Gets or sets the enhanced display name of the json path. E.g., the
        /// json path value[0].properties will be translated to something
        /// meaningful like slots["Staging"].properties.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Noisy', 'Normal',
        /// 'Important'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets the description of the changed property.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value of the property before the change.
        /// </summary>
        [JsonProperty(PropertyName = "oldValue")]
        public string OldValue { get; set; }

        /// <summary>
        /// Gets or sets the value of the property after the change.
        /// </summary>
        [JsonProperty(PropertyName = "newValue")]
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or sets the boolean indicating whether the oldValue and
        /// newValue are masked. The values are masked if it contains sensitive
        /// information that the user doesn't have access to.
        /// </summary>
        [JsonProperty(PropertyName = "isDataMasked")]
        public bool? IsDataMasked { get; set; }

    }
}
