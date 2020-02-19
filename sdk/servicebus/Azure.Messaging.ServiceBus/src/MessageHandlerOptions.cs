﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus.Primitives;

namespace Azure.Messaging.ServiceBus
{
    /// <summary>Provides options associated with message pump processing using
    ///  cref="QueueClient.RegisterMessageHandler(Func{Message, CancellationToken, Task}, MessageHandlerOptions)" /> and
    ///  cref="SubscriptionClient.RegisterMessageHandler(Func{Message, CancellationToken, Task}, MessageHandlerOptions)" />.</summary>
    public sealed class MessageHandlerOptions
    {
        private int _maxConcurrentCalls;
        private TimeSpan _maxAutoRenewDuration;

        /// <summary>Initializes a new instance of the <see cref="MessageHandlerOptions" /> class.
        /// Default Values:
        ///     <see cref="MaxConcurrentCalls"/> = 1
        ///     <see cref="AutoComplete"/> = true
        ///     <see cref="ReceiveTimeOut"/> = 1 minute
        ///     <see cref="MaxAutoLockRenewalDuration"/> = 5 minutes
        /// </summary>
        /// <param name="exceptionReceivedHandler">A <see cref="Func{T1, TResult}"/> that is invoked during exceptions.
        /// <see cref="ExceptionReceivedEventArgs"/> contains contextual information regarding the exception.</param>
        public MessageHandlerOptions(Func<ExceptionReceivedEventArgs, Task> exceptionReceivedHandler)
        {
            MaxConcurrentCalls = 1;
            AutoComplete = true;
            ReceiveTimeOut = Constants.DefaultOperationTimeout;
            MaxAutoLockRenewalDuration = Constants.ClientPumpRenewLockTimeout;
            ExceptionReceivedHandler = exceptionReceivedHandler ?? throw new ArgumentNullException(nameof(exceptionReceivedHandler));
        }

        /// <summary>Occurs when an exception is received. Enables you to be notified of any errors encountered by the message pump.
        /// When errors are received calls will automatically be retried, so this is informational. </summary>
        public Func<ExceptionReceivedEventArgs, Task> ExceptionReceivedHandler { get; }

        /// <summary>Gets or sets the maximum number of concurrent calls to the callback the message pump should initiate.</summary>
        /// <value>The maximum number of concurrent calls to the callback.</value>
        public int MaxConcurrentCalls
        {
            get => _maxConcurrentCalls;

            set
            {
                if (value <= 0)
                {
                    //throw new ArgumentOutOfRangeException(Resources.MaxConcurrentCallsMustBeGreaterThanZero.FormatForUser(value));
                }

                _maxConcurrentCalls = value;
            }
        }

        /// <summary>Gets or sets a value that indicates whether the message-pump should call
        ///  cref="QueueClient.CompleteAsync(string)" /> or
        ///  cref="SubscriptionClient.CompleteAsync(string)" /> on messages after the callback has completed processing.</summary>
        /// <value>true to complete the message processing automatically on successful execution of the operation; otherwise, false.</value>
        public bool AutoComplete { get; set; }

        /// <summary>Gets or sets the maximum duration within which the lock will be renewed automatically. This
        /// value should be greater than the longest message lock duration; for example, the LockDuration Property. </summary>
        /// <value>The maximum duration during which locks are automatically renewed.</value>
        /// <remarks>The message renew can continue for sometime in the background
        /// after completion of message and result in a few false MessageLockLostExceptions temporarily.</remarks>
        public TimeSpan MaxAutoLockRenewalDuration
        {
            get => this._maxAutoRenewDuration;

            set
            {
                TimeoutHelper.ThrowIfNegativeArgument(value, nameof(value));
                this._maxAutoRenewDuration = value;
            }
        }

        internal bool AutoRenewLock => MaxAutoLockRenewalDuration > TimeSpan.Zero;

        internal TimeSpan ReceiveTimeOut { get; }

        internal async Task RaiseExceptionReceived(ExceptionReceivedEventArgs eventArgs)
        {
            try
            {
                await ExceptionReceivedHandler(eventArgs).ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                MessagingEventSource.Log.ExceptionReceivedHandlerThrewException(exception);
            }
        }
    }
}
