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
    using System.Linq;

    /// <summary>
    /// The file server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FileServer : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the FileServer class.
        /// </summary>
        public FileServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileServer class.
        /// </summary>
        /// <param name="domainName">Domain of the file server</param>
        /// <param name="storageDomainId">The storage domain id.</param>
        /// <param name="backupScheduleGroupId">The backup policy id.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="description">The description of the file
        /// server</param>
        public FileServer(string domainName, string storageDomainId, string backupScheduleGroupId, string id = default(string), string name = default(string), string type = default(string), string description = default(string))
            : base(id, name, type)
        {
            DomainName = domainName;
            StorageDomainId = storageDomainId;
            BackupScheduleGroupId = backupScheduleGroupId;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets domain of the file server
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the storage domain id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageDomainId")]
        public string StorageDomainId { get; set; }

        /// <summary>
        /// Gets or sets the backup policy id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupScheduleGroupId")]
        public string BackupScheduleGroupId { get; set; }

        /// <summary>
        /// Gets or sets the description of the file server
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DomainName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainName");
            }
            if (StorageDomainId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageDomainId");
            }
            if (BackupScheduleGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackupScheduleGroupId");
            }
        }
    }
}
