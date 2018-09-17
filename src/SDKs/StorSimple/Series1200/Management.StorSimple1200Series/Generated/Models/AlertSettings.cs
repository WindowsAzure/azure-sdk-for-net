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
    /// AlertSettings on the device which represents how alerts will be
    /// processed
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AlertSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the AlertSettings class.
        /// </summary>
        public AlertSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertSettings class.
        /// </summary>
        /// <param name="emailNotification">Value indicating whether
        /// user/admins will receive emails when an alert condition occurs on
        /// the system. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="notificationToServiceOwners">Value indicating whether
        /// service owners will receive emails when an alert condition occurs
        /// on the system. Applicable only if emailNotification flag is
        /// Enabled. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="alertNotificationCulture">Culture setting to be used
        /// while building alert emails. For eg: "en-US"</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="additionalRecipientEmailList">List of email addresses
        /// (apart from admin/coadmin of subscription) to whom the alert emails
        /// need to be sent</param>
        public AlertSettings(AlertEmailNotificationStatus emailNotification, ServiceOwnersAlertNotificationStatus notificationToServiceOwners, string alertNotificationCulture, string id = default(string), string name = default(string), string type = default(string), IList<string> additionalRecipientEmailList = default(IList<string>))
            : base(id, name, type)
        {
            EmailNotification = emailNotification;
            NotificationToServiceOwners = notificationToServiceOwners;
            AlertNotificationCulture = alertNotificationCulture;
            AdditionalRecipientEmailList = additionalRecipientEmailList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value indicating whether user/admins will receive
        /// emails when an alert condition occurs on the system. Possible
        /// values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailNotification")]
        public AlertEmailNotificationStatus EmailNotification { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether service owners will receive
        /// emails when an alert condition occurs on the system. Applicable
        /// only if emailNotification flag is Enabled. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationToServiceOwners")]
        public ServiceOwnersAlertNotificationStatus NotificationToServiceOwners { get; set; }

        /// <summary>
        /// Gets or sets culture setting to be used while building alert
        /// emails. For eg: "en-US"
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertNotificationCulture")]
        public string AlertNotificationCulture { get; set; }

        /// <summary>
        /// Gets or sets list of email addresses (apart from admin/coadmin of
        /// subscription) to whom the alert emails need to be sent
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalRecipientEmailList")]
        public IList<string> AdditionalRecipientEmailList { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AlertNotificationCulture == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AlertNotificationCulture");
            }
        }
    }
}
