// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Monitory.Query;

namespace Azure.Monitory.Query.Models
{
    /// <summary> The result data of a query. </summary>
    public partial class Metric
    {
        /// <summary> Initializes a new instance of Metric. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="type"> the resource type of the metric resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="unit"> the unit of the metric. </param>
        /// <param name="timeseries"> the time series returned when a data query is performed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="type"/>, <paramref name="name"/>, or <paramref name="timeseries"/> is null. </exception>
        internal Metric(string id, string type, LocalizableString name, MetricUnit unit, IEnumerable<TimeSeriesElement> timeseries)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (timeseries == null)
            {
                throw new ArgumentNullException(nameof(timeseries));
            }

            Id = id;
            Type = type;
            Name = name;
            Unit = unit;
            Timeseries = timeseries.ToList();
        }

        /// <summary> Initializes a new instance of Metric. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="type"> the resource type of the metric resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="unit"> the unit of the metric. </param>
        /// <param name="timeseries"> the time series returned when a data query is performed. </param>
        internal Metric(string id, string type, LocalizableString name, MetricUnit unit, IReadOnlyList<TimeSeriesElement> timeseries)
        {
            Id = id;
            Type = type;
            Name = name;
            Unit = unit;
            Timeseries = timeseries;
        }

        /// <summary> the metric Id. </summary>
        public string Id { get; }
        /// <summary> the resource type of the metric resource. </summary>
        public string Type { get; }
        /// <summary> the name and the display name of the metric, i.e. it is localizable string. </summary>
        public LocalizableString Name { get; }
        /// <summary> the unit of the metric. </summary>
        public MetricUnit Unit { get; }
        /// <summary> the time series returned when a data query is performed. </summary>
        public IReadOnlyList<TimeSeriesElement> Timeseries { get; }
    }
}
