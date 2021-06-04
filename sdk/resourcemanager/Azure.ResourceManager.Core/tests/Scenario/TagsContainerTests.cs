﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.s

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Core.Tests
{
    public class TagsContainerTests : ResourceManagerTestBase
    {
        public TagsContainerTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [OneTimeTearDown]
        protected void GlobalTagCleanup()
        {
            var container = Client.DefaultSubscription.GetTags();
            var operation = Client.GetTagOperations();
            var listResult = container.List().Where(x => x.Details.TagName.StartsWith("tagName"));
            foreach (var item in listResult)
            {
                operation.Delete(item.Details.TagName);
            };
        }

        [Test, Order(1)]
        [RecordedTest]
        public async Task Create()
        {
            var tagName = Recording.GenerateAssetName("tagName");
            var container = Client.DefaultSubscription.GetTags();
            var result = await container.CreateOrUpdateAsync(tagName);
            Assert.IsTrue(result.Value.Details.TagName.Equals(tagName));
        }

        [Test, Order(2)]
        [RecordedTest]
        public async Task List()
        {
            var container = Client.DefaultSubscription.GetTags();
            var result = await container.ListAsync().ToEnumerableAsync();
            Assert.GreaterOrEqual(result.Count, 1, "List result less than 1");
            var expectTag = result.Where(x => x.Details.TagName.StartsWith("tagName")).FirstOrDefault();
            Assert.NotNull(expectTag);
        }
    }
}
