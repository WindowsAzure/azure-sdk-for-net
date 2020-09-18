﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Identity.Tests
{
    public class VisualStudioCodeCredentialLiveTests : RecordedTestBase<IdentityTestEnvironment>
    {
        private const string ExpectedServiceName = "VS Code Azure";

        public VisualStudioCodeCredentialLiveTests(bool isAsync) : base(isAsync)
        {
            Matcher.ExcludeHeaders.Add("Content-Length");
            Matcher.ExcludeHeaders.Add("client-request-id");
            Matcher.ExcludeHeaders.Add("x-client-OS");
            Matcher.ExcludeHeaders.Add("x-client-SKU");
            Matcher.ExcludeHeaders.Add("x-client-CPU");

            Sanitizer = new IdentityRecordedTestSanitizer();
        }

        [Test]
        [RunOnlyOnPlatforms(Windows = true, OSX = true, ContainerNames = new[] { "ubuntu_netcore2_keyring" })]
        public async Task AuthenticateWithVscCredential()
        {
            var cloudName = "Azure";
            switch (TestEnvironment.AuthorityHostUrl)
            {
                case "https://login.microsoftonline.com":
                    cloudName = "Azure";
                    break;
                case "https://login.microsoftonline.us":
                    cloudName = "AzureChina";
                    break;
                case "https://login.chinacloudapi.cn":
                    cloudName = "AzureUSGovernment";
                    break;
            }

            var fileSystem = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment, cloudName);
            using IDisposable fixture = await CredentialTestHelpers.CreateRefreshTokenFixtureAsync(TestEnvironment, Mode, ExpectedServiceName, cloudName);

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = TestEnvironment.TestTenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystem, default));
            AccessToken token = await credential.GetTokenAsync(new TokenRequestContext(new[] { TestEnvironment.KeyvaultScope}), CancellationToken.None);
            Assert.IsNotNull(token.Token);
        }

        [Test]
        public async Task AuthenticateWithVscCredential_NoSettingsFile()
        {
            var refreshToken = await CredentialTestHelpers.GetRefreshTokenAsync(TestEnvironment, Mode);
            var fileSystemService = new TestFileSystemService { ReadAllHandler = s => throw new FileNotFoundException() };
            var vscAdapter = new TestVscAdapter(ExpectedServiceName, "Azure", refreshToken);

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = TestEnvironment.TestTenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystemService, vscAdapter));
            AccessToken token = await credential.GetTokenAsync(new TokenRequestContext(new[] { TestEnvironment.KeyvaultScope}), CancellationToken.None);
            Assert.IsNotNull(token.Token);
        }

        [Test]
        public async Task AuthenticateWithVscCredential_BrokenSettingsFile()
        {
            var refreshToken = await CredentialTestHelpers.GetRefreshTokenAsync(TestEnvironment, Mode);
            var fileSystemService = new TestFileSystemService { ReadAllHandler = s => "{a,}" };
            var vscAdapter = new TestVscAdapter(ExpectedServiceName, "Azure", refreshToken);

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = TestEnvironment.TestTenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystemService, vscAdapter));
            AccessToken token = await credential.GetTokenAsync(new TokenRequestContext(new[] {TestEnvironment.KeyvaultScope}), CancellationToken.None);
            Assert.IsNotNull(token.Token);
        }

        [Test]
        public async Task AuthenticateWithVscCredential_EmptySettingsFile()
        {
            var refreshToken = await CredentialTestHelpers.GetRefreshTokenAsync(TestEnvironment, Mode);
            var fileSystemService = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment);
            var vscAdapter = new TestVscAdapter(ExpectedServiceName, "Azure", refreshToken);

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = TestEnvironment.TestTenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystemService, vscAdapter));

            AccessToken token = await credential.GetTokenAsync(new TokenRequestContext(new[] {TestEnvironment.KeyvaultScope}), CancellationToken.None);
            Assert.IsNotNull(token.Token);
        }

        [Test]
        [RunOnlyOnPlatforms(Windows = true, OSX = true, ContainerNames = new[] { "ubuntu_netcore2_keyring" })]
        public async Task AuthenticateWithVscCredential_TenantInSettings()
        {
            var cloudName = Guid.NewGuid().ToString();

            var fileSystemService = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment, cloudName);
            using IDisposable fixture = await CredentialTestHelpers.CreateRefreshTokenFixtureAsync(TestEnvironment, Mode, ExpectedServiceName, cloudName);

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = Guid.NewGuid().ToString() });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystemService, default));

            AccessToken token = await credential.GetTokenAsync(new TokenRequestContext(new[] {TestEnvironment.KeyvaultScope}), CancellationToken.None);
            Assert.IsNotNull(token.Token);
        }

        [Test]
        [RunOnlyOnPlatforms(Windows = true, OSX = true, ContainerNames = new[] { "ubuntu_netcore2_keyring" })]
        public void AuthenticateWithVscCredential_NoVscInstalled()
        {
            var cloudName = Guid.NewGuid().ToString();

            var fileSystem = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment, cloudName);
            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = TestEnvironment.TestTenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystem, default));

            Assert.CatchAsync<AuthenticationFailedException>(async () => await credential.GetTokenAsync(new TokenRequestContext(new[] {TestEnvironment.KeyvaultScope}), CancellationToken.None));
        }

        [Test]
        public void AuthenticateWithVscCredential_NoRefreshToken()
        {
            var tenantId = TestEnvironment.TestTenantId;
            var vscAdapter = new TestVscAdapter(ExpectedServiceName, "Azure", null);
            var fileSystem = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment);

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = tenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystem, vscAdapter));

            Assert.CatchAsync<AuthenticationFailedException>(async () => await credential.GetTokenAsync(new TokenRequestContext(new[] {TestEnvironment.KeyvaultScope}), CancellationToken.None));
        }

        [Test]
        public void AuthenticateWithVscCredential_AuthenticationCodeInsteadOfRefreshToken()
        {
            var tenantId = TestEnvironment.TestTenantId;
            var fileSystemService = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment);
            var vscAdapter = new TestVscAdapter(ExpectedServiceName, "Azure", "{}");

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = tenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystemService, vscAdapter));

            Assert.ThrowsAsync<CredentialUnavailableException>(async () => await credential.GetTokenAsync(new TokenRequestContext(new[] {TestEnvironment.KeyvaultScope}), CancellationToken.None));
        }

        [Test]
        public void AuthenticateWithVscCredential_InvalidRefreshToken()
        {
            var tenantId = TestEnvironment.TestTenantId;
            var fileSystemService = CredentialTestHelpers.CreateFileSystemForVisualStudioCode(TestEnvironment);
            var vscAdapter = new TestVscAdapter(ExpectedServiceName, "Azure", Guid.NewGuid().ToString());

            var options = Recording.InstrumentClientOptions(new VisualStudioCodeCredentialOptions { TenantId = tenantId });
            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options, default, default, fileSystemService, vscAdapter));

            Assert.ThrowsAsync<CredentialUnavailableException>(async () => await credential.GetTokenAsync(new TokenRequestContext(new[] { TestEnvironment.KeyvaultScope }), CancellationToken.None));
        }
    }
}
