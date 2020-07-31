// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Storage.DirectoryRenamed event. </summary>
    public partial class StorageDirectoryRenamedEventData
    {
        /// <summary> Initializes a new instance of StorageDirectoryRenamedEventData. </summary>
        internal StorageDirectoryRenamedEventData()
        {
        }

        /// <summary> Initializes a new instance of StorageDirectoryRenamedEventData. </summary>
        /// <param name="api"> The name of the API/operation that triggered this event. </param>
        /// <param name="clientRequestId"> A request id provided by the client of the storage API operation that triggered this event. </param>
        /// <param name="requestId"> The request id generated by the storage service for the storage API operation that triggered this event. </param>
        /// <param name="sourceUrl"> The path to the directory that was renamed. </param>
        /// <param name="destinationUrl"> The new path to the directory after the rename operation. </param>
        /// <param name="sequencer"> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </param>
        /// <param name="identity"> The identity of the requester that triggered this event. </param>
        /// <param name="storageDiagnostics"> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </param>
        internal StorageDirectoryRenamedEventData(string api, string clientRequestId, string requestId, string sourceUrl, string destinationUrl, string sequencer, string identity, object storageDiagnostics)
        {
            Api = api;
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            SourceUrl = sourceUrl;
            DestinationUrl = destinationUrl;
            Sequencer = sequencer;
            Identity = identity;
            StorageDiagnostics = storageDiagnostics;
        }

        /// <summary> The name of the API/operation that triggered this event. </summary>
        public string Api { get; }
        /// <summary> A request id provided by the client of the storage API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The request id generated by the storage service for the storage API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> The path to the directory that was renamed. </summary>
        public string SourceUrl { get; }
        /// <summary> The new path to the directory after the rename operation. </summary>
        public string DestinationUrl { get; }
        /// <summary> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </summary>
        public string Sequencer { get; }
        /// <summary> The identity of the requester that triggered this event. </summary>
        public string Identity { get; }
        /// <summary> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </summary>
        public object StorageDiagnostics { get; }
    }
}
