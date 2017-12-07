// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of hybrid runbook worker.
    /// </summary>
    public partial class HybridRunbookWorker
    {
        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorker class.
        /// </summary>
        public HybridRunbookWorker()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorker class.
        /// </summary>
        /// <param name="name">Gets or sets the worker machine name.</param>
        /// <param name="ip">Gets or sets the assigned machine IP
        /// address.</param>
        /// <param name="registrationTime">Gets or sets the registration time
        /// of the worker machine.</param>
        public HybridRunbookWorker(string name = default(string), string ip = default(string), System.DateTime? registrationTime = default(System.DateTime?))
        {
            Name = name;
            Ip = ip;
            RegistrationTime = registrationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the worker machine name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the assigned machine IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets the registration time of the worker machine.
        /// </summary>
        [JsonProperty(PropertyName = "registrationTime")]
        public System.DateTime? RegistrationTime { get; set; }

    }
}
