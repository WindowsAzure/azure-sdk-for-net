// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Represents collection of metric namespaces. </summary>
    internal partial class MetricNamespaceCollection
    {
        /// <summary> Initializes a new instance of MetricNamespaceCollection. </summary>
        /// <param name="value"> The values for the metric namespaces. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal MetricNamespaceCollection(IEnumerable<MetricNamespace> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of MetricNamespaceCollection. </summary>
        /// <param name="value"> The values for the metric namespaces. </param>
        internal MetricNamespaceCollection(IReadOnlyList<MetricNamespace> value)
        {
            Value = value;
        }

        /// <summary> The values for the metric namespaces. </summary>
        public IReadOnlyList<MetricNamespace> Value { get; }
    }
}
