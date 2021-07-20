// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Weather.Models
{
    /// <summary> The DailyForecast. </summary>
    public partial class DailyForecast
    {
        /// <summary> Initializes a new instance of DailyForecast. </summary>
        internal DailyForecast()
        {
            AirAndPollen = new ChangeTrackingList<AirAndPollen>();
            Sources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DailyForecast. </summary>
        /// <param name="date"> Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </param>
        /// <param name="temperature"> Temperature values for the day. </param>
        /// <param name="realFeelTemperature"> RealFeel™ Temperature being returned. </param>
        /// <param name="realFeelTemperatureShade"> RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade. </param>
        /// <param name="hoursOfSun"> Hours of sun. </param>
        /// <param name="degreeDaySummary"> Summary of Heating Degree Day or Cooling Degree Day information. </param>
        /// <param name="airAndPollen"> airAndPollen. </param>
        /// <param name="day"> Day. </param>
        /// <param name="night"> Night. </param>
        /// <param name="sources"> Source(s) of the forecast data. </param>
        internal DailyForecast(string date, WeatherUnitRange temperature, WeatherUnitRange realFeelTemperature, WeatherUnitRange realFeelTemperatureShade, float? hoursOfSun, DegreeDaySummary degreeDaySummary, IReadOnlyList<AirAndPollen> airAndPollen, DayOrNight day, DayOrNight night, IReadOnlyList<string> sources)
        {
            Date = date;
            Temperature = temperature;
            RealFeelTemperature = realFeelTemperature;
            RealFeelTemperatureShade = realFeelTemperatureShade;
            HoursOfSun = hoursOfSun;
            DegreeDaySummary = degreeDaySummary;
            AirAndPollen = airAndPollen;
            Day = day;
            Night = night;
            Sources = sources;
        }

        /// <summary> Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </summary>
        public string Date { get; }
        /// <summary> Temperature values for the day. </summary>
        public WeatherUnitRange Temperature { get; }
        /// <summary> RealFeel™ Temperature being returned. </summary>
        public WeatherUnitRange RealFeelTemperature { get; }
        /// <summary> RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade. </summary>
        public WeatherUnitRange RealFeelTemperatureShade { get; }
        /// <summary> Hours of sun. </summary>
        public float? HoursOfSun { get; }
        /// <summary> Summary of Heating Degree Day or Cooling Degree Day information. </summary>
        public DegreeDaySummary DegreeDaySummary { get; }
        /// <summary> airAndPollen. </summary>
        public IReadOnlyList<AirAndPollen> AirAndPollen { get; }
        /// <summary> Day. </summary>
        public DayOrNight Day { get; }
        /// <summary> Night. </summary>
        public DayOrNight Night { get; }
        /// <summary> Source(s) of the forecast data. </summary>
        public IReadOnlyList<string> Sources { get; }
    }
}
