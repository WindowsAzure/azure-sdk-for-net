﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.Json;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Azure.Identity
{
    /// <summary>
    /// Enables authentication to Azure Active Directory using Azure CLI to generated an access token.
    /// </summary>
    public class CliCredential : TokenCredential, IExtendedTokenCredential
    {
        private const string AzureCLINotInstalled = "Azure CLI not installed";
        private const string AzNotLogIn = "Please run 'az login' to setup account";
        private const string WinAzureCLIError = "'az' is not recognized";

        private readonly CredentialPipeline _pipeline;
        private readonly CliCredentialClient _client;

        /// <summary>
        /// Create an instance of CliCredential class.
        /// </summary>
        public CliCredential()
            : this(CredentialPipeline.GetInstance(null), new CliCredentialClient())
        { }

        internal CliCredential(CredentialPipeline pipeline)
            : this(pipeline, new CliCredentialClient())
        { }

        internal CliCredential(CredentialPipeline pipeline, CliCredentialClient client)
        {
            _pipeline = pipeline;

            _client = client;
        }

        /// <summary>
        /// Obtains a access token from Azure CLI credential, using this access token to authenticate. This method called by Azure SDK clients.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return GetTokenImplAsync(requestContext, cancellationToken).GetAwaiter().GetResult().GetTokenOrThrow();
        }

        /// <summary>
        /// Obtains a access token from Azure CLI service, using the access token to authenticate. This method id called by Azure SDK clients.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return (await GetTokenImplAsync(requestContext, cancellationToken).ConfigureAwait(false)).GetTokenOrThrow();
        }

        async ValueTask<ExtendedAccessToken> IExtendedTokenCredential.GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            return await GetTokenImplAsync(requestContext, cancellationToken).ConfigureAwait(false);
        }

        ExtendedAccessToken IExtendedTokenCredential.GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            return GetTokenImplAsync(requestContext, cancellationToken).GetAwaiter().GetResult();
        }

        private async ValueTask<ExtendedAccessToken> GetTokenImplAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            using CredentialDiagnosticScope scope = _pipeline.StartGetTokenScope("Azure.Identity.CliCredential.GetToken", requestContext);

            try
            {
                string command = ScopeUtilities.ScopesToResource(requestContext.Scopes);
                string extendCommand = $"az account get-access-token --resource {command}";

                (string output, int exitCode) = _client.CreateProcess(extendCommand);

                if (exitCode != 0)
                {
                    bool isLoginError = output.StartsWith("Please run 'az login'", StringComparison.CurrentCultureIgnoreCase);
                    bool isWinError = output.StartsWith(WinAzureCLIError, StringComparison.CurrentCultureIgnoreCase);
                    string pattter = "az:(.*)not found";
                    bool isOtherOsError = Regex.IsMatch(output, pattter);

                    if (isWinError || isOtherOsError)
                    {
                        throw new AuthenticationFailedException(AzureCLINotInstalled);
                    }
                    else if (isLoginError)
                    {
                        throw new AuthenticationFailedException(AzNotLogIn);
                    }

                    throw new AuthenticationFailedException(output);
                }

                byte[] byteArrary = Encoding.ASCII.GetBytes(output);
                MemoryStream stream = new MemoryStream(byteArrary);

                Dictionary<string, string> result = await JsonSerializer.DeserializeAsync<Dictionary<string, string>>(stream, null, cancellationToken);
                result.TryGetValue("accessToken", out string accessToken);
                result.TryGetValue("expiresOn", out string expiresOnValue);

                string expiresOnFormat = "yyyy-MM-dd HH:mm:ss.ffffff";
                DateTimeOffset expiresOn = DateTimeOffset.ParseExact(expiresOnValue, expiresOnFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

                AccessToken token = new AccessToken(accessToken, expiresOn);

                return new ExtendedAccessToken(scope.Succeeded(token));
            }
            catch (OperationCanceledException e)
            {
                scope.Failed(e);

                throw;
            }
            catch (Exception e)
            {
                throw scope.Failed(e);
            }
        }
    }
}
