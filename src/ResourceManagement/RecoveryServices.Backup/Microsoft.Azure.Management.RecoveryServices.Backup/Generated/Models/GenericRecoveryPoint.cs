// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Generic backup copy.
    /// </summary>
    public partial class GenericRecoveryPoint : RecoveryPoint
    {
        /// <summary>
        /// Initializes a new instance of the GenericRecoveryPoint class.
        /// </summary>
        public GenericRecoveryPoint() { }

        /// <summary>
        /// Initializes a new instance of the GenericRecoveryPoint class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the backup
        /// copy.</param>
        /// <param name="recoveryPointType">Type of the backup copy.</param>
        /// <param name="recoveryPointTime">Time at which this backup copy was
        /// created.</param>
        /// <param name="recoveryPointAdditionalInfo">Additional information
        /// associated with this backup copy.</param>
        public GenericRecoveryPoint(string friendlyName = default(string), string recoveryPointType = default(string), System.DateTime? recoveryPointTime = default(System.DateTime?), string recoveryPointAdditionalInfo = default(string))
        {
            FriendlyName = friendlyName;
            RecoveryPointType = recoveryPointType;
            RecoveryPointTime = recoveryPointTime;
            RecoveryPointAdditionalInfo = recoveryPointAdditionalInfo;
        }

        /// <summary>
        /// Gets or sets friendly name of the backup copy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets type of the backup copy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointType")]
        public string RecoveryPointType { get; set; }

        /// <summary>
        /// Gets or sets time at which this backup copy was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointTime")]
        public System.DateTime? RecoveryPointTime { get; set; }

        /// <summary>
        /// Gets or sets additional information associated with this backup
        /// copy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointAdditionalInfo")]
        public string RecoveryPointAdditionalInfo { get; set; }

    }
}
