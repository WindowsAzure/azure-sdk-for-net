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
    /// Integration runtime status.
    /// </summary>
    public partial class IntegrationRuntimeStatus
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeStatus class.
        /// </summary>
        public IntegrationRuntimeStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeStatus class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="dataFactoryName">The data factory name which the
        /// integration runtime belong to.</param>
        /// <param name="state">The state of integration runtime. Possible
        /// values include: 'Initial', 'Stopped', 'Started', 'Starting',
        /// 'Stopping', 'NeedRegistration', 'Online', 'Limited',
        /// 'Offline'</param>
        public IntegrationRuntimeStatus(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string dataFactoryName = default(string), string state = default(string))
        {
            AdditionalProperties = additionalProperties;
            DataFactoryName = dataFactoryName;
            State = state;
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
        /// Gets the data factory name which the integration runtime belong to.
        /// </summary>
        [JsonProperty(PropertyName = "dataFactoryName")]
        public string DataFactoryName { get; private set; }

        /// <summary>
        /// Gets the state of integration runtime. Possible values include:
        /// 'Initial', 'Stopped', 'Started', 'Starting', 'Stopping',
        /// 'NeedRegistration', 'Online', 'Limited', 'Offline'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

    }
}
