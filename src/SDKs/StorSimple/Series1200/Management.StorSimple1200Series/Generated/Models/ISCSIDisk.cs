// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The iscsi disk.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ISCSIDisk : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the ISCSIDisk class.
        /// </summary>
        public ISCSIDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ISCSIDisk class.
        /// </summary>
        /// <param name="diskStatus">The disk status. Possible values include:
        /// 'Online', 'Offline'</param>
        /// <param name="accessControlRecordsProperty">The access control
        /// records.</param>
        /// <param name="dataPolicy">The data policy. Possible values include:
        /// 'Invalid', 'Local', 'Tiered', 'Cloud'</param>
        /// <param name="provisionedCapacityInBytes">The provisioned capacity
        /// in bytes.</param>
        /// <param name="monitoringStatus">The monitoring. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="description">The description.</param>
        /// <param name="usedCapacityInBytes">The used capacity in
        /// bytes.</param>
        /// <param name="localUsedCapacityInBytes">The local used capacity in
        /// bytes.</param>
        public ISCSIDisk(DiskStatus diskStatus, IList<string> accessControlRecordsProperty, DataPolicy dataPolicy, long provisionedCapacityInBytes, MonitoringStatus monitoringStatus, string id = default(string), string name = default(string), string type = default(string), string description = default(string), long? usedCapacityInBytes = default(long?), long? localUsedCapacityInBytes = default(long?))
            : base(id, name, type)
        {
            Description = description;
            DiskStatus = diskStatus;
            AccessControlRecordsProperty = accessControlRecordsProperty;
            DataPolicy = dataPolicy;
            ProvisionedCapacityInBytes = provisionedCapacityInBytes;
            UsedCapacityInBytes = usedCapacityInBytes;
            LocalUsedCapacityInBytes = localUsedCapacityInBytes;
            MonitoringStatus = monitoringStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the disk status. Possible values include: 'Online',
        /// 'Offline'
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskStatus")]
        public DiskStatus DiskStatus { get; set; }

        /// <summary>
        /// Gets or sets the access control records.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessControlRecords")]
        public IList<string> AccessControlRecordsProperty { get; set; }

        /// <summary>
        /// Gets or sets the data policy. Possible values include: 'Invalid',
        /// 'Local', 'Tiered', 'Cloud'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataPolicy")]
        public DataPolicy DataPolicy { get; set; }

        /// <summary>
        /// Gets or sets the provisioned capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisionedCapacityInBytes")]
        public long ProvisionedCapacityInBytes { get; set; }

        /// <summary>
        /// Gets the used capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usedCapacityInBytes")]
        public long? UsedCapacityInBytes { get; private set; }

        /// <summary>
        /// Gets the local used capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localUsedCapacityInBytes")]
        public long? LocalUsedCapacityInBytes { get; private set; }

        /// <summary>
        /// Gets or sets the monitoring. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitoringStatus")]
        public MonitoringStatus MonitoringStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccessControlRecordsProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessControlRecordsProperty");
            }
        }
    }
}
