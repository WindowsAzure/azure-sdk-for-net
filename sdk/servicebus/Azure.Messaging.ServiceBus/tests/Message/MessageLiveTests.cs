﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Messaging.ServiceBus.Amqp;
using NUnit.Framework;

namespace Azure.Messaging.ServiceBus.Tests.Message
{
    public class MessageLiveTests : ServiceBusLiveTestBase
    {
        [Test]
        public async Task MessagePropertiesShouldSupportValidPropertyTypes()
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: false))
            {
                var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
                var sender = client.CreateSender(scope.QueueName);
                var receiver = client.CreateReceiver(scope.QueueName);

                /// Only following value types are supported:
                /// byte, sbyte, char, short, ushort, int, uint, long, ulong, float, double, decimal,
                /// bool, Guid, string, Uri, DateTime, DateTimeOffset, TimeSpan
                var msg = new ServiceBusMessage();
                msg.Properties.Add("byte", (byte)2);
                msg.Properties.Add("sbyte", (sbyte)3);
                msg.Properties.Add("char", 'c');
                msg.Properties.Add("short", (short)4);
                msg.Properties.Add("ushort", (ushort)5);
                msg.Properties.Add("int", (int)6);
                msg.Properties.Add("uint", (uint)7);
                msg.Properties.Add("long", (long)8);
                msg.Properties.Add("ulong", (ulong)9);
                msg.Properties.Add("float", (float)10.0);
                msg.Properties.Add("double", (double)11.0);
                msg.Properties.Add("decimal", (decimal)12.0);
                msg.Properties.Add("bool", true);
                msg.Properties.Add("Guid", Guid.NewGuid());
                msg.Properties.Add("string", "value");
                msg.Properties.Add("Uri", new Uri("http://nonExistingServiceBusWebsite.com"));
                msg.Properties.Add("DateTime", DateTime.UtcNow);
                msg.Properties.Add("DateTimeOffset", DateTimeOffset.UtcNow);
                msg.Properties.Add("TimeSpan", TimeSpan.FromMinutes(5));

                await sender.SendMessageAsync(msg);
                var receivedMsg = await receiver.ReceiveMessageAsync();

                Assert.IsInstanceOf(typeof(byte), receivedMsg.Properties["byte"]);
                Assert.IsInstanceOf(typeof(sbyte), receivedMsg.Properties["sbyte"]);
                Assert.IsInstanceOf(typeof(char), receivedMsg.Properties["char"]);
                Assert.IsInstanceOf(typeof(short), receivedMsg.Properties["short"]);
                Assert.IsInstanceOf(typeof(ushort), receivedMsg.Properties["ushort"]);
                Assert.IsInstanceOf(typeof(int), receivedMsg.Properties["int"]);
                Assert.IsInstanceOf(typeof(uint), receivedMsg.Properties["uint"]);
                Assert.IsInstanceOf(typeof(long), receivedMsg.Properties["long"]);
                Assert.IsInstanceOf(typeof(ulong), receivedMsg.Properties["ulong"]);
                Assert.IsInstanceOf(typeof(float), receivedMsg.Properties["float"]);
                Assert.IsInstanceOf(typeof(double), receivedMsg.Properties["double"]);
                Assert.IsInstanceOf(typeof(decimal), receivedMsg.Properties["decimal"]);
                Assert.IsInstanceOf(typeof(bool), receivedMsg.Properties["bool"]);
                Assert.IsInstanceOf(typeof(Guid), receivedMsg.Properties["Guid"]);
                Assert.IsInstanceOf(typeof(string), receivedMsg.Properties["string"]);
                Assert.IsInstanceOf(typeof(Uri), receivedMsg.Properties["Uri"]);
                Assert.IsInstanceOf(typeof(DateTime), receivedMsg.Properties["DateTime"]);
                Assert.IsInstanceOf(typeof(DateTimeOffset), receivedMsg.Properties["DateTimeOffset"]);
                Assert.IsInstanceOf(typeof(TimeSpan), receivedMsg.Properties["TimeSpan"]);
            }
        }

        [Test]
        public async Task CanSendMessageWithMaxSize()
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: false))
            {
                var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);

                var maxMessageSize = (256 * 1024) - 77;     // 77 bytes is the current serialization hit.
                var maxPayload = Enumerable.Repeat<byte>(0x20, maxMessageSize).ToArray();
                var maxSizeMessage = new ServiceBusMessage(maxPayload);

                await client.CreateSender(scope.QueueName).SendMessageAsync(maxSizeMessage);
                var receiver = client.CreateReceiver(scope.QueueName);
                var receivedMaxSizeMessage = await receiver.ReceiveMessageAsync();
                await receiver.CompleteMessageAsync(receivedMaxSizeMessage.LockToken);
                Assert.AreEqual(maxPayload, receivedMaxSizeMessage.Body.AsBytes().ToArray());
            }
        }

        [Test]
        public async Task CreateFromReceivedMessageCopiesProperties()
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: true, enableSession: true))
            {
                var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
                var sender = client.CreateSender(scope.QueueName);
                var msg = new ServiceBusMessage();
                msg.Body = new BinaryData(GetRandomBuffer(100));
                msg.ContentType = "contenttype";
                msg.CorrelationId = "correlationid";
                msg.Label = "label";
                msg.MessageId = "messageId";
                msg.PartitionKey = "key";
                msg.Properties.Add("testProp", "my prop");
                msg.ReplyTo = "replyto";
                msg.ReplyToSessionId = "replytosession";
                msg.ScheduledEnqueueTime = DateTimeOffset.Now;
                msg.SessionId = "key";
                msg.TimeToLive = TimeSpan.FromSeconds(60);
                msg.To = "to";
                await sender.SendMessageAsync(msg);

                var receiver = await client.CreateSessionReceiverAsync(
                    scope.QueueName,
                    new ServiceBusSessionReceiverOptions
                    {
                        ReceiveMode = ReceiveMode.ReceiveAndDelete
                    });
                var received = await receiver.ReceiveMessageAsync();
                AssertMessagesEqual(msg, received);
                var toSend = new ServiceBusMessage(received);
                AssertMessagesEqual(toSend, received);

                void AssertMessagesEqual(ServiceBusMessage sentMessage, ServiceBusReceivedMessage received)
                {
                    Assert.IsTrue(received.Body.AsBytes().ToArray().SequenceEqual(sentMessage.Body.AsBytes().ToArray()));
                    Assert.AreEqual(received.ContentType, sentMessage.ContentType);
                    Assert.AreEqual(received.CorrelationId, sentMessage.CorrelationId);
                    Assert.AreEqual(received.Label, sentMessage.Label);
                    Assert.AreEqual(received.ContentType, sentMessage.ContentType);
                    Assert.AreEqual(received.CorrelationId, sentMessage.CorrelationId);
                    Assert.AreEqual(received.MessageId, sentMessage.MessageId);
                    Assert.AreEqual(received.PartitionKey, sentMessage.PartitionKey);
                    Assert.AreEqual((string)received.Properties["testProp"], (string)sentMessage.Properties["testProp"]);
                    Assert.AreEqual(received.ReplyTo, sentMessage.ReplyTo);
                    Assert.AreEqual(received.ReplyToSessionId, sentMessage.ReplyToSessionId);
                    Assert.AreEqual(received.ScheduledEnqueueTime.UtcDateTime.Second, sentMessage.ScheduledEnqueueTime.UtcDateTime.Second);
                    Assert.AreEqual(received.SessionId, sentMessage.SessionId);
                    Assert.AreEqual(received.TimeToLive, sentMessage.TimeToLive);
                    Assert.AreEqual(received.To, sentMessage.To);
                    Assert.AreEqual(received.ViaPartitionKey, sentMessage.ViaPartitionKey);
                }
            }
        }

        [Test]
        public async Task SendJsonBodyMessage()
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: false))
            {
                var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
                var sender = client.CreateSender(scope.QueueName);
                var serializer = new JsonObjectSerializer();
                var testBody = new TestBody
                {
                    A = "text",
                    B = 5,
                    C = false
                };
                var body = BinaryData.FromSerializable(testBody, serializer);
                var msg = new ServiceBusMessage(body);

                await sender.SendMessageAsync(msg);

                var receiver = client.CreateReceiver(scope.QueueName);
                var received = await receiver.ReceiveMessageAsync();
                var receivedBody = received.Body.Deserialize<TestBody>(serializer);
                Assert.AreEqual(testBody.A, receivedBody.A);
                Assert.AreEqual(testBody.B, receivedBody.B);
                Assert.AreEqual(testBody.C, receivedBody.C);
            }
        }

        private class TestBody
        {
            public string A { get; set; }
            public int B { get; set; }
            public bool C { get; set; }
        }

        [Test]
        public async Task SendDataBodyMessageSingle()
        {
            await using var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: false);

            var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
            var sender = client.CreateSender(scope.QueueName);

            var bodyBytes = new byte[] { 1, 2, 3, 4, 5 };
            var body = new[] { new ReadOnlyMemory<byte>(bodyBytes) };
            var msg = sender.CreateAmqpDataMessage(body);
            Assert.AreEqual(AmqpBodyType.Data, msg.GetAmqpBodyType());
            Assert.AreEqual(default(BinaryData), msg.TransportBody.Body);
            var amqpTransportBody = msg.TransportBody as AmqpTransportBody;
            Assert.NotNull(amqpTransportBody);
            Assert.Null(amqpTransportBody.Value);
            Assert.Null(amqpTransportBody.Sequence);
            Assert.NotNull(amqpTransportBody.Data);
            Assert.IsNotEmpty(amqpTransportBody.Data);
            Assert.AreSame(body, amqpTransportBody.Data);

            await sender.SendMessageAsync(msg);

            var receiver = client.CreateReceiver(scope.QueueName);
            var received = await receiver.ReceiveMessageAsync();
            Assert.AreEqual(AmqpBodyType.Data, received.GetAmqpBodyType());
            var receivedData = received.GetAmqpDataBody();
            Assert.NotNull(receivedData);
            var receivedDataArray = receivedData.ToArray();
            Assert.IsNotEmpty(receivedDataArray);
            var receivedDataBytes = receivedDataArray[0].ToArray();
            Assert.AreEqual(bodyBytes.Length, receivedDataBytes.Length);
            Assert.AreEqual(bodyBytes[0], receivedDataBytes[0]);
            Assert.AreEqual(bodyBytes[1], receivedDataBytes[1]);
            Assert.AreEqual(bodyBytes[2], receivedDataBytes[2]);
            Assert.AreEqual(bodyBytes[3], receivedDataBytes[3]);
            Assert.AreEqual(bodyBytes[4], receivedDataBytes[4]);

            Assert.Null(received.GetAmqpValueBody());
            Assert.Null(received.GetAmqpSequenceBody());
            var receivedBodyByes = received.Body.AsBytes().ToArray();
            Assert.AreEqual(receivedBodyByes.Length, receivedDataBytes.Length);
            Assert.AreEqual(receivedBodyByes[0], receivedDataBytes[0]);
            Assert.AreEqual(receivedBodyByes[1], receivedDataBytes[1]);
            Assert.AreEqual(receivedBodyByes[2], receivedDataBytes[2]);
            Assert.AreEqual(receivedBodyByes[3], receivedDataBytes[3]);
            Assert.AreEqual(receivedBodyByes[4], receivedDataBytes[4]);
        }

        [Test]
        public async Task SendDataBodyMessageMultiple()
        {
            await using var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: false);

            var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
            var sender = client.CreateSender(scope.QueueName);

            var bodyBytes1 = new byte[] { 1, 2, 3, 4, 5 };
            var bodyBytes2 = new byte[] { 6, 7, 8, 9, 10 };
            var body = new[] { new ReadOnlyMemory<byte>(bodyBytes1), new ReadOnlyMemory<byte>(bodyBytes2) };
            var msg = sender.CreateAmqpDataMessage(body);
            Assert.AreEqual(AmqpBodyType.Data, msg.GetAmqpBodyType());
            Assert.AreEqual(default(BinaryData), msg.TransportBody.Body);
            var amqpTransportBody = msg.TransportBody as AmqpTransportBody;
            Assert.NotNull(amqpTransportBody);
            Assert.Null(amqpTransportBody.Value);
            Assert.Null(amqpTransportBody.Sequence);
            Assert.NotNull(amqpTransportBody.Data);
            Assert.IsNotEmpty(amqpTransportBody.Data);
            Assert.AreSame(body, amqpTransportBody.Data);

            await sender.SendMessageAsync(msg);

            var receiver = client.CreateReceiver(scope.QueueName);
            var received = await receiver.ReceiveMessageAsync();
            Assert.AreEqual(AmqpBodyType.Data, received.GetAmqpBodyType());
            var receivedData = received.GetAmqpDataBody();
            Assert.NotNull(receivedData);
            var receivedDataArray = receivedData.ToArray();
            Assert.IsNotEmpty(receivedDataArray);
            var receivedDataBytes1 = receivedDataArray[0].ToArray();
            Assert.AreEqual(bodyBytes1.Length, receivedDataBytes1.Length);
            Assert.AreEqual(bodyBytes1[0], receivedDataBytes1[0]);
            Assert.AreEqual(bodyBytes1[1], receivedDataBytes1[1]);
            Assert.AreEqual(bodyBytes1[2], receivedDataBytes1[2]);
            Assert.AreEqual(bodyBytes1[3], receivedDataBytes1[3]);
            Assert.AreEqual(bodyBytes1[4], receivedDataBytes1[4]);
            var receivedDataBytes2 = receivedDataArray[1].ToArray();
            Assert.AreEqual(bodyBytes2.Length, receivedDataBytes2.Length);
            Assert.AreEqual(bodyBytes2[0], receivedDataBytes2[0]);
            Assert.AreEqual(bodyBytes2[1], receivedDataBytes2[1]);
            Assert.AreEqual(bodyBytes2[2], receivedDataBytes2[2]);
            Assert.AreEqual(bodyBytes2[3], receivedDataBytes2[3]);
            Assert.AreEqual(bodyBytes2[4], receivedDataBytes2[4]);

            Assert.Null(received.GetAmqpValueBody());
            Assert.Null(received.GetAmqpSequenceBody());
            var receivedBodyByes = received.Body.AsBytes().ToArray();
            Assert.AreEqual(receivedBodyByes.Length, receivedDataBytes1.Length + receivedDataBytes2.Length);
            Assert.AreEqual(receivedBodyByes[0], receivedDataBytes1[0]);
            Assert.AreEqual(receivedBodyByes[1], receivedDataBytes1[1]);
            Assert.AreEqual(receivedBodyByes[2], receivedDataBytes1[2]);
            Assert.AreEqual(receivedBodyByes[3], receivedDataBytes1[3]);
            Assert.AreEqual(receivedBodyByes[4], receivedDataBytes1[4]);
            Assert.AreEqual(receivedBodyByes[5], receivedDataBytes2[0]);
            Assert.AreEqual(receivedBodyByes[6], receivedDataBytes2[1]);
            Assert.AreEqual(receivedBodyByes[7], receivedDataBytes2[2]);
            Assert.AreEqual(receivedBodyByes[8], receivedDataBytes2[3]);
            Assert.AreEqual(receivedBodyByes[9], receivedDataBytes2[4]);
        }
    }
}
