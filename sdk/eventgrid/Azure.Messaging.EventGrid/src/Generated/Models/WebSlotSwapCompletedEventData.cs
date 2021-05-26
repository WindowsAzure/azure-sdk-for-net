// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Web.SlotSwapCompleted event. </summary>
    public partial class WebSlotSwapCompletedEventData
    {
        /// <summary> Initializes a new instance of WebSlotSwapCompletedEventData. </summary>
        internal WebSlotSwapCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of WebSlotSwapCompletedEventData. </summary>
        /// <param name="appEventTypeDetail"> Detail of action on the app. </param>
        /// <param name="name"> name of the web site that had this event. </param>
        /// <param name="clientRequestId"> The client request id generated by the app service for the site API operation that triggered this event. </param>
        /// <param name="correlationRequestId"> The correlation request id generated by the app service for the site API operation that triggered this event. </param>
        /// <param name="requestId"> The request id generated by the app service for the site API operation that triggered this event. </param>
        /// <param name="address"> HTTP request URL of this operation. </param>
        /// <param name="verb"> HTTP verb of this operation. </param>
        internal WebSlotSwapCompletedEventData(AppEventTypeDetail appEventTypeDetail, string name, string clientRequestId, string correlationRequestId, string requestId, string address, string verb)
        {
            AppEventTypeDetail = appEventTypeDetail;
            Name = name;
            ClientRequestId = clientRequestId;
            CorrelationRequestId = correlationRequestId;
            RequestId = requestId;
            Address = address;
            Verb = verb;
        }

        /// <summary> Detail of action on the app. </summary>
        public AppEventTypeDetail AppEventTypeDetail { get; }
        /// <summary> name of the web site that had this event. </summary>
        public string Name { get; }
        /// <summary> The client request id generated by the app service for the site API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The correlation request id generated by the app service for the site API operation that triggered this event. </summary>
        public string CorrelationRequestId { get; }
        /// <summary> The request id generated by the app service for the site API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> HTTP request URL of this operation. </summary>
        public string Address { get; }
        /// <summary> HTTP verb of this operation. </summary>
        public string Verb { get; }
    }
}
