// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ContainerRegistry.ImageDeleted event. </summary>
    public partial class ContainerRegistryImageDeletedEventData : ContainerRegistryEventData
    {
        /// <summary> Initializes a new instance of ContainerRegistryImageDeletedEventData. </summary>
        internal ContainerRegistryImageDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryImageDeletedEventData. </summary>
        /// <param name="id"> The event ID. </param>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="action"> The action that encompasses the provided event. </param>
        /// <param name="target"> The target of the event. </param>
        /// <param name="request"> The request that generated the event. </param>
        /// <param name="actor"> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </param>
        /// <param name="source"> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </param>
        internal ContainerRegistryImageDeletedEventData(string id, DateTimeOffset? timestamp, string action, ContainerRegistryEventTarget target, ContainerRegistryEventRequest request, ContainerRegistryEventActor actor, ContainerRegistryEventSource source) : base(id, timestamp, action, target, request, actor, source)
        {
        }
    }
}
