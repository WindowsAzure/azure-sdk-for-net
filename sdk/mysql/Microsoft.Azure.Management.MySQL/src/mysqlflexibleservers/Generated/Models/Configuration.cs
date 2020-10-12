// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Configuration.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Configuration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Configuration class.
        /// </summary>
        public Configuration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Configuration class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="value">Value of the configuration.</param>
        /// <param name="description">Description of the configuration.</param>
        /// <param name="defaultValue">Default value of the
        /// configuration.</param>
        /// <param name="dataType">Data type of the configuration.</param>
        /// <param name="allowedValues">Allowed values of the
        /// configuration.</param>
        /// <param name="source">Source of the configuration.</param>
        /// <param name="isReadOnly">If is the configuration read only.
        /// Possible values include: 'True', 'False'</param>
        /// <param name="isConfigPendingRestart">If is the configuration
        /// pending restart or not. Possible values include: 'True',
        /// 'False'</param>
        /// <param name="isDynamicConfig">If is the configuration dynamic.
        /// Possible values include: 'True', 'False'</param>
        public Configuration(string id = default(string), string name = default(string), string type = default(string), string value = default(string), string description = default(string), string defaultValue = default(string), string dataType = default(string), string allowedValues = default(string), string source = default(string), string isReadOnly = default(string), string isConfigPendingRestart = default(string), string isDynamicConfig = default(string))
            : base(id, name, type)
        {
            Value = value;
            Description = description;
            DefaultValue = defaultValue;
            DataType = dataType;
            AllowedValues = allowedValues;
            Source = source;
            IsReadOnly = isReadOnly;
            IsConfigPendingRestart = isConfigPendingRestart;
            IsDynamicConfig = isDynamicConfig;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets description of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets default value of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultValue")]
        public string DefaultValue { get; private set; }

        /// <summary>
        /// Gets data type of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataType")]
        public string DataType { get; private set; }

        /// <summary>
        /// Gets allowed values of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedValues")]
        public string AllowedValues { get; private set; }

        /// <summary>
        /// Gets or sets source of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets if is the configuration read only. Possible values include:
        /// 'True', 'False'
        /// </summary>
        [JsonProperty(PropertyName = "properties.isReadOnly")]
        public string IsReadOnly { get; private set; }

        /// <summary>
        /// Gets if is the configuration pending restart or not. Possible
        /// values include: 'True', 'False'
        /// </summary>
        [JsonProperty(PropertyName = "properties.isConfigPendingRestart")]
        public string IsConfigPendingRestart { get; private set; }

        /// <summary>
        /// Gets if is the configuration dynamic. Possible values include:
        /// 'True', 'False'
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDynamicConfig")]
        public string IsDynamicConfig { get; private set; }

    }
}
