// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The WorkspaceGitRepoManagement service client. </summary>
    public partial class WorkspaceGitRepoManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal WorkspaceGitRepoManagementRestClient RestClient { get; }

        /// <summary> Initializes a new instance of WorkspaceGitRepoManagementClient for mocking. </summary>
        protected WorkspaceGitRepoManagementClient()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceGitRepoManagementClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal WorkspaceGitRepoManagementClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new WorkspaceGitRepoManagementRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get the GitHub access token. </summary>
        /// <param name="gitHubAccessTokenRequest"> The GitHubAccessTokenRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GitHubAccessTokenResponse>> GetGitHubAccessTokenAsync(GitHubAccessTokenRequest gitHubAccessTokenRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceGitRepoManagementClient.GetGitHubAccessToken");
            scope.Start();
            try
            {
                return await RestClient.GetGitHubAccessTokenAsync(gitHubAccessTokenRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the GitHub access token. </summary>
        /// <param name="gitHubAccessTokenRequest"> The GitHubAccessTokenRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GitHubAccessTokenResponse> GetGitHubAccessToken(GitHubAccessTokenRequest gitHubAccessTokenRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceGitRepoManagementClient.GetGitHubAccessToken");
            scope.Start();
            try
            {
                return RestClient.GetGitHubAccessToken(gitHubAccessTokenRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
