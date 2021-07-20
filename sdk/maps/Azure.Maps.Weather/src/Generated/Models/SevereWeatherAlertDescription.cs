// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> Description of a severe weather alert. </summary>
    public partial class SevereWeatherAlertDescription
    {
        /// <summary> Initializes a new instance of SevereWeatherAlertDescription. </summary>
        internal SevereWeatherAlertDescription()
        {
        }

        /// <summary> Initializes a new instance of SevereWeatherAlertDescription. </summary>
        /// <param name="localized"> Description of the alert in the specified language. By default English (en-US) is returned if the language parameter is not specified in the request. </param>
        /// <param name="english"> Description of the alert in English (en-US). </param>
        internal SevereWeatherAlertDescription(string localized, string english)
        {
            Localized = localized;
            English = english;
        }

        /// <summary> Description of the alert in the specified language. By default English (en-US) is returned if the language parameter is not specified in the request. </summary>
        public string Localized { get; }
        /// <summary> Description of the alert in English (en-US). </summary>
        public string English { get; }
    }
}
