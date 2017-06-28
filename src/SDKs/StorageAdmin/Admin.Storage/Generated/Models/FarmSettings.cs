// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.AzureStack.Storage.Admin;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FarmSettings
    {
        /// <summary>
        /// Initializes a new instance of the FarmSettings class.
        /// </summary>
        public FarmSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FarmSettings class.
        /// </summary>
        public FarmSettings(int? settingsPollingIntervalInSecond = default(int?), int? retentionPeriodForDeletedStorageAccountsInDays = default(int?), int? hostStyleHttpPort = default(int?), int? hostStyleHttpsPort = default(int?), string corsAllowedOriginsList = default(string), string dataCenterUriHostSuffixes = default(string), bool? bandwidthThrottleIsEnabled = default(bool?), int? usageCollectionIntervalInSeconds = default(int?), int? feedbackRefreshIntervalInSeconds = default(int?), int? numberOfAccountsToSync = default(int?), int? defaultThrottleProbabilityDecayIntervalInSeconds = default(int?), int? gracePeriodForFullThrottlingInRefreshIntervals = default(int?), double? gracePeriodMaxThrottleProbability = default(double?), double? overallRequestThresholdInTps = default(double?), double? defaultRequestThresholdInTps = default(double?), double? minimumRequestThresholdInTps = default(double?), double? toleranceFactorForTps = default(double?), double? overallIngressThresholdInGbps = default(double?), double? defaultIngressThresholdInGbps = default(double?), double? minimumIngressThresholdInGbps = default(double?), double? toleranceFactorForIngress = default(double?), double? overallIntranetIngressThresholdInGbps = default(double?), double? defaultIntranetIngressThresholdInGbps = default(double?), double? minimumIntranetIngressThresholdInGbps = default(double?), double? toleranceFactorForIntranetIngress = default(double?), double? overallEgressThresholdInGbps = default(double?), double? defaultEgressThresholdInGbps = default(double?), double? minimumEgressThresholdInGbps = default(double?), double? toleranceFactorForEgress = default(double?), double? overallIntranetEgressThresholdInGbps = default(double?), double? defaultIntranetEgressThresholdInGbps = default(double?), double? minimumIntranetEgressThresholdInGbps = default(double?), double? toleranceFactorForIntranetEgress = default(double?), double? overallTotalIngressThresholdInGbps = default(double?), double? defaultTotalIngressThresholdInGbps = default(double?), double? minimumTotalIngressThresholdInGbps = default(double?), double? toleranceFactorForTotalIngress = default(double?), double? overallTotalEgressThresholdInGbps = default(double?), double? defaultTotalEgressThresholdInGbps = default(double?), double? minimumTotalEgressThresholdInGbps = default(double?), double? toleranceFactorForTotalEgress = default(double?))
        {
            SettingsPollingIntervalInSecond = settingsPollingIntervalInSecond;
            RetentionPeriodForDeletedStorageAccountsInDays = retentionPeriodForDeletedStorageAccountsInDays;
            HostStyleHttpPort = hostStyleHttpPort;
            HostStyleHttpsPort = hostStyleHttpsPort;
            CorsAllowedOriginsList = corsAllowedOriginsList;
            DataCenterUriHostSuffixes = dataCenterUriHostSuffixes;
            BandwidthThrottleIsEnabled = bandwidthThrottleIsEnabled;
            UsageCollectionIntervalInSeconds = usageCollectionIntervalInSeconds;
            FeedbackRefreshIntervalInSeconds = feedbackRefreshIntervalInSeconds;
            NumberOfAccountsToSync = numberOfAccountsToSync;
            DefaultThrottleProbabilityDecayIntervalInSeconds = defaultThrottleProbabilityDecayIntervalInSeconds;
            GracePeriodForFullThrottlingInRefreshIntervals = gracePeriodForFullThrottlingInRefreshIntervals;
            GracePeriodMaxThrottleProbability = gracePeriodMaxThrottleProbability;
            OverallRequestThresholdInTps = overallRequestThresholdInTps;
            DefaultRequestThresholdInTps = defaultRequestThresholdInTps;
            MinimumRequestThresholdInTps = minimumRequestThresholdInTps;
            ToleranceFactorForTps = toleranceFactorForTps;
            OverallIngressThresholdInGbps = overallIngressThresholdInGbps;
            DefaultIngressThresholdInGbps = defaultIngressThresholdInGbps;
            MinimumIngressThresholdInGbps = minimumIngressThresholdInGbps;
            ToleranceFactorForIngress = toleranceFactorForIngress;
            OverallIntranetIngressThresholdInGbps = overallIntranetIngressThresholdInGbps;
            DefaultIntranetIngressThresholdInGbps = defaultIntranetIngressThresholdInGbps;
            MinimumIntranetIngressThresholdInGbps = minimumIntranetIngressThresholdInGbps;
            ToleranceFactorForIntranetIngress = toleranceFactorForIntranetIngress;
            OverallEgressThresholdInGbps = overallEgressThresholdInGbps;
            DefaultEgressThresholdInGbps = defaultEgressThresholdInGbps;
            MinimumEgressThresholdInGbps = minimumEgressThresholdInGbps;
            ToleranceFactorForEgress = toleranceFactorForEgress;
            OverallIntranetEgressThresholdInGbps = overallIntranetEgressThresholdInGbps;
            DefaultIntranetEgressThresholdInGbps = defaultIntranetEgressThresholdInGbps;
            MinimumIntranetEgressThresholdInGbps = minimumIntranetEgressThresholdInGbps;
            ToleranceFactorForIntranetEgress = toleranceFactorForIntranetEgress;
            OverallTotalIngressThresholdInGbps = overallTotalIngressThresholdInGbps;
            DefaultTotalIngressThresholdInGbps = defaultTotalIngressThresholdInGbps;
            MinimumTotalIngressThresholdInGbps = minimumTotalIngressThresholdInGbps;
            ToleranceFactorForTotalIngress = toleranceFactorForTotalIngress;
            OverallTotalEgressThresholdInGbps = overallTotalEgressThresholdInGbps;
            DefaultTotalEgressThresholdInGbps = defaultTotalEgressThresholdInGbps;
            MinimumTotalEgressThresholdInGbps = minimumTotalEgressThresholdInGbps;
            ToleranceFactorForTotalEgress = toleranceFactorForTotalEgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settingsPollingIntervalInSecond")]
        public int? SettingsPollingIntervalInSecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retentionPeriodForDeletedStorageAccountsInDays")]
        public int? RetentionPeriodForDeletedStorageAccountsInDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostStyleHttpPort")]
        public int? HostStyleHttpPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostStyleHttpsPort")]
        public int? HostStyleHttpsPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "corsAllowedOriginsList")]
        public string CorsAllowedOriginsList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataCenterUriHostSuffixes")]
        public string DataCenterUriHostSuffixes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bandwidthThrottleIsEnabled")]
        public bool? BandwidthThrottleIsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usageCollectionIntervalInSeconds")]
        public int? UsageCollectionIntervalInSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedbackRefreshIntervalInSeconds")]
        public int? FeedbackRefreshIntervalInSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberOfAccountsToSync")]
        public int? NumberOfAccountsToSync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultThrottleProbabilityDecayIntervalInSeconds")]
        public int? DefaultThrottleProbabilityDecayIntervalInSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriodForFullThrottlingInRefreshIntervals")]
        public int? GracePeriodForFullThrottlingInRefreshIntervals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriodMaxThrottleProbability")]
        public double? GracePeriodMaxThrottleProbability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallRequestThresholdInTps")]
        public double? OverallRequestThresholdInTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultRequestThresholdInTps")]
        public double? DefaultRequestThresholdInTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumRequestThresholdInTps")]
        public double? MinimumRequestThresholdInTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForTps")]
        public double? ToleranceFactorForTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallIngressThresholdInGbps")]
        public double? OverallIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultIngressThresholdInGbps")]
        public double? DefaultIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumIngressThresholdInGbps")]
        public double? MinimumIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForIngress")]
        public double? ToleranceFactorForIngress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallIntranetIngressThresholdInGbps")]
        public double? OverallIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultIntranetIngressThresholdInGbps")]
        public double? DefaultIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumIntranetIngressThresholdInGbps")]
        public double? MinimumIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForIntranetIngress")]
        public double? ToleranceFactorForIntranetIngress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallEgressThresholdInGbps")]
        public double? OverallEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultEgressThresholdInGbps")]
        public double? DefaultEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumEgressThresholdInGbps")]
        public double? MinimumEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForEgress")]
        public double? ToleranceFactorForEgress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallIntranetEgressThresholdInGbps")]
        public double? OverallIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultIntranetEgressThresholdInGbps")]
        public double? DefaultIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumIntranetEgressThresholdInGbps")]
        public double? MinimumIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForIntranetEgress")]
        public double? ToleranceFactorForIntranetEgress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallTotalIngressThresholdInGbps")]
        public double? OverallTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultTotalIngressThresholdInGbps")]
        public double? DefaultTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumTotalIngressThresholdInGbps")]
        public double? MinimumTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForTotalIngress")]
        public double? ToleranceFactorForTotalIngress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overallTotalEgressThresholdInGbps")]
        public double? OverallTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultTotalEgressThresholdInGbps")]
        public double? DefaultTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumTotalEgressThresholdInGbps")]
        public double? MinimumTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toleranceFactorForTotalEgress")]
        public double? ToleranceFactorForTotalEgress { get; set; }

    }
}
