// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Timezone.Models
{
    /// <summary> The TimeZoneByCoordinates. </summary>
    public partial class TimeZoneByCoordinates
    {
        /// <summary> Initializes a new instance of TimeZoneByCoordinates. </summary>
        internal TimeZoneByCoordinates()
        {
            Aliases = new ChangeTrackingList<string>();
            Countries = new ChangeTrackingList<CountryRecord>();
            TimeTransitions = new ChangeTrackingList<TimeTransition>();
        }

        /// <summary> Initializes a new instance of TimeZoneByCoordinates. </summary>
        /// <param name="id"> Id property. </param>
        /// <param name="aliases">
        /// An array of time zone ID aliases.  Only returned when [options]=*zoneinfo* or *all*.
        /// 
        /// Note: may be null.
        /// </param>
        /// <param name="countries"> An array of country records. Only returned when [options]=*zoneinfo* or *all*. </param>
        /// <param name="names"> Timezone names object. </param>
        /// <param name="referenceTime"> Details in effect at the local time. </param>
        /// <param name="representativePoint"> Representative point property. </param>
        /// <param name="timeTransitions"> Time zone DST transitions from [transitionsFrom] until timestamp + 1 year. </param>
        internal TimeZoneByCoordinates(string id, IReadOnlyList<string> aliases, IReadOnlyList<CountryRecord> countries, TimezoneNames names, ReferenceTimeByCoordinates referenceTime, RepresentativePoint representativePoint, IReadOnlyList<TimeTransition> timeTransitions)
        {
            Id = id;
            Aliases = aliases;
            Countries = countries;
            Names = names;
            ReferenceTime = referenceTime;
            RepresentativePoint = representativePoint;
            TimeTransitions = timeTransitions;
        }

        /// <summary> Id property. </summary>
        public string Id { get; }
        /// <summary>
        /// An array of time zone ID aliases.  Only returned when [options]=*zoneinfo* or *all*.
        /// 
        /// Note: may be null.
        /// </summary>
        public IReadOnlyList<string> Aliases { get; }
        /// <summary> An array of country records. Only returned when [options]=*zoneinfo* or *all*. </summary>
        public IReadOnlyList<CountryRecord> Countries { get; }
        /// <summary> Timezone names object. </summary>
        public TimezoneNames Names { get; }
        /// <summary> Details in effect at the local time. </summary>
        public ReferenceTimeByCoordinates ReferenceTime { get; }
        /// <summary> Representative point property. </summary>
        public RepresentativePoint RepresentativePoint { get; }
        /// <summary> Time zone DST transitions from [transitionsFrom] until timestamp + 1 year. </summary>
        public IReadOnlyList<TimeTransition> TimeTransitions { get; }
    }
}
