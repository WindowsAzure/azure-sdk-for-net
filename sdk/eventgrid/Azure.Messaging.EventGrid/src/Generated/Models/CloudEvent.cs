// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Properties of an event published to an Event Grid topic using the CloudEvent 1.0 Schema. </summary>
    public partial class CloudEvent
    {
        /// <summary> Initializes a new instance of CloudEvent. </summary>
        /// <param name="id"> An identifier for the event. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="source"> Identifies the context in which an event happened. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="type"> Type of event related to the originating occurrence. </param>
        /// <param name="specversion"> The version of the CloudEvents specification which the event uses. </param>
        public CloudEvent(string id, string source, string type, string specversion)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (specversion == null)
            {
                throw new ArgumentNullException(nameof(specversion));
            }

            Id = id;
            Source = source;
            Type = type;
            Specversion = specversion;
        }

        /// <summary> Initializes a new instance of CloudEvent. </summary>
        /// <param name="id"> An identifier for the event. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="source"> Identifies the context in which an event happened. The combination of id and source must be unique for each distinct event. </param>
        /// <param name="data"> Event data specific to the event type. </param>
        /// <param name="type"> Type of event related to the originating occurrence. </param>
        /// <param name="time"> The time (in UTC) the event was generated, in RFC3339 format. </param>
        /// <param name="specversion"> The version of the CloudEvents specification which the event uses. </param>
        /// <param name="dataschema"> Identifies the schema that data adheres to. </param>
        /// <param name="datacontenttype"> Content type of data value. </param>
        /// <param name="subject"> This describes the subject of the event in the context of the event producer (identified by source). </param>
        internal CloudEvent(string id, string source, object data, string type, DateTimeOffset? time, string specversion, string dataschema, string datacontenttype, string subject)
        {
            Id = id;
            Source = source;
            Data = data;
            Type = type;
            Time = time;
            Specversion = specversion;
            Dataschema = dataschema;
            Datacontenttype = datacontenttype;
            Subject = subject;
        }

        /// <summary> An identifier for the event. The combination of id and source must be unique for each distinct event. </summary>
        public string Id { get; }
        /// <summary> Identifies the context in which an event happened. The combination of id and source must be unique for each distinct event. </summary>
        public string Source { get; }
        /// <summary> Event data specific to the event type. </summary>
        public object Data { get; set; }
        /// <summary> Type of event related to the originating occurrence. </summary>
        public string Type { get; }
        /// <summary> The time (in UTC) the event was generated, in RFC3339 format. </summary>
        public DateTimeOffset? Time { get; set; }
        /// <summary> The version of the CloudEvents specification which the event uses. </summary>
        public string Specversion { get; }
        /// <summary> Identifies the schema that data adheres to. </summary>
        public string Dataschema { get; set; }
        /// <summary> Content type of data value. </summary>
        public string Datacontenttype { get; set; }
        /// <summary> This describes the subject of the event in the context of the event producer (identified by source). </summary>
        public string Subject { get; set; }
    }
}
