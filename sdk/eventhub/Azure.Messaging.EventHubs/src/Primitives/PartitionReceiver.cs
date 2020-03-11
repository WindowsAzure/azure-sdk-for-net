﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Core;
using Azure.Messaging.EventHubs.Diagnostics;

namespace Azure.Messaging.EventHubs.Primitives
{
    /// <summary>
    ///   Allows reading events from a specific partition of an Event Hub, and in the context
    ///   of a specific consumer group, to be read with a greater level of control over
    ///   communication with the Event Hubs service than is offered by other event consumers.
    /// </summary>
    ///
    /// <remarks>
    ///   It is recommended that the <c>EventProcessorClient</c> or <see cref="EventHubConsumerClient" />
    ///   be used for reading and processing events for the majority of scenarios.  The partition receiver is
    ///   intended to enable scenarios with special needs which require more direct control.
    /// </remarks>
    ///
    /// <seealso href="https://www.nuget.org/packages/Azure.Messaging.EventHubs.Processor" />
    /// <seealso cref="EventHubConsumerClient.ReadEventsFromPartitionAsync(string, EventPosition, CancellationToken)"/>
    /// <seealso cref="EventHubConsumerClient.ReadEventsFromPartitionAsync(string, EventPosition, ReadEventOptions, CancellationToken)"/>
    ///
    internal class PartitionReceiver : IAsyncDisposable
    {
        /// <summary>
        ///   The fully qualified Event Hubs namespace that the client is associated with.  This is likely
        ///   to be similar to <c>{yournamespace}.servicebus.windows.net</c>.
        /// </summary>
        ///
        public string FullyQualifiedNamespace => Connection.FullyQualifiedNamespace;

        /// <summary>
        ///   The name of the Event Hub that the client is connected to, specific to the
        ///   Event Hubs namespace that contains it.
        /// </summary>
        ///
        public string EventHubName => Connection.EventHubName;

        /// <summary>
        ///   The name of the consumer group that this client is associated with.  Events will be read
        ///   only in the context of this group.
        /// </summary>
        ///
        public string ConsumerGroup { get; }

        /// <summary>
        ///   The identifier of the Event Hub partition that this client is associated with.  Events will be read
        ///   only from this partition.
        /// </summary>
        ///
        public string PartitionId { get; }

        /// <summary>
        ///   The position within the partition where the client begins reading events.
        /// </summary>
        ///
        public EventPosition InitialPosition { get; }

        /// <summary>
        ///   Indicates whether or not this <see cref="PartitionReceiver"/> has been closed.
        /// </summary>
        ///
        /// <value>
        ///   <c>true</c> if the client is closed; otherwise, <c>false</c>.
        /// </value>
        ///
        public bool IsClosed { get; protected set; } = false;

        /// <summary>
        ///   The instance of <see cref="EventHubsEventSource" /> which can be mocked for testing.
        /// </summary>
        ///
        internal EventHubsEventSource Logger { get; set; } = EventHubsEventSource.Log;

        /// <summary>
        ///   Indicates whether the client has ownership of the associated <see cref="EventHubConnection" />
        ///   and should take responsibility for managing its lifespan.
        /// </summary>
        ///
        internal virtual bool OwnsConnection { get; } = true;

        /// <summary>
        ///   The policy to use for determining retry behavior for when an operation fails.
        /// </summary>
        ///
        private EventHubsRetryPolicy RetryPolicy { get; }

        /// <summary>
        ///   The active connection to the Azure Event Hubs service, enabling client communications for metadata
        ///   about the associated Event Hub and access to transport-aware consumers.
        /// </summary>
        ///
        private EventHubConnection Connection { get; }

        /// <summary>
        ///   Initializes a new instance of the <see cref="PartitionReceiver"/> class.
        /// </summary>
        ///
        /// <param name="consumerGroup">The name of the consumer group this client is associated with.  Events are read in the context of this group.</param>
        /// <param name="partitionId">The identifier of the Event Hub partition from which events will be received.</param>
        /// <param name="eventPosition">The position within the partition where the client should begin reading events.</param>
        /// <param name="connectionString">The connection string to use for connecting to the Event Hubs namespace; it is expected that the Event Hub name and the shared key properties are contained in this connection string.</param>
        /// <param name="options">A set of options to apply when configuring the client.</param>
        ///
        /// <remarks>
        ///   If the connection string is copied from the Event Hubs namespace, it will likely not contain the name of the desired Event Hub,
        ///   which is needed.  In this case, the name can be added manually by adding ";EntityPath=[[ EVENT HUB NAME ]]" to the end of the
        ///   connection string.  For example, ";EntityPath=telemetry-hub".
        ///
        ///   If you have defined a shared access policy directly on the Event Hub itself, then copying the connection string from that
        ///   Event Hub will result in a connection string that contains the name.
        /// </remarks>
        ///
        /// <seealso href="https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-get-connection-string"/>
        ///
        public PartitionReceiver(string consumerGroup,
                                 string partitionId,
                                 EventPosition eventPosition,
                                 string connectionString,
                                 PartitionReceiverOptions options = default) : this(consumerGroup, partitionId, eventPosition, connectionString, null, options)
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="PartitionReceiver"/> class.
        /// </summary>
        ///
        /// <param name="consumerGroup">The name of the consumer group this client is associated with.  Events are read in the context of this group.</param>
        /// <param name="partitionId">The identifier of the Event Hub partition from which events will be received.</param>
        /// <param name="eventPosition">The position within the partition where the client should begin reading events.</param>
        /// <param name="connectionString">The connection string to use for connecting to the Event Hubs namespace; it is expected that the shared key properties are contained in this connection string, but not the Event Hub name.</param>
        /// <param name="eventHubName">The name of the specific Event Hub to associate the client with.</param>
        /// <param name="options">A set of options to apply when configuring the client.</param>
        ///
        /// <remarks>
        ///   If the connection string is copied from the Event Hub itself, it will contain the name of the desired Event Hub,
        ///   and can be used directly without passing the <paramref name="eventHubName" />.  The name of the Event Hub should be
        ///   passed only once, either as part of the connection string or separately.
        /// </remarks>
        ///
        /// <seealso href="https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-get-connection-string"/>
        ///
        public PartitionReceiver(string consumerGroup,
                                 string partitionId,
                                 EventPosition eventPosition,
                                 string connectionString,
                                 string eventHubName,
                                 PartitionReceiverOptions options = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroup, nameof(consumerGroup));
            Argument.AssertNotNullOrEmpty(partitionId, nameof(partitionId));
            Argument.AssertNotNullOrEmpty(connectionString, nameof(connectionString));

            options = options?.Clone() ?? new PartitionReceiverOptions();

            Connection = new EventHubConnection(connectionString, eventHubName, options.ConnectionOptions);
            ConsumerGroup = consumerGroup;
            PartitionId = partitionId;
            InitialPosition = eventPosition;
            RetryPolicy = options.RetryOptions.ToRetryPolicy();
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="PartitionReceiver"/> class.
        /// </summary>
        ///
        /// <param name="consumerGroup">The name of the consumer group this client is associated with.  Events are read in the context of this group.</param>
        /// <param name="partitionId">The identifier of the Event Hub partition from which events will be received.</param>
        /// <param name="eventPosition">The position within the partition where the client should begin reading events.</param>
        /// <param name="fullyQualifiedNamespace">The fully qualified Event Hubs namespace to connect to.  This is likely to be similar to <c>{yournamespace}.servicebus.windows.net</c>.</param>
        /// <param name="eventHubName">The name of the specific Event Hub to associate the client with.</param>
        /// <param name="credential">The Azure managed identity credential to use for authorization.  Access controls may be specified by the Event Hubs namespace or the requested Event Hub, depending on Azure configuration.</param>
        /// <param name="options">A set of options to apply when configuring the client.</param>
        ///
        public PartitionReceiver(string consumerGroup,
                                 string partitionId,
                                 EventPosition eventPosition,
                                 string fullyQualifiedNamespace,
                                 string eventHubName,
                                 TokenCredential credential,
                                 PartitionReceiverOptions options = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroup, nameof(consumerGroup));
            Argument.AssertNotNullOrEmpty(partitionId, nameof(partitionId));
            Argument.AssertNotNullOrEmpty(fullyQualifiedNamespace, nameof(fullyQualifiedNamespace));
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));
            Argument.AssertNotNull(credential, nameof(credential));

            options = options?.Clone() ?? new PartitionReceiverOptions();

            Connection = new EventHubConnection(fullyQualifiedNamespace, eventHubName, credential, options.ConnectionOptions);
            ConsumerGroup = consumerGroup;
            PartitionId = partitionId;
            InitialPosition = eventPosition;
            RetryPolicy = options.RetryOptions.ToRetryPolicy();
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="PartitionReceiver"/> class.
        /// </summary>
        ///
        /// <param name="consumerGroup">The name of the consumer group this client is associated with.  Events are read in the context of this group.</param>
        /// <param name="partitionId">The identifier of the Event Hub partition from which events will be received.</param>
        /// <param name="eventPosition">The position within the partition where the client should begin reading events.</param>
        /// <param name="connection">The <see cref="EventHubConnection" /> connection to use for communication with the Event Hubs service.</param>
        /// <param name="options">A set of options to apply when configuring the client.</param>
        ///
        public PartitionReceiver(string consumerGroup,
                                 string partitionId,
                                 EventPosition eventPosition,
                                 EventHubConnection connection,
                                 PartitionReceiverOptions options = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroup, nameof(consumerGroup));
            Argument.AssertNotNullOrEmpty(partitionId, nameof(partitionId));
            Argument.AssertNotNull(connection, nameof(connection));

            options = options?.Clone() ?? new PartitionReceiverOptions();

            OwnsConnection = false;
            Connection = connection;
            ConsumerGroup = consumerGroup;
            PartitionId = partitionId;
            InitialPosition = eventPosition;
            RetryPolicy = options.RetryOptions.ToRetryPolicy();
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="PartitionReceiver"/> class.
        /// </summary>
        ///
        protected PartitionReceiver()
        {
            OwnsConnection = false;
        }

        /// <summary>
        ///   Closes the client.
        /// </summary>
        ///
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        public virtual async Task CloseAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            if (IsClosed)
            {
                return;
            }

            IsClosed = true;

            var clientHash = GetHashCode().ToString();
            Logger.ClientCloseStart(typeof(PartitionReceiver), EventHubName, clientHash);

            try
            {
                if (OwnsConnection)
                {
                    await Connection.CloseAsync().ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Logger.ClientCloseError(typeof(PartitionReceiver), EventHubName, clientHash, ex.Message);
                throw;
            }
            finally
            {
                Logger.ClientCloseComplete(typeof(PartitionReceiver), EventHubName, clientHash);
            }
        }

        /// <summary>
        ///   Performs the task needed to clean up resources used by the <see cref="PartitionReceiver" />,
        ///   including ensuring that the client itself has been closed.
        /// </summary>
        ///
        public virtual async ValueTask DisposeAsync() => await CloseAsync().ConfigureAwait(false);

        /// <summary>
        ///   Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        ///
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        ///
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        ///   Returns a hash code for this instance.
        /// </summary>
        ///
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        ///   Converts the instance to string representation.
        /// </summary>
        ///
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
