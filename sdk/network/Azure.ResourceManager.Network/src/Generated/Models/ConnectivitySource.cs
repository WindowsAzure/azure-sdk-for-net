// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the source of the connection. </summary>
    public partial class ConnectivitySource
    {
        /// <summary> Initializes a new instance of ConnectivitySource. </summary>
        /// <param name="resourceId"> The ID of the resource from which a connectivity check will be initiated. </param>
        public ConnectivitySource(string resourceId)
        {
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }

            ResourceId = resourceId;
        }

        /// <summary> The ID of the resource from which a connectivity check will be initiated. </summary>
        public string ResourceId { get; }
        /// <summary> The source port from which a connectivity check will be performed. </summary>
        public int? Port { get; set; }
    }
}
