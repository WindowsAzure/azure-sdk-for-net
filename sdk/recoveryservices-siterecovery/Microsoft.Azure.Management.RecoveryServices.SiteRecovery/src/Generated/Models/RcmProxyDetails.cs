// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// RCM proxy details.
    /// </summary>
    public partial class RcmProxyDetails
    {
        /// <summary>
        /// Initializes a new instance of the RcmProxyDetails class.
        /// </summary>
        public RcmProxyDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RcmProxyDetails class.
        /// </summary>
        /// <param name="id">The RCM proxy Id.</param>
        /// <param name="name">The RCM proxy name.</param>
        /// <param name="biosId">The RCM proxy Bios Id.</param>
        /// <param name="fabricObjectId">The fabric object Id.</param>
        /// <param name="fqdn">The RCM proxy Fqdn.</param>
        /// <param name="version">The version.</param>
        /// <param name="lastHeartbeatUtc">The last heartbeat received from the
        /// RCM proxy.</param>
        /// <param name="health">The health of the RCM proxy. Possible values
        /// include: 'None', 'Normal', 'Warning', 'Critical'</param>
        /// <param name="healthErrors">The health errors.</param>
        public RcmProxyDetails(string id = default(string), string name = default(string), string biosId = default(string), string fabricObjectId = default(string), string fqdn = default(string), string version = default(string), System.DateTime? lastHeartbeatUtc = default(System.DateTime?), string health = default(string), IList<HealthError> healthErrors = default(IList<HealthError>))
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            FabricObjectId = fabricObjectId;
            Fqdn = fqdn;
            Version = version;
            LastHeartbeatUtc = lastHeartbeatUtc;
            Health = health;
            HealthErrors = healthErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the RCM proxy Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the RCM proxy name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the RCM proxy Bios Id.
        /// </summary>
        [JsonProperty(PropertyName = "biosId")]
        public string BiosId { get; private set; }

        /// <summary>
        /// Gets the fabric object Id.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; private set; }

        /// <summary>
        /// Gets the RCM proxy Fqdn.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the last heartbeat received from the RCM proxy.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeatUtc")]
        public System.DateTime? LastHeartbeatUtc { get; private set; }

        /// <summary>
        /// Gets the health of the RCM proxy. Possible values include: 'None',
        /// 'Normal', 'Warning', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public string Health { get; private set; }

        /// <summary>
        /// Gets the health errors.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrors")]
        public IList<HealthError> HealthErrors { get; private set; }

    }
}
