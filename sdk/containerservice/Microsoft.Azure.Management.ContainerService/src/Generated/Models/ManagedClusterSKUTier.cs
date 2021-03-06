// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{

    /// <summary>
    /// Defines values for ManagedClusterSKUTier.
    /// </summary>
    public static class ManagedClusterSKUTier
    {
        /// <summary>
        /// Guarantees 99.95% availability of the Kubernetes API server
        /// endpoint for clusters that use Availability Zones and 99.9% of
        /// availability for clusters that don't use Availability Zones.
        /// </summary>
        public const string Paid = "Paid";
        /// <summary>
        /// No guaranteed SLA, no additional charges. Free tier clusters have
        /// an SLO of 99.5%.
        /// </summary>
        public const string Free = "Free";
    }
}
