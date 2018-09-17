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
    /// The TimeSettings of a device
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TimeSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the TimeSettings class.
        /// </summary>
        public TimeSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSettings class.
        /// </summary>
        /// <param name="timeZone">The timezone of device, like '(UTC -06:00)
        /// Central America'</param>
        /// <param name="primaryTimeServer">The primary Network Time Protocol
        /// (NTP) server name, like 'time.windows.com'.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="secondaryTimeServer">The secondary Network Time
        /// Protocol (NTP) server name, like 'time.contoso.com'. It's
        /// optional.</param>
        public TimeSettings(string timeZone, string primaryTimeServer, string id = default(string), string name = default(string), string type = default(string), string secondaryTimeServer = default(string))
            : base(id, name, type)
        {
            TimeZone = timeZone;
            PrimaryTimeServer = primaryTimeServer;
            SecondaryTimeServer = secondaryTimeServer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timezone of device, like '(UTC -06:00) Central
        /// America'
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the primary Network Time Protocol (NTP) server name,
        /// like 'time.windows.com'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryTimeServer")]
        public string PrimaryTimeServer { get; set; }

        /// <summary>
        /// Gets or sets the secondary Network Time Protocol (NTP) server name,
        /// like 'time.contoso.com'. It's optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryTimeServer")]
        public string SecondaryTimeServer { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeZone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeZone");
            }
            if (PrimaryTimeServer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrimaryTimeServer");
            }
        }
    }
}
