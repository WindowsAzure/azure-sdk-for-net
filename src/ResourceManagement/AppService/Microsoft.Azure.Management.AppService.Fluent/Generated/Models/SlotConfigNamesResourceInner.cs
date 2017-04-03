// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Slot Config names azure resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SlotConfigNamesResourceInner : Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SlotConfigNamesResourceInner
        /// class.
        /// </summary>
        public SlotConfigNamesResourceInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SlotConfigNamesResourceInner
        /// class.
        /// </summary>
        /// <param name="connectionStringNames">List of connection string
        /// names.</param>
        /// <param name="appSettingNames">List of application settings
        /// names.</param>
        public SlotConfigNamesResourceInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> connectionStringNames = default(IList<string>), IList<string> appSettingNames = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            ConnectionStringNames = connectionStringNames;
            AppSettingNames = appSettingNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of connection string names.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStringNames")]
        public IList<string> ConnectionStringNames { get; set; }

        /// <summary>
        /// Gets or sets list of application settings names.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSettingNames")]
        public IList<string> AppSettingNames { get; set; }

    }
}
