// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MetricsResponseSeriesItem
    {
        /// <summary>
        /// Initializes a new instance of the MetricsResponseSeriesItem class.
        /// </summary>
        public MetricsResponseSeriesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricsResponseSeriesItem class.
        /// </summary>
        /// <param name="unit">Possible values include: 'count', 'bytes',
        /// 'bitsPerSecond'</param>
        public MetricsResponseSeriesItem(string metric = default(string), string unit = default(string), IList<MetricsResponseSeriesItemGroupsItem> groups = default(IList<MetricsResponseSeriesItemGroupsItem>), IList<MetricsResponseSeriesItemDataItem> data = default(IList<MetricsResponseSeriesItemDataItem>))
        {
            Metric = metric;
            Unit = unit;
            Groups = groups;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric")]
        public string Metric { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'count', 'bytes',
        /// 'bitsPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<MetricsResponseSeriesItemGroupsItem> Groups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<MetricsResponseSeriesItemDataItem> Data { get; set; }

    }
}
