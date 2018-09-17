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
    /// Represents a StorSimple device object along with its properties
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Device : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the Device class.
        /// </summary>
        public Device()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Device class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="activationTime">The UTC time at which the device was
        /// activated</param>
        /// <param name="allowedDeviceOperations">Operations that are allowed
        /// on the device based on its current state</param>
        /// <param name="culture">Language culture setting on the device. For
        /// eg: "en-US"</param>
        /// <param name="deviceCapabilities">Device can be configured either as
        /// FileServer or IscsiServer</param>
        /// <param name="deviceDescription">Short description given for the
        /// device</param>
        /// <param name="domainName">Fully qualified name of the domain to
        /// which the device is attached</param>
        /// <param name="deviceSoftwareVersion">Version number of the software
        /// running on the device</param>
        /// <param name="friendlySoftwareName">Friendly name for the software
        /// version</param>
        /// <param name="deviceConfigurationStatus">"Complete" if the device
        /// has been successfully registered as File/IscsiServer and the
        /// creation of share/volume is complete, "Pending" if the device is
        /// only registered but the creation of share/volume is complete is
        /// still pending. Possible values include: 'Complete',
        /// 'Pending'</param>
        /// <param name="modelDescription">Name of the device model</param>
        /// <param name="status">Current status of the device. Possible values
        /// include: 'Unknown', 'Online', 'Offline', 'RequiresAttention',
        /// 'MaintenanceMode', 'Creating', 'Provisioning', 'Deleted',
        /// 'ReadyToSetup', 'Deactivated', 'Deactivating'</param>
        /// <param name="deviceType">Type of the device. Possible values
        /// include: 'Invalid', 'Appliance', 'VirtualAppliance',
        /// 'Series9000OnPremVirtualAppliance', 'Series9000VirtualAppliance',
        /// 'Series9000PhysicalAppliance'</param>
        /// <param name="details">subclass containing more storage-related
        /// information about the device. This field will be populated only if
        /// the get call is made with $expand = details.</param>
        public Device(string id = default(string), string name = default(string), string type = default(string), System.DateTime? activationTime = default(System.DateTime?), IList<DeviceOperation?> allowedDeviceOperations = default(IList<DeviceOperation?>), string culture = default(string), IList<SupportedDeviceCapabilities?> deviceCapabilities = default(IList<SupportedDeviceCapabilities?>), string deviceDescription = default(string), string domainName = default(string), string deviceSoftwareVersion = default(string), string friendlySoftwareName = default(string), DeviceConfigurationStatus? deviceConfigurationStatus = default(DeviceConfigurationStatus?), string modelDescription = default(string), DeviceStatus? status = default(DeviceStatus?), DeviceType? deviceType = default(DeviceType?), DeviceDetails details = default(DeviceDetails))
            : base(id, name, type)
        {
            ActivationTime = activationTime;
            AllowedDeviceOperations = allowedDeviceOperations;
            Culture = culture;
            DeviceCapabilities = deviceCapabilities;
            DeviceDescription = deviceDescription;
            DomainName = domainName;
            DeviceSoftwareVersion = deviceSoftwareVersion;
            FriendlySoftwareName = friendlySoftwareName;
            DeviceConfigurationStatus = deviceConfigurationStatus;
            ModelDescription = modelDescription;
            Status = status;
            DeviceType = deviceType;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the UTC time at which the device was activated
        /// </summary>
        [JsonProperty(PropertyName = "properties.activationTime")]
        public System.DateTime? ActivationTime { get; set; }

        /// <summary>
        /// Gets or sets operations that are allowed on the device based on its
        /// current state
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedDeviceOperations")]
        public IList<DeviceOperation?> AllowedDeviceOperations { get; set; }

        /// <summary>
        /// Gets or sets language culture setting on the device. For eg:
        /// "en-US"
        /// </summary>
        [JsonProperty(PropertyName = "properties.culture")]
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets device can be configured either as FileServer or
        /// IscsiServer
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceCapabilities")]
        public IList<SupportedDeviceCapabilities?> DeviceCapabilities { get; set; }

        /// <summary>
        /// Gets or sets short description given for the device
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceDescription")]
        public string DeviceDescription { get; set; }

        /// <summary>
        /// Gets or sets fully qualified name of the domain to which the device
        /// is attached
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets version number of the software running on the device
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceSoftwareVersion")]
        public string DeviceSoftwareVersion { get; set; }

        /// <summary>
        /// Gets or sets friendly name for the software version
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlySoftwareName")]
        public string FriendlySoftwareName { get; set; }

        /// <summary>
        /// Gets or sets "Complete" if the device has been successfully
        /// registered as File/IscsiServer and the creation of share/volume is
        /// complete, "Pending" if the device is only registered but the
        /// creation of share/volume is complete is still pending. Possible
        /// values include: 'Complete', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceConfigurationStatus")]
        public DeviceConfigurationStatus? DeviceConfigurationStatus { get; set; }

        /// <summary>
        /// Gets or sets name of the device model
        /// </summary>
        [JsonProperty(PropertyName = "properties.modelDescription")]
        public string ModelDescription { get; set; }

        /// <summary>
        /// Gets or sets current status of the device. Possible values include:
        /// 'Unknown', 'Online', 'Offline', 'RequiresAttention',
        /// 'MaintenanceMode', 'Creating', 'Provisioning', 'Deleted',
        /// 'ReadyToSetup', 'Deactivated', 'Deactivating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public DeviceStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets type of the device. Possible values include:
        /// 'Invalid', 'Appliance', 'VirtualAppliance',
        /// 'Series9000OnPremVirtualAppliance', 'Series9000VirtualAppliance',
        /// 'Series9000PhysicalAppliance'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public DeviceType? DeviceType { get; set; }

        /// <summary>
        /// Gets or sets subclass containing more storage-related information
        /// about the device. This field will be populated only if the get call
        /// is made with $expand = details.
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public DeviceDetails Details { get; set; }

    }
}
