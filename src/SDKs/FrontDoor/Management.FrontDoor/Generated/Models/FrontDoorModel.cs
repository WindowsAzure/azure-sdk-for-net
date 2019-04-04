// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Front Door represents a collection of backend endpoints to route
    /// traffic to along with rules that specify how traffic is sent there.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FrontDoorModel : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FrontDoorModel class.
        /// </summary>
        public FrontDoorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FrontDoorModel class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="friendlyName">A friendly name for the
        /// frontDoor</param>
        /// <param name="routingRules">Routing rules associated with this Front
        /// Door.</param>
        /// <param name="loadBalancingSettings">Load balancing settings
        /// associated with this Front Door instance.</param>
        /// <param name="healthProbeSettings">Health probe settings associated
        /// with this Front Door instance.</param>
        /// <param name="backendPools">Backend pools available to routing
        /// rules.</param>
        /// <param name="frontendEndpoints">Frontend endpoints available to
        /// routing rules.</param>
        /// <param name="backendPoolsSettings">Settings for all
        /// backendPools</param>
        /// <param name="enabledState">Operational status of the Front Door
        /// load balancer. Permitted values are 'Enabled' or 'Disabled'.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="resourceState">Resource status of the Front Door.
        /// Possible values include: 'Creating', 'Enabling', 'Enabled',
        /// 'Disabling', 'Disabled', 'Deleting'</param>
        /// <param name="provisioningState">Provisioning state of the Front
        /// Door.</param>
        /// <param name="cname">The host that each frontendEndpoint must CNAME
        /// to.</param>
        public FrontDoorModel(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string friendlyName = default(string), IList<RoutingRule> routingRules = default(IList<RoutingRule>), IList<LoadBalancingSettingsModel> loadBalancingSettings = default(IList<LoadBalancingSettingsModel>), IList<HealthProbeSettingsModel> healthProbeSettings = default(IList<HealthProbeSettingsModel>), IList<BackendPool> backendPools = default(IList<BackendPool>), IList<FrontendEndpoint> frontendEndpoints = default(IList<FrontendEndpoint>), BackendPoolsSettings backendPoolsSettings = default(BackendPoolsSettings), string enabledState = default(string), string resourceState = default(string), string provisioningState = default(string), string cname = default(string))
            : base(id, name, type, location, tags)
        {
            FriendlyName = friendlyName;
            RoutingRules = routingRules;
            LoadBalancingSettings = loadBalancingSettings;
            HealthProbeSettings = healthProbeSettings;
            BackendPools = backendPools;
            FrontendEndpoints = frontendEndpoints;
            BackendPoolsSettings = backendPoolsSettings;
            EnabledState = enabledState;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
            Cname = cname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a friendly name for the frontDoor
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets routing rules associated with this Front Door.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingRules")]
        public IList<RoutingRule> RoutingRules { get; set; }

        /// <summary>
        /// Gets or sets load balancing settings associated with this Front
        /// Door instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingSettings")]
        public IList<LoadBalancingSettingsModel> LoadBalancingSettings { get; set; }

        /// <summary>
        /// Gets or sets health probe settings associated with this Front Door
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthProbeSettings")]
        public IList<HealthProbeSettingsModel> HealthProbeSettings { get; set; }

        /// <summary>
        /// Gets or sets backend pools available to routing rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendPools")]
        public IList<BackendPool> BackendPools { get; set; }

        /// <summary>
        /// Gets or sets frontend endpoints available to routing rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendEndpoints")]
        public IList<FrontendEndpoint> FrontendEndpoints { get; set; }

        /// <summary>
        /// Gets or sets settings for all backendPools
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendPoolsSettings")]
        public BackendPoolsSettings BackendPoolsSettings { get; set; }

        /// <summary>
        /// Gets or sets operational status of the Front Door load balancer.
        /// Permitted values are 'Enabled' or 'Disabled'. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets or sets resource status of the Front Door. Possible values
        /// include: 'Creating', 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; set; }

        /// <summary>
        /// Gets provisioning state of the Front Door.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the host that each frontendEndpoint must CNAME to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cname")]
        public string Cname { get; private set; }

    }
}
