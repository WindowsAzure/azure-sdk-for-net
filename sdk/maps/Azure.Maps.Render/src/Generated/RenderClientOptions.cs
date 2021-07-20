// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Maps.Render
{
    /// <summary> Client options for RenderClient. </summary>
    public partial class RenderClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2_0;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "1.0". </summary>
            V1_0 = 1,
            /// <summary> Service version "2.0". </summary>
            V2_0 = 2,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of RenderClientOptions. </summary>
        public RenderClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                ServiceVersion.V2_0 => "2.0",
                _ => throw new NotSupportedException()
            };
        }
    }
}
