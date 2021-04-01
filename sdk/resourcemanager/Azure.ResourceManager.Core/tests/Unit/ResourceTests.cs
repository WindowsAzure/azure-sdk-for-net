﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using Azure.Core;
using NUnit.Framework;

namespace Azure.ResourceManager.Core.Tests
{
    [Parallelizable]
    public class ResourceTests
    {
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.classicStorage/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account2")]
        [TestCase(1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/${?>._`",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        public void CompareToObject(int expected, string id1, string id2)
        {
            TestResource<ResourceGroupResourceIdentifier> resource1 = new TestResource<ResourceGroupResourceIdentifier>(id1);
            TestResource<ResourceGroupResourceIdentifier> resource2 = new TestResource<ResourceGroupResourceIdentifier>(id2);
            Assert.AreEqual(expected, resource1.CompareTo(resource2));
        }

        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.classicStorage/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account2")]
        [TestCase(1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/${?>._`",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        public void CompareToString(int expected, string id1, string id2)
        {
            TestResource<ResourceGroupResourceIdentifier> resource1 = new TestResource<ResourceGroupResourceIdentifier>(id1);
            Assert.AreEqual(expected, resource1.CompareTo(id2));
        }

        [Test]
        public void CompareToNull()
        {
            var resource1 = new TestResource<ResourceGroupResourceIdentifier>("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1");
            TestResource<ResourceGroupResourceIdentifier> resource2 = null;
            Assert.AreEqual(1, resource1.CompareTo(resource2));
            Assert.AreEqual(1, resource1.CompareTo((string)null));
        }

        [Test]
        public void CompareToSame()
        {
            var resource1 = new TestResource<ResourceGroupResourceIdentifier>("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1");
            var resource2 = resource1;
            Assert.AreEqual(0, resource1.CompareTo(resource2));
        }

        [Test]
        public void SerializationTest()
        {
            string expected = "{\"properties\":{\"id\":\"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1\",\"name\":\"account1\",\"type\":\"Microsoft.ClassicStorage/storageAccounts\"}}";
            TestResource<ResourceGroupResourceIdentifier> data = new("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1");
            var stream = new MemoryStream();
            Utf8JsonWriter writer = new(stream, new JsonWriterOptions());
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(data);
            writer.WriteEndObject();
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(expected.Equals(json));
        }

        [Test]
        public void InvalidSerializationTest()
        {
            TestResource<ResourceGroupResourceIdentifier> data = new("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/foo");
            var stream = new MemoryStream();
            Utf8JsonWriter writer = new(stream, new JsonWriterOptions());
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(data);
            writer.WriteEndObject();
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(json.Equals("{\"properties\":{\"id\":\"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/foo\",\"name\":\"foo\",\"type\":\"Microsoft.Resources/subscriptions/resourceGroups\"}}"));
        }
    }
}
