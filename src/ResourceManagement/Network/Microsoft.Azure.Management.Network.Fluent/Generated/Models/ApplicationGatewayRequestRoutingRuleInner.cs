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
    /// Request routing rule of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayRequestRoutingRuleInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRuleInner class.
        /// </summary>
        public ApplicationGatewayRequestRoutingRuleInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRuleInner class.
        /// </summary>
        /// <param name="ruleType">Rule type. Possible values include:
        /// 'Basic', 'PathBasedRouting'</param>
        /// <param name="backendAddressPool">Backend address pool resource of
        /// application gateway </param>
        /// <param name="backendHttpSettings">Frontend port resource of
        /// application gateway </param>
        /// <param name="httpListener">Http listener resource of application
        /// gateway </param>
        /// <param name="urlPathMap">Url path map resource of application
        /// gateway </param>
        /// <param name="provisioningState">Provisioning state of the request
        /// routing rule resource Updating/Deleting/Failed</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayRequestRoutingRuleInner(string id = default(string), string ruleType = default(string), Microsoft.Azure.Management.Resource.Fluent.SubResource backendAddressPool = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), Microsoft.Azure.Management.Resource.Fluent.SubResource backendHttpSettings = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), Microsoft.Azure.Management.Resource.Fluent.SubResource httpListener = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), Microsoft.Azure.Management.Resource.Fluent.SubResource urlPathMap = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            RuleType = ruleType;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets rule type. Possible values include: 'Basic',
        /// 'PathBasedRouting'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ruleType")]
        public string RuleType { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of application gateway
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backendAddressPool")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of application gateway
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets http listener resource of application gateway
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpListener")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource HttpListener { get; set; }

        /// <summary>
        /// Gets or sets url path map resource of application gateway
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.urlPathMap")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource UrlPathMap { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the request routing rule
        /// resource Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
