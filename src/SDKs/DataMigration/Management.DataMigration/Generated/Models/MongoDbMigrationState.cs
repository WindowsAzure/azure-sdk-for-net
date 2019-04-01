// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{

    /// <summary>
    /// Defines values for MongoDbMigrationState.
    /// </summary>
    public static class MongoDbMigrationState
    {
        public const string NotStarted = "NotStarted";
        public const string ValidatingInput = "ValidatingInput";
        public const string Initializing = "Initializing";
        public const string Restarting = "Restarting";
        public const string Copying = "Copying";
        public const string InitialReplay = "InitialReplay";
        public const string Replaying = "Replaying";
        public const string Finalizing = "Finalizing";
        public const string Complete = "Complete";
        public const string Canceled = "Canceled";
        public const string Failed = "Failed";
    }
}
