// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Time series instances are the time series themselves. In most cases, the deviceId or assetId is the unique identifier of the asset in the environment. Instances have descriptive information associated with them called instance fields. At a minimum, instance fields include hierarchy information. They can also include useful, descriptive data like the manufacturer, operator, or the last service date. </summary>
    public partial class TimeSeriesInstance
    {
        /// <summary> This represents the type that this instance belongs to. Never null. </summary>
        public string TypeId { get; set; }
        /// <summary> Optional name of the instance which is unique in an environment. Names acts as a mutable alias or display name of the time series instance. Mutable, may be null. </summary>
        public string Name { get; set; }
        /// <summary> This optional field contains description about the instance. </summary>
        public string Description { get; set; }
        /// <summary> Set of time series hierarchy IDs that the instance belong to. May be null. </summary>
        public IList<string> HierarchyIds { get; }
        /// <summary> Set of key-value pairs that contain user-defined instance properties. It may be null. Supported property value types are: bool, string, long, double and it cannot be nested or null. </summary>
        public IDictionary<string, object> InstanceFields { get; }
    }
}
