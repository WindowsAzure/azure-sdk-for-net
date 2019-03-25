// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// API spec for Microsoft.Security (Azure Security Center) resource
    /// provider
    /// </summary>
    public partial interface ISecurityCenterClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The location where ASC stores the data of the subscription. can be
        /// retrieved from Get locations
        /// </summary>
        string AscLocation { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IPricingsOperations.
        /// </summary>
        IPricingsOperations Pricings { get; }

        /// <summary>
        /// Gets the ISecurityContactsOperations.
        /// </summary>
        ISecurityContactsOperations SecurityContacts { get; }

        /// <summary>
        /// Gets the IWorkspaceSettingsOperations.
        /// </summary>
        IWorkspaceSettingsOperations WorkspaceSettings { get; }

        /// <summary>
        /// Gets the IAutoProvisioningSettingsOperations.
        /// </summary>
        IAutoProvisioningSettingsOperations AutoProvisioningSettings { get; }

        /// <summary>
        /// Gets the ICompliancesOperations.
        /// </summary>
        ICompliancesOperations Compliances { get; }

        /// <summary>
        /// Gets the IAdvancedThreatProtectionOperations.
        /// </summary>
        IAdvancedThreatProtectionOperations AdvancedThreatProtection { get; }

        /// <summary>
        /// Gets the IDeviceSecurityGroupsOperations.
        /// </summary>
        IDeviceSecurityGroupsOperations DeviceSecurityGroups { get; }

        /// <summary>
        /// Gets the ISettingsOperations.
        /// </summary>
        ISettingsOperations Settings { get; }

        /// <summary>
        /// Gets the IInformationProtectionPoliciesOperations.
        /// </summary>
        IInformationProtectionPoliciesOperations InformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the ILocationsOperations.
        /// </summary>
        ILocationsOperations Locations { get; }

        /// <summary>
        /// Gets the ITasksOperations.
        /// </summary>
        ITasksOperations Tasks { get; }

        /// <summary>
        /// Gets the IAlertsOperations.
        /// </summary>
        IAlertsOperations Alerts { get; }

        /// <summary>
        /// Gets the IDiscoveredSecuritySolutionsOperations.
        /// </summary>
        IDiscoveredSecuritySolutionsOperations DiscoveredSecuritySolutions { get; }

        /// <summary>
        /// Gets the IJitNetworkAccessPoliciesOperations.
        /// </summary>
        IJitNetworkAccessPoliciesOperations JitNetworkAccessPolicies { get; }

        /// <summary>
        /// Gets the IExternalSecuritySolutionsOperations.
        /// </summary>
        IExternalSecuritySolutionsOperations ExternalSecuritySolutions { get; }

        /// <summary>
        /// Gets the ITopologyOperations.
        /// </summary>
        ITopologyOperations Topology { get; }

        /// <summary>
        /// Gets the IAllowedConnectionsOperations.
        /// </summary>
        IAllowedConnectionsOperations AllowedConnections { get; }

        /// <summary>
        /// Gets the IAdaptiveNetworkHardeningsOperations.
        /// </summary>
        IAdaptiveNetworkHardeningsOperations AdaptiveNetworkHardenings { get; }

    }
}
