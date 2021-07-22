// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Personalizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Personalizer
{
    /// <summary> The PersonalizerBase service client. </summary>
    public partial class PersonalizerBaseClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PersonalizerBaseRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PersonalizerBaseClient for mocking. </summary>
        protected PersonalizerBaseClient()
        {
        }

        /// <summary> Initializes a new instance of PersonalizerBaseClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PersonalizerBaseClient(string endpoint, TokenCredential credential, PersonalizerBaseClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerBaseClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://cognitiveservices.azure.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new PersonalizerBaseRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of PersonalizerBaseClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PersonalizerBaseClient(string endpoint, AzureKeyCredential credential, PersonalizerBaseClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerBaseClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Ocp-Apim-Subscription-Key"));
            RestClient = new PersonalizerBaseRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of PersonalizerBaseClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        internal PersonalizerBaseClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new PersonalizerBaseRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Submit a Personalizer rank request. Receives a context and a list of actions. Returns which of the provided actions should be used by your application, in rewardActionId. </summary>
        /// <param name="rankRequest"> A Personalizer Rank request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RankResponse>> RankAsync(RankRequest rankRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PersonalizerBaseClient.Rank");
            scope.Start();
            try
            {
                return await RestClient.RankAsync(rankRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a Personalizer rank request. Receives a context and a list of actions. Returns which of the provided actions should be used by your application, in rewardActionId. </summary>
        /// <param name="rankRequest"> A Personalizer Rank request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RankResponse> Rank(RankRequest rankRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PersonalizerBaseClient.Rank");
            scope.Start();
            try
            {
                return RestClient.Rank(rankRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
