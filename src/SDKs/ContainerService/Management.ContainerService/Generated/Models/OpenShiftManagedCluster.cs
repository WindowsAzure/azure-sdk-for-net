// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// OpenShift Managed cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OpenShiftManagedCluster : Resource
    {
        /// <summary>
        /// Initializes a new instance of the OpenShiftManagedCluster class.
        /// </summary>
        public OpenShiftManagedCluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpenShiftManagedCluster class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="openShiftVersion">Version of OpenShift specified when
        /// creating the cluster.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="plan">Define the resource plan as required by ARM for
        /// billing purposes</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="publicHostname">Optional user-specified FQDN for
        /// OpenShift API server.</param>
        /// <param name="fqdn">User-specified FQDN for OpenShift API server
        /// loadbalancer internal hostname.</param>
        /// <param name="networkProfile">Configuration for OpenShift
        /// networking.</param>
        /// <param name="routerProfiles">Configuration for OpenShift
        /// router(s).</param>
        /// <param name="masterPoolProfile">Configuration for OpenShift master
        /// VMs.</param>
        /// <param name="agentPoolProfiles">Configuration of OpenShift cluster
        /// VMs.</param>
        /// <param name="authProfile">Configures OpenShift
        /// authentication.</param>
        public OpenShiftManagedCluster(string location, string openShiftVersion, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), PurchasePlan plan = default(PurchasePlan), string provisioningState = default(string), string publicHostname = default(string), string fqdn = default(string), NetworkProfile networkProfile = default(NetworkProfile), IList<OpenShiftRouterProfile> routerProfiles = default(IList<OpenShiftRouterProfile>), OpenShiftManagedClusterMasterPoolProfile masterPoolProfile = default(OpenShiftManagedClusterMasterPoolProfile), IList<OpenShiftManagedClusterAgentPoolProfile> agentPoolProfiles = default(IList<OpenShiftManagedClusterAgentPoolProfile>), OpenShiftManagedClusterAuthProfile authProfile = default(OpenShiftManagedClusterAuthProfile))
            : base(location, id, name, type, tags)
        {
            Plan = plan;
            ProvisioningState = provisioningState;
            OpenShiftVersion = openShiftVersion;
            PublicHostname = publicHostname;
            Fqdn = fqdn;
            NetworkProfile = networkProfile;
            RouterProfiles = routerProfiles;
            MasterPoolProfile = masterPoolProfile;
            AgentPoolProfiles = agentPoolProfiles;
            AuthProfile = authProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets define the resource plan as required by ARM for
        /// billing purposes
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public PurchasePlan Plan { get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets version of OpenShift specified when creating the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.openShiftVersion")]
        public string OpenShiftVersion { get; set; }

        /// <summary>
        /// Gets or sets optional user-specified FQDN for OpenShift API server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicHostname")]
        public string PublicHostname { get; set; }

        /// <summary>
        /// Gets or sets user-specified FQDN for OpenShift API server
        /// loadbalancer internal hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets configuration for OpenShift networking.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets configuration for OpenShift router(s).
        /// </summary>
        [JsonProperty(PropertyName = "properties.routerProfiles")]
        public IList<OpenShiftRouterProfile> RouterProfiles { get; set; }

        /// <summary>
        /// Gets or sets configuration for OpenShift master VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.masterPoolProfile")]
        public OpenShiftManagedClusterMasterPoolProfile MasterPoolProfile { get; set; }

        /// <summary>
        /// Gets or sets configuration of OpenShift cluster VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public IList<OpenShiftManagedClusterAgentPoolProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Gets or sets configures OpenShift authentication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authProfile")]
        public OpenShiftManagedClusterAuthProfile AuthProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (OpenShiftVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OpenShiftVersion");
            }
            if (MasterPoolProfile != null)
            {
                MasterPoolProfile.Validate();
            }
            if (AgentPoolProfiles != null)
            {
                foreach (var element in AgentPoolProfiles)
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
