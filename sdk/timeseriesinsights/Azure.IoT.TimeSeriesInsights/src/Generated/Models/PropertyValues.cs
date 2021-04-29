// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property. </summary>
    public partial class PropertyValues : EventProperty
    {
        /// <summary> Initializes a new instance of PropertyValues. </summary>
        public PropertyValues()
        {
        }

        /// <summary> Initializes a new instance of PropertyValues. </summary>
        /// <param name="name"> The name of the property. </param>
        /// <param name="type"> The type of the property. </param>
        /// <param name="valuesInternal"> Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property. </param>
        internal PropertyValues(string name, PropertyTypes? type, JsonElement valuesInternal) : base(name, type)
        {
            ValuesInternal = valuesInternal;
        }
    }
}
