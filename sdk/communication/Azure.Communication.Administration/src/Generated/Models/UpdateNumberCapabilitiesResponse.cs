// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Diagnostics.CodeAnalysis;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Represents a number capability update response. </summary>
    [ExcludeFromCodeCoverage]
    public partial class UpdateNumberCapabilitiesResponse
    {
        /// <summary> Initializes a new instance of UpdateNumberCapabilitiesResponse. </summary>
        /// <param name="capabilitiesUpdateId"> The capabilities id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilitiesUpdateId"/> is null. </exception>
        internal UpdateNumberCapabilitiesResponse(string capabilitiesUpdateId)
        {
            if (capabilitiesUpdateId == null)
            {
                throw new ArgumentNullException(nameof(capabilitiesUpdateId));
            }

            CapabilitiesUpdateId = capabilitiesUpdateId;
        }

        /// <summary> The capabilities id. </summary>
        public string CapabilitiesUpdateId { get; }
    }
}
