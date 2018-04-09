// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The page view information
    /// </summary>
    public partial class EventsPageViewInfo
    {
        /// <summary>
        /// Initializes a new instance of the EventsPageViewInfo class.
        /// </summary>
        public EventsPageViewInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsPageViewInfo class.
        /// </summary>
        /// <param name="name">The name of the page</param>
        /// <param name="url">The URL of the page</param>
        /// <param name="duration">The duration of the page view</param>
        /// <param name="performanceBucket">The performance bucket of the page
        /// view</param>
        public EventsPageViewInfo(string name = default(string), string url = default(string), string duration = default(string), string performanceBucket = default(string))
        {
            Name = name;
            Url = url;
            Duration = duration;
            PerformanceBucket = performanceBucket;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the page
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URL of the page
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the duration of the page view
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the performance bucket of the page view
        /// </summary>
        [JsonProperty(PropertyName = "performanceBucket")]
        public string PerformanceBucket { get; set; }

    }
}
