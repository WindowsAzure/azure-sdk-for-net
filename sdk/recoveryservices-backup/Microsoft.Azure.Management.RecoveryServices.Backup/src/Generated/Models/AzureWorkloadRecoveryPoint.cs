// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Workload specific recovery point, specifically encapsulates full/diff
    /// recovery point
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureWorkloadRecoveryPoint")]
    public partial class AzureWorkloadRecoveryPoint : RecoveryPoint
    {
        /// <summary>
        /// Initializes a new instance of the AzureWorkloadRecoveryPoint class.
        /// </summary>
        public AzureWorkloadRecoveryPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureWorkloadRecoveryPoint class.
        /// </summary>
        /// <param name="recoveryPointTimeInUTC">UTC time at which recovery
        /// point was created</param>
        /// <param name="type">Type of restore point. Possible values include:
        /// 'Invalid', 'Full', 'Log', 'Differential'</param>
        public AzureWorkloadRecoveryPoint(System.DateTime? recoveryPointTimeInUTC = default(System.DateTime?), string type = default(string))
        {
            RecoveryPointTimeInUTC = recoveryPointTimeInUTC;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets UTC time at which recovery point was created
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointTimeInUTC")]
        public System.DateTime? RecoveryPointTimeInUTC { get; private set; }

        /// <summary>
        /// Gets type of restore point. Possible values include: 'Invalid',
        /// 'Full', 'Log', 'Differential'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
