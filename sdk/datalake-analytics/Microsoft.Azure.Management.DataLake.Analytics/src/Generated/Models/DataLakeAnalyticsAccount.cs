// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics account object, containing all information
    /// associated with the named Data Lake Analytics account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataLakeAnalyticsAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        public DataLakeAnalyticsAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        /// <param name="id">The resource identifer.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="accountId">The unique identifier associated with this
        /// Data Lake Analytics account.</param>
        /// <param name="provisioningState">The provisioning status of the Data
        /// Lake Analytics account. Possible values include: 'Failed',
        /// 'Creating', 'Running', 'Succeeded', 'Patching', 'Suspending',
        /// 'Resuming', 'Deleting', 'Deleted', 'Undeleting', 'Canceled'</param>
        /// <param name="state">The state of the Data Lake Analytics account.
        /// Possible values include: 'Active', 'Suspended'</param>
        /// <param name="creationTime">The account creation time.</param>
        /// <param name="lastModifiedTime">The account last modified
        /// time.</param>
        /// <param name="endpoint">The full CName endpoint for this
        /// account.</param>
        /// <param name="defaultDataLakeStoreAccount">The default Data Lake
        /// Store account associated with this account.</param>
        /// <param name="dataLakeStoreAccounts">The list of Data Lake Store
        /// accounts associated with this account.</param>
        /// <param name="storageAccounts">The list of Azure Blob Storage
        /// accounts associated with this account.</param>
        /// <param name="computePolicies">The list of compute policies
        /// associated with this account.</param>
        /// <param name="hiveMetastores">The list of hiveMetastores associated
        /// with this account.</param>
        /// <param name="virtualNetworkRules">The list of virtualNetwork rules
        /// associated with this account.</param>
        /// <param name="firewallRules">The list of firewall rules associated
        /// with this account.</param>
        /// <param name="firewallState">The current state of the IP address
        /// firewall for this account. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="firewallAllowAzureIps">The current state of allowing
        /// or disallowing IPs originating within Azure through the firewall.
        /// If the firewall is disabled, this is not enforced. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="newTier">The commitment tier for the next month.
        /// Possible values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'</param>
        /// <param name="currentTier">The commitment tier in use for the
        /// current month. Possible values include: 'Consumption',
        /// 'Commitment_100AUHours', 'Commitment_500AUHours',
        /// 'Commitment_1000AUHours', 'Commitment_5000AUHours',
        /// 'Commitment_10000AUHours', 'Commitment_50000AUHours',
        /// 'Commitment_100000AUHours', 'Commitment_500000AUHours'</param>
        /// <param name="maxJobCount">The maximum supported jobs running under
        /// the account at the same time.</param>
        /// <param name="systemMaxJobCount">The system defined maximum
        /// supported jobs running under the account at the same time, which
        /// restricts the maximum number of running jobs the user can set for
        /// the account.</param>
        /// <param name="maxDegreeOfParallelism">The maximum supported degree
        /// of parallelism for this account.</param>
        /// <param name="systemMaxDegreeOfParallelism">The system defined
        /// maximum supported degree of parallelism for this account, which
        /// restricts the maximum value of parallelism the user can set for the
        /// account.</param>
        /// <param name="maxDegreeOfParallelismPerJob">The maximum supported
        /// degree of parallelism per job for this account.</param>
        /// <param name="minPriorityPerJob">The minimum supported priority per
        /// job for this account.</param>
        /// <param name="queryStoreRetention">The number of days that job
        /// metadata is retained.</param>
        /// <param name="debugDataAccessLevel">The current state of the
        /// DebugDataAccessLevel for this account. Possible values include:
        /// 'All', 'Customer', 'None'</param>
        public DataLakeAnalyticsAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.Guid? accountId = default(System.Guid?), DataLakeAnalyticsAccountStatus? provisioningState = default(DataLakeAnalyticsAccountStatus?), DataLakeAnalyticsAccountState? state = default(DataLakeAnalyticsAccountState?), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string endpoint = default(string), string defaultDataLakeStoreAccount = default(string), IList<DataLakeStoreAccountInformation> dataLakeStoreAccounts = default(IList<DataLakeStoreAccountInformation>), IList<StorageAccountInformation> storageAccounts = default(IList<StorageAccountInformation>), IList<ComputePolicy> computePolicies = default(IList<ComputePolicy>), IList<HiveMetastore> hiveMetastores = default(IList<HiveMetastore>), IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>), IList<FirewallRule> firewallRules = default(IList<FirewallRule>), FirewallState? firewallState = default(FirewallState?), FirewallAllowAzureIpsState? firewallAllowAzureIps = default(FirewallAllowAzureIpsState?), TierType? newTier = default(TierType?), TierType? currentTier = default(TierType?), int? maxJobCount = default(int?), int? systemMaxJobCount = default(int?), int? maxDegreeOfParallelism = default(int?), int? systemMaxDegreeOfParallelism = default(int?), int? maxDegreeOfParallelismPerJob = default(int?), int? minPriorityPerJob = default(int?), int? queryStoreRetention = default(int?), DebugDataAccessLevel? debugDataAccessLevel = default(DebugDataAccessLevel?))
            : base(id, name, type, location, tags)
        {
            AccountId = accountId;
            ProvisioningState = provisioningState;
            State = state;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            ComputePolicies = computePolicies;
            HiveMetastores = hiveMetastores;
            VirtualNetworkRules = virtualNetworkRules;
            FirewallRules = firewallRules;
            FirewallState = firewallState;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            NewTier = newTier;
            CurrentTier = currentTier;
            MaxJobCount = maxJobCount;
            SystemMaxJobCount = systemMaxJobCount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            SystemMaxDegreeOfParallelism = systemMaxDegreeOfParallelism;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            QueryStoreRetention = queryStoreRetention;
            DebugDataAccessLevel = debugDataAccessLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the unique identifier associated with this Data Lake Analytics
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountId")]
        public System.Guid? AccountId { get; private set; }

        /// <summary>
        /// Gets the provisioning status of the Data Lake Analytics account.
        /// Possible values include: 'Failed', 'Creating', 'Running',
        /// 'Succeeded', 'Patching', 'Suspending', 'Resuming', 'Deleting',
        /// 'Deleted', 'Undeleting', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public DataLakeAnalyticsAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the Data Lake Analytics account. Possible values
        /// include: 'Active', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public DataLakeAnalyticsAccountState? State { get; private set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the full CName endpoint for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets the default Data Lake Store account associated with this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDataLakeStoreAccount")]
        public string DefaultDataLakeStoreAccount { get; private set; }

        /// <summary>
        /// Gets the list of Data Lake Store accounts associated with this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataLakeStoreAccounts")]
        public IList<DataLakeStoreAccountInformation> DataLakeStoreAccounts { get; private set; }

        /// <summary>
        /// Gets the list of Azure Blob Storage accounts associated with this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccountInformation> StorageAccounts { get; private set; }

        /// <summary>
        /// Gets the list of compute policies associated with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computePolicies")]
        public IList<ComputePolicy> ComputePolicies { get; private set; }

        /// <summary>
        /// Gets the list of hiveMetastores associated with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hiveMetastores")]
        public IList<HiveMetastore> HiveMetastores { get; private set; }

        /// <summary>
        /// Gets the list of virtualNetwork rules associated with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; private set; }

        /// <summary>
        /// Gets the list of firewall rules associated with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<FirewallRule> FirewallRules { get; private set; }

        /// <summary>
        /// Gets the current state of the IP address firewall for this account.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallState")]
        public FirewallState? FirewallState { get; private set; }

        /// <summary>
        /// Gets the current state of allowing or disallowing IPs originating
        /// within Azure through the firewall. If the firewall is disabled,
        /// this is not enforced. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallAllowAzureIps")]
        public FirewallAllowAzureIpsState? FirewallAllowAzureIps { get; private set; }

        /// <summary>
        /// Gets the commitment tier for the next month. Possible values
        /// include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'
        /// </summary>
        [JsonProperty(PropertyName = "properties.newTier")]
        public TierType? NewTier { get; private set; }

        /// <summary>
        /// Gets the commitment tier in use for the current month. Possible
        /// values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentTier")]
        public TierType? CurrentTier { get; private set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets the system defined maximum supported jobs running under the
        /// account at the same time, which restricts the maximum number of
        /// running jobs the user can set for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemMaxJobCount")]
        public int? SystemMaxJobCount { get; private set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets the system defined maximum supported degree of parallelism for
        /// this account, which restricts the maximum value of parallelism the
        /// user can set for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemMaxDegreeOfParallelism")]
        public int? SystemMaxDegreeOfParallelism { get; private set; }

        /// <summary>
        /// Gets the maximum supported degree of parallelism per job for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelismPerJob")]
        public int? MaxDegreeOfParallelismPerJob { get; private set; }

        /// <summary>
        /// Gets the minimum supported priority per job for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minPriorityPerJob")]
        public int? MinPriorityPerJob { get; private set; }

        /// <summary>
        /// Gets or sets the number of days that job metadata is retained.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStoreRetention")]
        public int? QueryStoreRetention { get; set; }

        /// <summary>
        /// Gets the current state of the DebugDataAccessLevel for this
        /// account. Possible values include: 'All', 'Customer', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.debugDataAccessLevel")]
        public DebugDataAccessLevel? DebugDataAccessLevel { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ComputePolicies != null)
            {
                foreach (var element in ComputePolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (MaxJobCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxJobCount", 1);
            }
            if (MaxDegreeOfParallelism < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelism", 1);
            }
            if (MaxDegreeOfParallelismPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelismPerJob", 1);
            }
            if (MinPriorityPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinPriorityPerJob", 1);
            }
            if (QueryStoreRetention > 180)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "QueryStoreRetention", 180);
            }
            if (QueryStoreRetention < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "QueryStoreRetention", 1);
            }
        }
    }
}
