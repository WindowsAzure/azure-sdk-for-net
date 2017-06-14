// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight.Models
{
    using Microsoft.HDInsight;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The HDInsight cluster application GET response.
    /// </summary>
    public partial class ApplicationGetProperties
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGetProperties class.
        /// </summary>
        public ApplicationGetProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGetProperties class.
        /// </summary>
        /// <param name="computeProfile">The list of roles in the
        /// cluster.</param>
        /// <param name="installScriptActions">The list of install script
        /// actions.</param>
        /// <param name="uninstallScriptActions">The list of uninstall script
        /// actions.</param>
        /// <param name="httpsEndpoints">The list of application HTTPS
        /// endpoints.</param>
        /// <param name="sshEndpoints">The list of application SSH
        /// endpoints.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// application.</param>
        /// <param name="applicationType">The application type.</param>
        /// <param name="applicationState">The application state.</param>
        /// <param name="errors">The list of errors.</param>
        /// <param name="createdDate">The application create date time.</param>
        /// <param name="marketplaceIdentifier">The marketplace
        /// identifier.</param>
        /// <param name="additionalProperties">The additional properties for
        /// application.</param>
        public ApplicationGetProperties(ComputeProfile computeProfile = default(ComputeProfile), IList<RuntimeScriptAction> installScriptActions = default(IList<RuntimeScriptAction>), IList<RuntimeScriptAction> uninstallScriptActions = default(IList<RuntimeScriptAction>), IList<ApplicationGetHttpsEndpoint> httpsEndpoints = default(IList<ApplicationGetHttpsEndpoint>), IList<ApplicationGetEndpoint> sshEndpoints = default(IList<ApplicationGetEndpoint>), string provisioningState = default(string), string applicationType = default(string), string applicationState = default(string), IList<Errors> errors = default(IList<Errors>), string createdDate = default(string), string marketplaceIdentifier = default(string), string additionalProperties = default(string))
        {
            ComputeProfile = computeProfile;
            InstallScriptActions = installScriptActions;
            UninstallScriptActions = uninstallScriptActions;
            HttpsEndpoints = httpsEndpoints;
            SshEndpoints = sshEndpoints;
            ProvisioningState = provisioningState;
            ApplicationType = applicationType;
            ApplicationState = applicationState;
            Errors = errors;
            CreatedDate = createdDate;
            MarketplaceIdentifier = marketplaceIdentifier;
            AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of roles in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "computeProfile")]
        public ComputeProfile ComputeProfile { get; set; }

        /// <summary>
        /// Gets or sets the list of install script actions.
        /// </summary>
        [JsonProperty(PropertyName = "installScriptActions")]
        public IList<RuntimeScriptAction> InstallScriptActions { get; set; }

        /// <summary>
        /// Gets or sets the list of uninstall script actions.
        /// </summary>
        [JsonProperty(PropertyName = "uninstallScriptActions")]
        public IList<RuntimeScriptAction> UninstallScriptActions { get; set; }

        /// <summary>
        /// Gets or sets the list of application HTTPS endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "httpsEndpoints")]
        public IList<ApplicationGetHttpsEndpoint> HttpsEndpoints { get; set; }

        /// <summary>
        /// Gets or sets the list of application SSH endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "sshEndpoints")]
        public IList<ApplicationGetEndpoint> SshEndpoints { get; set; }

        /// <summary>
        /// Gets the provisioning state of the application.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the application type.
        /// </summary>
        [JsonProperty(PropertyName = "applicationType")]
        public string ApplicationType { get; set; }

        /// <summary>
        /// Gets the application state.
        /// </summary>
        [JsonProperty(PropertyName = "applicationState")]
        public string ApplicationState { get; private set; }

        /// <summary>
        /// Gets or sets the list of errors.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Errors> Errors { get; set; }

        /// <summary>
        /// Gets the application create date time.
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Gets the marketplace identifier.
        /// </summary>
        [JsonProperty(PropertyName = "marketplaceIdentifier")]
        public string MarketplaceIdentifier { get; private set; }

        /// <summary>
        /// Gets or sets the additional properties for application.
        /// </summary>
        [JsonProperty(PropertyName = "additionalProperties")]
        public string AdditionalProperties { get; set; }

    }
}
