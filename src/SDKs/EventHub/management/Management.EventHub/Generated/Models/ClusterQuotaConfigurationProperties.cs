// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains all settings for the cluster.
    /// </summary>
    public partial class ClusterQuotaConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ClusterQuotaConfigurationProperties class.
        /// </summary>
        public ClusterQuotaConfigurationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ClusterQuotaConfigurationProperties class.
        /// </summary>
        /// <param name="settings">All possible Cluster settings - a collection
        /// of key/value paired settings which apply to quotas and
        /// configurations imposed on the cluster.</param>
        public ClusterQuotaConfigurationProperties(IDictionary<string, string> settings = default(IDictionary<string, string>))
        {
            Settings = settings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets all possible Cluster settings - a collection of
        /// key/value paired settings which apply to quotas and configurations
        /// imposed on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public IDictionary<string, string> Settings { get; set; }

    }
}
