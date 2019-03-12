// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Security alert
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Alert : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="state">State of the alert (Active, Dismissed
        /// etc.)</param>
        /// <param name="reportedTimeUtc">The time the incident was reported to
        /// Microsoft.Security in UTC</param>
        /// <param name="vendorName">Name of the vendor that discovered the
        /// incident</param>
        /// <param name="alertName">Name of the alert type</param>
        /// <param name="alertDisplayName">Display name of the alert
        /// type</param>
        /// <param name="detectedTimeUtc">The time the incident was detected by
        /// the vendor</param>
        /// <param name="description">Description of the incident and what it
        /// means</param>
        /// <param name="remediationSteps">Recommended steps to reradiate the
        /// incident</param>
        /// <param name="actionTaken">The action that was taken as a response
        /// to the alert (Active, Blocked etc.)</param>
        /// <param name="reportedSeverity">Estimated severity of this alert.
        /// Possible values include: 'Informational', 'Low', 'Medium',
        /// 'High'</param>
        /// <param name="compromisedEntity">The entity that the incident
        /// happened on</param>
        /// <param name="associatedResource">Azure resource ID of the
        /// associated resource</param>
        /// <param name="systemSource">The type of the alerted resource (Azure,
        /// Non-Azure)</param>
        /// <param name="canBeInvestigated">Whether this alert can be
        /// investigated with Azure Security Center</param>
        /// <param name="isIncident">Whether this alert is for incident type or
        /// not (otherwise - single alert)</param>
        /// <param name="entities">objects that are related to this
        /// alerts</param>
        /// <param name="confidenceScore">level of confidence we have on the
        /// alert</param>
        /// <param name="confidenceReasons">reasons the alert got the
        /// confidenceScore value</param>
        /// <param name="subscriptionId">Azure subscription ID of the resource
        /// that had the security alert or the subscription ID of the workspace
        /// that this resource reports to</param>
        /// <param name="instanceId">Instance ID of the alert.</param>
        /// <param name="workspaceArmId">Azure resource ID of the workspace
        /// that the alert was reported to.</param>
        /// <param name="correlationKey">Correlation Key of the alert.</param>
        public Alert(string id = default(string), string name = default(string), string type = default(string), string state = default(string), System.DateTime? reportedTimeUtc = default(System.DateTime?), string vendorName = default(string), string alertName = default(string), string alertDisplayName = default(string), System.DateTime? detectedTimeUtc = default(System.DateTime?), string description = default(string), string remediationSteps = default(string), string actionTaken = default(string), string reportedSeverity = default(string), string compromisedEntity = default(string), string associatedResource = default(string), IDictionary<string, object> extendedProperties = default(IDictionary<string, object>), string systemSource = default(string), bool? canBeInvestigated = default(bool?), bool? isIncident = default(bool?), IList<AlertEntity> entities = default(IList<AlertEntity>), double? confidenceScore = default(double?), IList<AlertConfidenceReason> confidenceReasons = default(IList<AlertConfidenceReason>), string subscriptionId = default(string), string instanceId = default(string), string workspaceArmId = default(string), string correlationKey = default(string))
            : base(id, name, type)
        {
            State = state;
            ReportedTimeUtc = reportedTimeUtc;
            VendorName = vendorName;
            AlertName = alertName;
            AlertDisplayName = alertDisplayName;
            DetectedTimeUtc = detectedTimeUtc;
            Description = description;
            RemediationSteps = remediationSteps;
            ActionTaken = actionTaken;
            ReportedSeverity = reportedSeverity;
            CompromisedEntity = compromisedEntity;
            AssociatedResource = associatedResource;
            ExtendedProperties = extendedProperties;
            SystemSource = systemSource;
            CanBeInvestigated = canBeInvestigated;
            IsIncident = isIncident;
            Entities = entities;
            ConfidenceScore = confidenceScore;
            ConfidenceReasons = confidenceReasons;
            SubscriptionId = subscriptionId;
            InstanceId = instanceId;
            WorkspaceArmId = workspaceArmId;
            CorrelationKey = correlationKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets state of the alert (Active, Dismissed etc.)
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the time the incident was reported to Microsoft.Security in
        /// UTC
        /// </summary>
        [JsonProperty(PropertyName = "properties.reportedTimeUtc")]
        public System.DateTime? ReportedTimeUtc { get; private set; }

        /// <summary>
        /// Gets name of the vendor that discovered the incident
        /// </summary>
        [JsonProperty(PropertyName = "properties.vendorName")]
        public string VendorName { get; private set; }

        /// <summary>
        /// Gets name of the alert type
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertName")]
        public string AlertName { get; private set; }

        /// <summary>
        /// Gets display name of the alert type
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertDisplayName")]
        public string AlertDisplayName { get; private set; }

        /// <summary>
        /// Gets the time the incident was detected by the vendor
        /// </summary>
        [JsonProperty(PropertyName = "properties.detectedTimeUtc")]
        public System.DateTime? DetectedTimeUtc { get; private set; }

        /// <summary>
        /// Gets description of the incident and what it means
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets recommended steps to reradiate the incident
        /// </summary>
        [JsonProperty(PropertyName = "properties.remediationSteps")]
        public string RemediationSteps { get; private set; }

        /// <summary>
        /// Gets the action that was taken as a response to the alert (Active,
        /// Blocked etc.)
        /// </summary>
        [JsonProperty(PropertyName = "properties.actionTaken")]
        public string ActionTaken { get; private set; }

        /// <summary>
        /// Gets estimated severity of this alert. Possible values include:
        /// 'Informational', 'Low', 'Medium', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "properties.reportedSeverity")]
        public string ReportedSeverity { get; private set; }

        /// <summary>
        /// Gets the entity that the incident happened on
        /// </summary>
        [JsonProperty(PropertyName = "properties.compromisedEntity")]
        public string CompromisedEntity { get; private set; }

        /// <summary>
        /// Gets azure resource ID of the associated resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.associatedResource")]
        public string AssociatedResource { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.extendedProperties")]
        public IDictionary<string, object> ExtendedProperties { get; set; }

        /// <summary>
        /// Gets the type of the alerted resource (Azure, Non-Azure)
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemSource")]
        public string SystemSource { get; private set; }

        /// <summary>
        /// Gets whether this alert can be investigated with Azure Security
        /// Center
        /// </summary>
        [JsonProperty(PropertyName = "properties.canBeInvestigated")]
        public bool? CanBeInvestigated { get; private set; }

        /// <summary>
        /// Gets whether this alert is for incident type or not (otherwise -
        /// single alert)
        /// </summary>
        [JsonProperty(PropertyName = "properties.isIncident")]
        public bool? IsIncident { get; private set; }

        /// <summary>
        /// Gets or sets objects that are related to this alerts
        /// </summary>
        [JsonProperty(PropertyName = "properties.entities")]
        public IList<AlertEntity> Entities { get; set; }

        /// <summary>
        /// Gets level of confidence we have on the alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.confidenceScore")]
        public double? ConfidenceScore { get; private set; }

        /// <summary>
        /// Gets or sets reasons the alert got the confidenceScore value
        /// </summary>
        [JsonProperty(PropertyName = "properties.confidenceReasons")]
        public IList<AlertConfidenceReason> ConfidenceReasons { get; set; }

        /// <summary>
        /// Gets azure subscription ID of the resource that had the security
        /// alert or the subscription ID of the workspace that this resource
        /// reports to
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets instance ID of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceId")]
        public string InstanceId { get; private set; }

        /// <summary>
        /// Gets azure resource ID of the workspace that the alert was reported
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceArmId")]
        public string WorkspaceArmId { get; private set; }

        /// <summary>
        /// Gets correlation Key of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlationKey")]
        public string CorrelationKey { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConfidenceScore > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ConfidenceScore", 1);
            }
            if (ConfidenceScore < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ConfidenceScore", 0);
            }
        }
    }
}
