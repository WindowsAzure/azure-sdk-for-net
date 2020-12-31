// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DataSource filter. Right now, only filter by kind is supported.
    /// </summary>
    public partial class DataSourceFilter
    {
        /// <summary>
        /// Initializes a new instance of the DataSourceFilter class.
        /// </summary>
        public DataSourceFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataSourceFilter class.
        /// </summary>
        /// <param name="kind">Possible values include: 'WindowsEvent',
        /// 'WindowsPerformanceCounter', 'IISLogs', 'LinuxSyslog',
        /// 'LinuxSyslogCollection', 'LinuxPerformanceObject',
        /// 'LinuxPerformanceCollection', 'CustomLog', 'CustomLogCollection',
        /// 'AzureAuditLog', 'AzureActivityLog', 'GenericDataSource',
        /// 'ChangeTrackingCustomPath', 'ChangeTrackingPath',
        /// 'ChangeTrackingServices', 'ChangeTrackingDataTypeConfiguration',
        /// 'ChangeTrackingDefaultRegistry', 'ChangeTrackingRegistry',
        /// 'ChangeTrackingLinuxPath', 'LinuxChangeTrackingPath',
        /// 'ChangeTrackingContentLocation', 'WindowsTelemetry', 'Office365',
        /// 'SecurityWindowsBaselineConfiguration',
        /// 'SecurityCenterSecurityWindowsBaselineConfiguration',
        /// 'SecurityEventCollectionConfiguration',
        /// 'SecurityInsightsSecurityEventCollectionConfiguration',
        /// 'ImportComputerGroup', 'NetworkMonitoring', 'Itsm', 'DnsAnalytics',
        /// 'ApplicationInsights', 'SqlDataClassification'</param>
        public DataSourceFilter(string kind = default(string))
        {
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'WindowsEvent',
        /// 'WindowsPerformanceCounter', 'IISLogs', 'LinuxSyslog',
        /// 'LinuxSyslogCollection', 'LinuxPerformanceObject',
        /// 'LinuxPerformanceCollection', 'CustomLog', 'CustomLogCollection',
        /// 'AzureAuditLog', 'AzureActivityLog', 'GenericDataSource',
        /// 'ChangeTrackingCustomPath', 'ChangeTrackingPath',
        /// 'ChangeTrackingServices', 'ChangeTrackingDataTypeConfiguration',
        /// 'ChangeTrackingDefaultRegistry', 'ChangeTrackingRegistry',
        /// 'ChangeTrackingLinuxPath', 'LinuxChangeTrackingPath',
        /// 'ChangeTrackingContentLocation', 'WindowsTelemetry', 'Office365',
        /// 'SecurityWindowsBaselineConfiguration',
        /// 'SecurityCenterSecurityWindowsBaselineConfiguration',
        /// 'SecurityEventCollectionConfiguration',
        /// 'SecurityInsightsSecurityEventCollectionConfiguration',
        /// 'ImportComputerGroup', 'NetworkMonitoring', 'Itsm', 'DnsAnalytics',
        /// 'ApplicationInsights', 'SqlDataClassification'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

    }
}
