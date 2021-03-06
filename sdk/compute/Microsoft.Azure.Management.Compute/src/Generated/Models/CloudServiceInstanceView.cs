// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InstanceView of CloudService as a whole
    /// </summary>
    public partial class CloudServiceInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the CloudServiceInstanceView class.
        /// </summary>
        public CloudServiceInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudServiceInstanceView class.
        /// </summary>
        /// <param name="sdkVersion">The version of the SDK that was used to
        /// generate the package for the cloud service.</param>
        /// <param name="privateIds">Specifies a list of unique identifiers
        /// generated internally for the cloud service. &lt;br /&gt;&lt;br
        /// /&gt; NOTE: If you are using Azure Diagnostics extension, this
        /// property can be used as 'DeploymentId' for querying
        /// details.</param>
        public CloudServiceInstanceView(InstanceViewStatusesSummary roleInstance = default(InstanceViewStatusesSummary), string sdkVersion = default(string), IList<string> privateIds = default(IList<string>), IList<ResourceInstanceViewStatus> statuses = default(IList<ResourceInstanceViewStatus>))
        {
            RoleInstance = roleInstance;
            SdkVersion = sdkVersion;
            PrivateIds = privateIds;
            Statuses = statuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleInstance")]
        public InstanceViewStatusesSummary RoleInstance { get; set; }

        /// <summary>
        /// Gets the version of the SDK that was used to generate the package
        /// for the cloud service.
        /// </summary>
        [JsonProperty(PropertyName = "sdkVersion")]
        public string SdkVersion { get; private set; }

        /// <summary>
        /// Gets specifies a list of unique identifiers generated internally
        /// for the cloud service. &amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt;
        /// NOTE: If you are using Azure Diagnostics extension, this property
        /// can be used as 'DeploymentId' for querying details.
        /// </summary>
        [JsonProperty(PropertyName = "privateIds")]
        public IList<string> PrivateIds { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<ResourceInstanceViewStatus> Statuses { get; private set; }

    }
}
