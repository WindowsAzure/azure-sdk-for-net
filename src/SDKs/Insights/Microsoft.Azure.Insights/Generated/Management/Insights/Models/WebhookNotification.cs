// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// Webhook notification of an autoscale event.
    /// </summary>
    public partial class WebhookNotification
    {
        /// <summary>
        /// Initializes a new instance of the WebhookNotification class.
        /// </summary>
        public WebhookNotification() { }

        /// <summary>
        /// Initializes a new instance of the WebhookNotification class.
        /// </summary>
        /// <param name="serviceUri">the service address to receive the
        /// notification.</param>
        /// <param name="properties">a property bag of settings. This value can
        /// be empty.</param>
        public WebhookNotification(string serviceUri = default(string), System.Collections.Generic.IDictionary<string, string> properties = default(System.Collections.Generic.IDictionary<string, string>))
        {
            ServiceUri = serviceUri;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the service address to receive the notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceUri")]
        public string ServiceUri { get; set; }

        /// <summary>
        /// Gets or sets a property bag of settings. This value can be empty.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

    }
}
