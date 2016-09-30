﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;
using Microsoft.Azure.Management.Fluent.Resource.Core;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.Fluent.Storage
{
    internal class UsagesImpl : ReadableWrappers<IStorageUsage, UsageImpl, UsageInner>,
        IUsages
    {
        private IUsageOperations client;

        internal UsagesImpl(IUsageOperations client)
        {
            this.client = client;
        }

        public PagedList<IStorageUsage> List()
        {
            if (client.List() == null)
            {
                return PagedList<UsageInner>.EmptyPagedList<IStorageUsage>();
            }

            IEnumerable<UsageInner> usages = client.List();
            var pagedList = new PagedList<UsageInner>(usages);
            return WrapList(pagedList);
        }

        protected override IStorageUsage WrapModel(UsageInner inner)
        {
            return new UsageImpl(inner);
        }
    }
}
