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
    /// Class represents BackupElement
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupElement : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the BackupElement class.
        /// </summary>
        public BackupElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupElement class.
        /// </summary>
        /// <param name="sizeInBytes">The size in bytes.</param>
        /// <param name="endpointName">The name of the endpoint.</param>
        /// <param name="dataPolicy">The data policy of backed up endpoint.
        /// Possible values include: 'Invalid', 'Local', 'Tiered',
        /// 'Cloud'</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public BackupElement(long sizeInBytes, string endpointName, DataPolicy dataPolicy, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            SizeInBytes = sizeInBytes;
            EndpointName = endpointName;
            DataPolicy = dataPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeInBytes")]
        public long SizeInBytes { get; set; }

        /// <summary>
        /// Gets or sets the name of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointName")]
        public string EndpointName { get; set; }

        /// <summary>
        /// Gets or sets the data policy of backed up endpoint. Possible values
        /// include: 'Invalid', 'Local', 'Tiered', 'Cloud'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataPolicy")]
        public DataPolicy DataPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EndpointName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndpointName");
            }
        }
    }
}
