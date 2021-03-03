// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensions.Msal;
using Moq;
using NUnit.Framework;

namespace Azure.Identity.Tests
{
    public class TokenCacheTests : ClientTestBase
    {
        public TokenCacheTests(bool isAsync) : base(isAsync)
        { }

        internal TokenCache cache;
        public Mock<ITokenCacheSerializer> mockSerializer1;
        public Mock<ITokenCacheSerializer> mockSerializer2;
        public Mock<ITokenCache> mockMSALCache;
        internal Mock<MsalCacheHelperWrapper> mockWrapper;
        public static Random random = new Random();
        public byte[] bytes = new byte[] { 1, 0 };
        public byte[] updatedBytes = new byte[] { 0, 2 };
        public byte[] mergedBytes = new byte[] { 1, 2 };
        public Func<TokenCacheNotificationArgs, Task> main_OnBeforeCacheAccessAsync = null;
        public Func<TokenCacheNotificationArgs, Task> main_OnAfterCacheAccessAsync = null;
        public TokenCacheCallback merge_OnBeforeCacheAccessAsync = null;
        public TokenCacheCallback merge_OnAfterCacheAccessAsync = null;
        private const int TestBufferSize = 512;
        private static Random rand = new Random();

        [SetUp]
        public void Setup()
        {
            mockSerializer1 = new Mock<ITokenCacheSerializer>();
            mockSerializer2 = new Mock<ITokenCacheSerializer>();
            mockMSALCache = new Mock<ITokenCache>();
            mockWrapper = new Mock<MsalCacheHelperWrapper>();
            mockWrapper.Setup(m => m.InitializeAsync(It.IsAny<StorageCreationProperties>(), null))
                .Returns(Task.CompletedTask);
            cache = new TokenCache(new TokenCachePersistenceOptions(), mockWrapper.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            TokenCache.ResetWrapperCache();
        }

        public static IEnumerable<object[]> PersistentCacheOptions()
        {
            yield return new object[] { new TokenCachePersistenceOptions { AllowUnencryptedStorage = true, Name = "foo" }, true, "foo" };
            yield return new object[] { new TokenCachePersistenceOptions { AllowUnencryptedStorage = false, Name = "bar" }, false, "bar" };
            yield return new object[] { new TokenCachePersistenceOptions { AllowUnencryptedStorage = false }, false, Constants.DefaultMsalTokenCacheName };
            yield return new object[] { new TokenCachePersistenceOptions { Name = "fizz" }, false, "fizz" };
            yield return new object[] { new TokenCachePersistenceOptions(), false, Constants.DefaultMsalTokenCacheName };
        }

        [Test]
        [TestCaseSource(nameof(PersistentCacheOptions))]
        public void CtorAllowsAllPermutations(TokenCachePersistenceOptions options, bool expectedAllowUnencryptedStorage, string expectedName)
        {
            cache = new TokenCache(options);
        }

        [Test]
        public async Task NoPersistance_RegisterCacheInitializesEvents()
        {
            cache = new TokenCache(new InMemoryTokenCacheOptions(bytes));

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
        }

        [Test]
        public async Task NoPersistance_RegisterCacheInitializesEventsOnlyOnce()
        {
            cache = new TokenCache(new InMemoryTokenCacheOptions(bytes));

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCacheWithName()
        {
            string cacheName = Guid.NewGuid().ToString();
            cache = new TokenCache(new TokenCachePersistenceOptions() { Name = cacheName }, mockWrapper.Object);

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == TokenCache.s_msalCacheClientId &&
                    p.CacheFileName == cacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null));

            mockWrapper.Verify(m => m.RegisterCache(It.IsAny<ITokenCache>()), Times.AtLeastOnce);
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCache()
        {
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == TokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null));

            mockWrapper.Verify(m => m.RegisterCache(It.IsAny<ITokenCache>()), Times.AtLeastOnce);
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCacheOnlyOnce()
        {
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == TokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null), Times.Once);

            mockWrapper.Verify(m => m.RegisterCache(It.IsAny<ITokenCache>()), Times.Exactly(2));
        }

        [Test]
        [NonParallelizable]
        public void RegisterCacheInitializesCacheAndIsThreadSafe()
        {
            ManualResetEventSlim resetEvent2 = new ManualResetEventSlim();
            ManualResetEventSlim resetEvent1 = new ManualResetEventSlim();

            //The fist call to InitializeAsync will block. The second one will complete immediately.
            mockWrapper.SetupSequence(m => m.InitializeAsync(It.IsAny<StorageCreationProperties>(), null))
                .Returns(() =>
                {
                    resetEvent1.Wait(1);
                    resetEvent1.Set();
                    resetEvent2.Wait();
                    return Task.CompletedTask;
                })
                .Returns(Task.CompletedTask);
            var cache2 = new TokenCache(new TokenCachePersistenceOptions(), mockWrapper.Object);

            var task1 = Task.Run(() => cache.RegisterCache(IsAsync, mockMSALCache.Object, default));
            var task2 = Task.Run(() => cache2.RegisterCache(IsAsync, mockMSALCache.Object, default));

            //Ensure the two tasks are running before we release the first call to InitializeAsync.
            resetEvent1.Wait();
            resetEvent2.Set();

            Task.WaitAll(task1, task2);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == TokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null));

            mockWrapper.Verify(m => m.RegisterCache(It.IsAny<ITokenCache>()), Times.Exactly(2));
        }

        [Test]
        [NonParallelizable]
        public void RegisterCacheThrowsIfEncryptionIsUnavailableAndAllowUnencryptedStorageIsFalse()
        {
            mockWrapper.Setup(m => m.VerifyPersistence()).Throws<MsalCachePersistenceException>();

            Assert.ThrowsAsync<MsalCachePersistenceException>(() => cache.RegisterCache(IsAsync, mockMSALCache.Object, default));
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCacheIfEncryptionIsUnavailableAndAllowUnencryptedStorageIsTrue()
        {
            mockWrapper.SetupSequence(m => m.VerifyPersistence())
            .Throws<MsalCachePersistenceException>()
            .Pass();
            cache = new TokenCache(new TokenCachePersistenceOptions { AllowUnencryptedStorage = true }, mockWrapper.Object);

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == TokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.UseLinuxUnencryptedFallback),
                null));

            mockWrapper.Verify(m => m.RegisterCache(It.IsAny<ITokenCache>()), Times.AtLeastOnce);
        }

        [Test]
        public async Task Persistance_RegisterCacheDoesNotInitializesEvents()
        {
            cache = new TokenCache(new TokenCachePersistenceOptions());

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Never);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Never);
        }

        [Test]
        public async Task InMemory_RegisterCacheInitializesEvents()
        {
            cache = new TokenCache(new InMemoryTokenCacheOptions(bytes));

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
        }

        [Test]
        public async Task InMemory_RegisterCacheInitializesEventsOnlyOnce()
        {
            cache = new TokenCache(new InMemoryTokenCacheOptions(bytes));

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
        }

        [Test]
        public async Task RegisteredEventsAreCalledOnFirstUpdate()
        {
            cache = new TokenCache(new InMemoryTokenCacheOptions(bytes));

            TokenCacheNotificationArgs mockArgs = GetMockArgs(mockSerializer1, true);
            bool updatedCalled = false;

            mockMSALCache
                .Setup(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()))
                .Callback<Func<TokenCacheNotificationArgs, Task>>(beforeAccess => main_OnBeforeCacheAccessAsync = beforeAccess);
            mockMSALCache
                .Setup(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()))
                .Callback<Func<TokenCacheNotificationArgs, Task>>(afterAccess => main_OnAfterCacheAccessAsync = afterAccess);

            mockSerializer1.Setup(m => m.SerializeMsalV3()).Returns(bytes);

            cache.TokenCacheUpdatedAsync += (args) =>
            {
                updatedCalled = true;
                return Task.CompletedTask;
            };

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await main_OnBeforeCacheAccessAsync.Invoke(mockArgs);
            await main_OnAfterCacheAccessAsync.Invoke(mockArgs);

            mockSerializer1.Verify(m => m.DeserializeMsalV3(cache.Data, true), Times.Once);
            mockSerializer1.Verify(m => m.SerializeMsalV3(), Times.Once);
            Assert.That(updatedCalled);
            Assert.That(cache.Data, Is.EqualTo(bytes));
        }

        [Test]
        public async Task MergeOccursOnSecondUpdate()
        {
            var mockPublicClient = new Mock<IPublicClientApplication>();
            var mergeMSALCache = new Mock<ITokenCache>();
            TokenCacheNotificationArgs mockArgs1 = GetMockArgs(mockSerializer1, true);
            TokenCacheNotificationArgs mockArgs2 = GetMockArgs(mockSerializer2, true);

            mockMSALCache
                .Setup(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()))
                .Callback<Func<TokenCacheNotificationArgs, Task>>(beforeAccess => main_OnBeforeCacheAccessAsync = beforeAccess);
            mockMSALCache
                .Setup(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()))
                .Callback<Func<TokenCacheNotificationArgs, Task>>(afterAccess => main_OnAfterCacheAccessAsync = afterAccess);
            mergeMSALCache
                .Setup(m => m.SetBeforeAccess(It.IsAny<TokenCacheCallback>()))
                .Callback<TokenCacheCallback>(beforeAccess =>
                {
                    merge_OnBeforeCacheAccessAsync = beforeAccess;
                });
            mergeMSALCache
                .Setup(m => m.SetAfterAccess(It.IsAny<TokenCacheCallback>()))
                .Callback<TokenCacheCallback>(afterAccess => merge_OnAfterCacheAccessAsync = afterAccess);
            mockSerializer1
                .SetupSequence(m => m.SerializeMsalV3())
                .Returns(bytes)
                .Returns(mergedBytes);
            mockSerializer2
                .SetupSequence(m => m.SerializeMsalV3())
                .Returns(updatedBytes);
            mockPublicClient
                .SetupGet(m => m.UserTokenCache).Returns(mergeMSALCache.Object);
            mockPublicClient
                .Setup(m => m.GetAccountsAsync())
                .ReturnsAsync(() => new List<IAccount>())
                .Callback(() =>
                {
                    merge_OnBeforeCacheAccessAsync(mockArgs1);
                    var list = merge_OnBeforeCacheAccessAsync.GetInvocationList();
                    if (merge_OnAfterCacheAccessAsync != null)
                        merge_OnAfterCacheAccessAsync(mockArgs1);
                });

            cache = new TokenCache(new InMemoryTokenCacheOptions(bytes), default, publicApplicationFactory: new Func<IPublicClientApplication>(() => mockPublicClient.Object));

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await cache.RegisterCache(IsAsync, mergeMSALCache.Object, default);

            // Read the cache from consumer 1.
            await main_OnBeforeCacheAccessAsync.Invoke(mockArgs1);
            // Read and write the cache from consumer 2.
            await main_OnBeforeCacheAccessAsync.Invoke(mockArgs2);
            // Dealy to ensure that the timestamps are different between last read and last updated.
            await Task.Delay(100);
            await main_OnAfterCacheAccessAsync.Invoke(mockArgs2);
            // Consumer 1 now writes, and must update its cache first.
            await main_OnAfterCacheAccessAsync.Invoke(mockArgs1);

            mockSerializer1.Verify(m => m.DeserializeMsalV3(bytes, true), Times.Exactly(1));
            mockSerializer1.Verify(m => m.SerializeMsalV3(), Times.Exactly(2));
            mockSerializer1.Verify(m => m.DeserializeMsalV3(bytes, false), Times.Exactly(1));
            mockSerializer1.Verify(m => m.DeserializeMsalV3(updatedBytes, false), Times.Exactly(1));
            mockSerializer2.Verify(m => m.DeserializeMsalV3(bytes, true), Times.Exactly(1));
            mockSerializer2.Verify(m => m.SerializeMsalV3(), Times.Exactly(1));

            // validate that we ended up with the merged cache.
            Assert.That(cache.Data, Is.EqualTo(mergedBytes));
        }

        [Test]
        public async Task Serialize()
        {
            var evt = new ManualResetEventSlim();
            var mockPublicClient = new Mock<IPublicClientApplication>();
            TokenCacheNotificationArgs mockArgs1 = GetMockArgs(mockSerializer1, true);
            mockSerializer1
                .SetupSequence(m => m.SerializeMsalV3())
                .Returns(updatedBytes);
            mockMSALCache
                .Setup(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()))
                .Callback<Func<TokenCacheNotificationArgs, Task>>(beforeAccess => main_OnBeforeCacheAccessAsync = beforeAccess);
            mockMSALCache
                .Setup(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()))
                .Callback<Func<TokenCacheNotificationArgs, Task>>(afterAccess => main_OnAfterCacheAccessAsync = afterAccess);

            var cache = new TokenCache(new InMemoryTokenCacheOptions(bytes, updateHandler), default, publicApplicationFactory: new Func<IPublicClientApplication>(() => mockPublicClient.Object));
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            await main_OnBeforeCacheAccessAsync.Invoke(mockArgs1);
            await main_OnAfterCacheAccessAsync.Invoke(mockArgs1);

            Task updateHandler(TokenCacheUpdatedArgs args)
            {
                Assert.That(args.Data.ToArray(), Is.EqualTo(updatedBytes));
                evt.Set();
                return Task.CompletedTask;
            };

            evt.Wait();
        }

        private static TokenCacheNotificationArgs GetMockArgs(Mock<ITokenCacheSerializer> mockSerializer, bool hasStateChanged)
        {
            TokenCacheNotificationArgs mockArgs = (TokenCacheNotificationArgs)FormatterServices.GetUninitializedObject(typeof(TokenCacheNotificationArgs));
            var ctor = typeof(TokenCacheNotificationArgs).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
            mockArgs = (TokenCacheNotificationArgs)ctor[0].Invoke(new object[] { mockSerializer.Object, "foo", null, hasStateChanged, true, true, null });
            return mockArgs;
        }

        public class InMemoryTokenCacheOptions : UnsafeTokenCacheOptions
        {
            private readonly ReadOnlyMemory<byte> _bytes;
            private readonly Func<TokenCacheUpdatedArgs, Task> _updated;
            public InMemoryTokenCacheOptions(byte[] bytes, Func<TokenCacheUpdatedArgs, Task> updated = null)
            {
                _bytes = bytes;
                _updated = updated;
            }
            public override Task<ReadOnlyMemory<byte>> RefreshCacheAsync()
            {
                return Task.FromResult(_bytes);
            }

            public override Task TokenCacheUpdatedAsync(TokenCacheUpdatedArgs tokenCacheUpdatedArgs)
            {
                return _updated == null ? Task.CompletedTask : _updated(tokenCacheUpdatedArgs);
            }
        }
    }
}
