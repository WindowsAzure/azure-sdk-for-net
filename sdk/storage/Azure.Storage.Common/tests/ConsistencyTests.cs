﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using Azure.Storage.Blobs;
using Azure.Storage.Files;
using Azure.Storage.Queues;
using Azure.Storage.Test;
using NUnit.Framework;

namespace Azure.Storage.Common.Test
{
    [TestFixture]
    public class ConsistencyTests
    {
        [Test]
        public void ServiceVersions()
        {
            var blobs = Enum.GetNames(typeof(BlobClientOptions.ServiceVersion));
            var queues = Enum.GetNames(typeof(QueueClientOptions.ServiceVersion));
            var files = Enum.GetNames(typeof(FileClientOptions.ServiceVersion));

            TestHelper.AssertSequenceEqual(blobs, queues);
            TestHelper.AssertSequenceEqual(blobs, files);
        }
    }
}
