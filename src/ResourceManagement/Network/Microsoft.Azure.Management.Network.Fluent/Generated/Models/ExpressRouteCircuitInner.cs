// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// ExpressRouteCircuit resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuitInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitInner class.
        /// </summary>
        public ExpressRouteCircuitInner() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitInner class.
        /// </summary>
        /// <param name="sku">Gets or sets sku</param>
        /// <param name="allowClassicOperations">allow classic
        /// operations</param>
        /// <param name="circuitProvisioningState">Gets or sets
        /// CircuitProvisioningState state of the resource </param>
        /// <param name="serviceProviderProvisioningState">Gets or sets
        /// ServiceProviderProvisioningState state of the resource . Possible
        /// values include: 'NotProvisioned', 'Provisioning', 'Provisioned',
        /// 'Deprovisioning'</param>
        /// <param name="authorizations">Gets or sets list of
        /// authorizations</param>
        /// <param name="peerings">Gets or sets list of peerings</param>
        /// <param name="serviceKey">Gets or sets ServiceKey</param>
        /// <param name="serviceProviderNotes">Gets or sets
        /// ServiceProviderNotes</param>
        /// <param name="serviceProviderProperties">Gets or sets
        /// ServiceProviderProperties</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="gatewayManagerEtag">Gets or sets the GatewayManager
        /// Etag</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated</param>
        public ExpressRouteCircuitInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ExpressRouteCircuitSku sku = default(ExpressRouteCircuitSku), bool? allowClassicOperations = default(bool?), string circuitProvisioningState = default(string), string serviceProviderProvisioningState = default(string), System.Collections.Generic.IList<ExpressRouteCircuitAuthorizationInner> authorizations = default(System.Collections.Generic.IList<ExpressRouteCircuitAuthorizationInner>), System.Collections.Generic.IList<ExpressRouteCircuitPeeringInner> peerings = default(System.Collections.Generic.IList<ExpressRouteCircuitPeeringInner>), string serviceKey = default(string), string serviceProviderNotes = default(string), ExpressRouteCircuitServiceProviderProperties serviceProviderProperties = default(ExpressRouteCircuitServiceProviderProperties), string provisioningState = default(string), string gatewayManagerEtag = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            AllowClassicOperations = allowClassicOperations;
            CircuitProvisioningState = circuitProvisioningState;
            ServiceProviderProvisioningState = serviceProviderProvisioningState;
            Authorizations = authorizations;
            Peerings = peerings;
            ServiceKey = serviceKey;
            ServiceProviderNotes = serviceProviderNotes;
            ServiceProviderProperties = serviceProviderProperties;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets sku
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public ExpressRouteCircuitSku Sku { get; set; }

        /// <summary>
        /// Gets or sets allow classic operations
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowClassicOperations")]
        public bool? AllowClassicOperations { get; set; }

        /// <summary>
        /// Gets or sets CircuitProvisioningState state of the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.circuitProvisioningState")]
        public string CircuitProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets ServiceProviderProvisioningState state of the
        /// resource . Possible values include: 'NotProvisioned',
        /// 'Provisioning', 'Provisioned', 'Deprovisioning'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceProviderProvisioningState")]
        public string ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets list of authorizations
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authorizations")]
        public System.Collections.Generic.IList<ExpressRouteCircuitAuthorizationInner> Authorizations { get; set; }

        /// <summary>
        /// Gets or sets list of peerings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peerings")]
        public System.Collections.Generic.IList<ExpressRouteCircuitPeeringInner> Peerings { get; set; }

        /// <summary>
        /// Gets or sets ServiceKey
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceKey")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// Gets or sets ServiceProviderNotes
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// Gets or sets ServiceProviderProperties
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceProviderProperties")]
        public ExpressRouteCircuitServiceProviderProperties ServiceProviderProperties { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
