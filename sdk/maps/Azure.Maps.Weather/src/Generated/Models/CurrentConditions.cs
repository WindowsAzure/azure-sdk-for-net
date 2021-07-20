// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Weather.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CurrentConditions
    {
        /// <summary>
        /// Initializes a new instance of the CurrentConditions class.
        /// </summary>
        public CurrentConditions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CurrentConditions class.
        /// </summary>
        /// <param name="dateTime">Date and time of the current observation
        /// displayed in ISO 8601 format, for example,
        /// 2019-10-27T19:39:57-08:00.</param>
        /// <param name="phrase">Phrase description of the current weather
        /// condition.  Displayed in specified language.</param>
        /// <param name="iconCode">Numeric value representing an image that
        /// displays the `iconPhrase`. Please refer to [Weather Service
        /// Concepts](https://aka.ms/AzureMapsWeatherConcepts) for
        /// details.</param>
        /// <param name="hasPrecipitation">Indicates the presence or absence of
        /// precipitation. True indicates the presence of precipitation, false
        /// indicates the absence of precipitation.</param>
        /// <param name="isDayTime">Indicates the time of the day. True
        /// indicates 'day',', false indicates 'night.</param>
        /// <param name="temperature">Temperature being returned.</param>
        /// <param name="realFeelTemperature">RealFeel™ Temperature being
        /// returned.</param>
        /// <param name="realFeelTemperatureShade">RealFeel™ Temperature being
        /// returned. Describes what the temperature really feels like in the
        /// shade.</param>
        /// <param name="relativeHumidity">Relative humidity is the amount of
        /// water vapor present in air expressed as a percentage of the amount
        /// needed for saturation at the same temperature.</param>
        /// <param name="dewPoint">The dewpoint temperature in specified unit.
        /// The dewpoint temperature is the temperature that the air must be
        /// cooled to in order to reach saturation.</param>
        /// <param name="wind">Wind details being returned including speed and
        /// direction.</param>
        /// <param name="windGust">Wind gust. Wind gust is a sudden, brief
        /// increase in speed of the wind.</param>
        /// <param name="uvIndexPhrase">Phrase associated with the
        /// `uvIndex`.</param>
        /// <param name="visibility">Visibility in specified unit. A measure of
        /// the distance at which an object or light can be clearly
        /// discerned.</param>
        /// <param name="obstructionsToVisibility">Cause of limited
        /// visibility.</param>
        /// <param name="cloudCover">Percent representing cloud cover.</param>
        /// <param name="ceiling">Cloud ceiling in specified unit. The ceiling
        /// is a measurement of the height of the base of the lowest
        /// clouds.</param>
        /// <param name="pressure">Atmospheric pressure in specified
        /// unit.</param>
        /// <param name="pressureTendency">Atmospheric pressure change.</param>
        /// <param name="past24HourTemperatureDeparture">Departure from the
        /// temperature observed 24 hours ago in specified unit.</param>
        /// <param name="apparentTemperature">Perceived outdoor temperature
        /// caused by the combination of air temperature, relative humidity,
        /// and wind speed in specified unit.</param>
        /// <param name="windChillTemperature">Perceived air temperature on
        /// exposed skin due to wind.</param>
        /// <param name="wetBulbTemperature">The temperature to which air may
        /// be cooled by evaporating water into it at constant pressure until
        /// it reaches saturation.</param>
        /// <param name="precipitationSummary">Summary of precipitation amounts
        /// over the past 24 hours.</param>
        /// <param name="temperatureSummary">Summary of temperature
        /// fluctuations over the past 6, 12, and 24 hours.</param>
        public CurrentConditions(string dateTime = default(string), string phrase = default(string), int? iconCode = default(int?), bool? hasPrecipitation = default(bool?), bool? isDayTime = default(bool?), WeatherUnit temperature = default(WeatherUnit), WeatherUnit realFeelTemperature = default(WeatherUnit), WeatherUnit realFeelTemperatureShade = default(WeatherUnit), int? relativeHumidity = default(int?), WeatherUnit dewPoint = default(WeatherUnit), WindDetails wind = default(WindDetails), WindDetails windGust = default(WindDetails), int? uvIndex = default(int?), string uvIndexPhrase = default(string), WeatherUnit visibility = default(WeatherUnit), string obstructionsToVisibility = default(string), int? cloudCover = default(int?), WeatherUnit ceiling = default(WeatherUnit), WeatherUnit pressure = default(WeatherUnit), PressureTendency pressureTendency = default(PressureTendency), WeatherUnit past24HourTemperatureDeparture = default(WeatherUnit), WeatherUnit apparentTemperature = default(WeatherUnit), WeatherUnit windChillTemperature = default(WeatherUnit), WeatherUnit wetBulbTemperature = default(WeatherUnit), PrecipitationSummary precipitationSummary = default(PrecipitationSummary), TemperatureSummary temperatureSummary = default(TemperatureSummary))
        {
            DateTime = dateTime;
            Phrase = phrase;
            IconCode = iconCode;
            HasPrecipitation = hasPrecipitation;
            IsDayTime = isDayTime;
            Temperature = temperature;
            RealFeelTemperature = realFeelTemperature;
            RealFeelTemperatureShade = realFeelTemperatureShade;
            RelativeHumidity = relativeHumidity;
            DewPoint = dewPoint;
            Wind = wind;
            WindGust = windGust;
            UvIndex = uvIndex;
            UvIndexPhrase = uvIndexPhrase;
            Visibility = visibility;
            ObstructionsToVisibility = obstructionsToVisibility;
            CloudCover = cloudCover;
            Ceiling = ceiling;
            Pressure = pressure;
            PressureTendency = pressureTendency;
            Past24HourTemperatureDeparture = past24HourTemperatureDeparture;
            ApparentTemperature = apparentTemperature;
            WindChillTemperature = windChillTemperature;
            WetBulbTemperature = wetBulbTemperature;
            PrecipitationSummary = precipitationSummary;
            TemperatureSummary = temperatureSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time of the current observation displayed in
        /// ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets phrase description of the current weather condition.
        /// Displayed in specified language.
        /// </summary>
        [JsonProperty(PropertyName = "phrase")]
        public string Phrase { get; set; }

        /// <summary>
        /// Gets or sets numeric value representing an image that displays the
        /// `iconPhrase`. Please refer to [Weather Service
        /// Concepts](https://aka.ms/AzureMapsWeatherConcepts) for details.
        /// </summary>
        [JsonProperty(PropertyName = "iconCode")]
        public int? IconCode { get; set; }

        /// <summary>
        /// Gets or sets indicates the presence or absence of precipitation.
        /// True indicates the presence of precipitation, false indicates the
        /// absence of precipitation.
        /// </summary>
        [JsonProperty(PropertyName = "hasPrecipitation")]
        public bool? HasPrecipitation { get; set; }

        /// <summary>
        /// Gets or sets indicates the time of the day. True indicates 'day',',
        /// false indicates 'night.
        /// </summary>
        [JsonProperty(PropertyName = "isDayTime")]
        public bool? IsDayTime { get; set; }

        /// <summary>
        /// Gets or sets temperature being returned.
        /// </summary>
        [JsonProperty(PropertyName = "temperature")]
        public WeatherUnit Temperature { get; set; }

        /// <summary>
        /// Gets or sets realFeel™ Temperature being returned.
        /// </summary>
        [JsonProperty(PropertyName = "realFeelTemperature")]
        public WeatherUnit RealFeelTemperature { get; set; }

        /// <summary>
        /// Gets or sets realFeel™ Temperature being returned. Describes what
        /// the temperature really feels like in the shade.
        /// </summary>
        [JsonProperty(PropertyName = "realFeelTemperatureShade")]
        public WeatherUnit RealFeelTemperatureShade { get; set; }

        /// <summary>
        /// Gets or sets relative humidity is the amount of water vapor present
        /// in air expressed as a percentage of the amount needed for
        /// saturation at the same temperature.
        /// </summary>
        [JsonProperty(PropertyName = "relativeHumidity")]
        public int? RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or sets the dewpoint temperature in specified unit. The
        /// dewpoint temperature is the temperature that the air must be cooled
        /// to in order to reach saturation.
        /// </summary>
        [JsonProperty(PropertyName = "dewPoint")]
        public WeatherUnit DewPoint { get; set; }

        /// <summary>
        /// Gets or sets wind details being returned including speed and
        /// direction.
        /// </summary>
        [JsonProperty(PropertyName = "wind")]
        public WindDetails Wind { get; set; }

        /// <summary>
        /// Gets or sets wind gust. Wind gust is a sudden, brief increase in
        /// speed of the wind.
        /// </summary>
        [JsonProperty(PropertyName = "windGust")]
        public WindDetails WindGust { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uvIndex")]
        public int? UvIndex { get; set; }

        /// <summary>
        /// Gets or sets phrase associated with the `uvIndex`.
        /// </summary>
        [JsonProperty(PropertyName = "uvIndexPhrase")]
        public string UvIndexPhrase { get; set; }

        /// <summary>
        /// Gets or sets visibility in specified unit. A measure of the
        /// distance at which an object or light can be clearly discerned.
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public WeatherUnit Visibility { get; set; }

        /// <summary>
        /// Gets or sets cause of limited visibility.
        /// </summary>
        [JsonProperty(PropertyName = "obstructionsToVisibility")]
        public string ObstructionsToVisibility { get; set; }

        /// <summary>
        /// Gets or sets percent representing cloud cover.
        /// </summary>
        [JsonProperty(PropertyName = "cloudCover")]
        public int? CloudCover { get; set; }

        /// <summary>
        /// Gets or sets cloud ceiling in specified unit. The ceiling is a
        /// measurement of the height of the base of the lowest clouds.
        /// </summary>
        [JsonProperty(PropertyName = "ceiling")]
        public WeatherUnit Ceiling { get; set; }

        /// <summary>
        /// Gets or sets atmospheric pressure in specified unit.
        /// </summary>
        [JsonProperty(PropertyName = "pressure")]
        public WeatherUnit Pressure { get; set; }

        /// <summary>
        /// Gets or sets atmospheric pressure change.
        /// </summary>
        [JsonProperty(PropertyName = "pressureTendency")]
        public PressureTendency PressureTendency { get; set; }

        /// <summary>
        /// Gets or sets departure from the temperature observed 24 hours ago
        /// in specified unit.
        /// </summary>
        [JsonProperty(PropertyName = "past24HourTemperatureDeparture")]
        public WeatherUnit Past24HourTemperatureDeparture { get; set; }

        /// <summary>
        /// Gets or sets perceived outdoor temperature caused by the
        /// combination of air temperature, relative humidity, and wind speed
        /// in specified unit.
        /// </summary>
        [JsonProperty(PropertyName = "apparentTemperature")]
        public WeatherUnit ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets perceived air temperature on exposed skin due to wind.
        /// </summary>
        [JsonProperty(PropertyName = "windChillTemperature")]
        public WeatherUnit WindChillTemperature { get; set; }

        /// <summary>
        /// Gets or sets the temperature to which air may be cooled by
        /// evaporating water into it at constant pressure until it reaches
        /// saturation.
        /// </summary>
        [JsonProperty(PropertyName = "wetBulbTemperature")]
        public WeatherUnit WetBulbTemperature { get; set; }

        /// <summary>
        /// Gets or sets summary of precipitation amounts over the past 24
        /// hours.
        /// </summary>
        [JsonProperty(PropertyName = "precipitationSummary")]
        public PrecipitationSummary PrecipitationSummary { get; set; }

        /// <summary>
        /// Gets or sets summary of temperature fluctuations over the past 6,
        /// 12, and 24 hours.
        /// </summary>
        [JsonProperty(PropertyName = "temperatureSummary")]
        public TemperatureSummary TemperatureSummary { get; set; }

    }
}
