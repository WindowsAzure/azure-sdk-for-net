// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> Returned temperature values. </summary>
    public partial class WeatherUnitRange
    {
        /// <summary> Initializes a new instance of WeatherUnitRange. </summary>
        internal WeatherUnitRange()
        {
        }

        /// <summary> Initializes a new instance of WeatherUnitRange. </summary>
        /// <param name="minimum"> Minimum temperature for the time period. </param>
        /// <param name="maximum"> Maximum temperature for the time period. </param>
        internal WeatherUnitRange(WeatherUnit minimum, WeatherUnit maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary> Minimum temperature for the time period. </summary>
        public WeatherUnit Minimum { get; }
        /// <summary> Maximum temperature for the time period. </summary>
        public WeatherUnit Maximum { get; }
    }
}
