// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    /// <summary> The PurviewCatalog service client. </summary>
    public partial class PurviewCatalogClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of PurviewCatalogClient for mocking. </summary>
        protected PurviewCatalogClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewCatalogClient. </summary>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.catalog.purview.azure.com. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PurviewCatalogClient(Uri endpoint, PurviewCatalogClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            options ??= new PurviewCatalogClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() });
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Gets data using search. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The keywords applied to all searchable fields. </term>
        ///   </item>
        ///   <item>
        ///     <term>offset</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The offset. The default value is 0. </term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The limit of the number of the search result. default value is 50; maximum value is 1000. </term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> The filter for the search. See examples for the usage of supported filters. </term>
        ///   </item>
        ///   <item>
        ///     <term>facets</term>
        ///     <term>SearchFacetItem[]</term>
        ///     <term></term>
        ///    <term></term>
        ///   </item>
        ///   <item>
        ///     <term>taxonomySetting</term>
        ///     <term>SearchRequestTaxonomySetting</term>
        ///     <term></term>
        ///    <term></term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchRequestTaxonomySetting</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>assetTypes</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///    <term></term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>SearchFacetItem</term>
        ///     <term></term>
        ///     <term> The content of a search facet result item. </term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchFacetItem</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>count</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The count of the facet item. </term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The name of the facet item. </term>
        ///   </item>
        ///   <item>
        ///     <term>sort</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> Any object. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> SearchAsync(RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateSearchRequest(requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets data using search. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The keywords applied to all searchable fields. </term>
        ///   </item>
        ///   <item>
        ///     <term>offset</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The offset. The default value is 0. </term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The limit of the number of the search result. default value is 50; maximum value is 1000. </term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> The filter for the search. See examples for the usage of supported filters. </term>
        ///   </item>
        ///   <item>
        ///     <term>facets</term>
        ///     <term>SearchFacetItem[]</term>
        ///     <term></term>
        ///    <term></term>
        ///   </item>
        ///   <item>
        ///     <term>taxonomySetting</term>
        ///     <term>SearchRequestTaxonomySetting</term>
        ///     <term></term>
        ///    <term></term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchRequestTaxonomySetting</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>assetTypes</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///    <term></term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>SearchFacetItem</term>
        ///     <term></term>
        ///     <term> The content of a search facet result item. </term>
        ///   </item>
        /// </list>
        /// Schema for <c>SearchFacetItem</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>count</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The count of the facet item. </term>
        ///   </item>
        ///   <item>
        ///     <term>facet</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The name of the facet item. </term>
        ///   </item>
        ///   <item>
        ///     <term>sort</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> Any object. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Search(RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateSearchRequest(requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Search"/> and <see cref="SearchAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateSearchRequest(RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/search/query", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The keywords applied to all fields that support suggest operation. It must be at least 1 character, and no more than 100 characters. In the index schema we defined a default suggester which lists all the supported fields and specifies a search mode. </term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The number of suggestions we hope to return. The default value is 5. The value must be a number between 1 and 100. </term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> The filter for the search. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> SuggestAsync(RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateSuggestRequest(requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The keywords applied to all fields that support suggest operation. It must be at least 1 character, and no more than 100 characters. In the index schema we defined a default suggester which lists all the supported fields and specifies a search mode. </term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The number of suggestions we hope to return. The default value is 5. The value must be a number between 1 and 100. </term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> The filter for the search. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Suggest(RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateSuggestRequest(requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Suggest"/> and <see cref="SuggestAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateSuggestRequest(RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/search/suggest", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Get auto complete options. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The keywords applied to all fields that support autocomplete operation. It must be at least 1 character, and no more than 100 characters. </term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The number of autocomplete results we hope to return. The default value is 50. The value must be a number between 1 and 100. </term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> The filter for the autocomplete request. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> AutoCompleteAsync(RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateAutoCompleteRequest(requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get auto complete options. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>keywords</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The keywords applied to all fields that support autocomplete operation. It must be at least 1 character, and no more than 100 characters. </term>
        ///   </item>
        ///   <item>
        ///     <term>limit</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> The number of autocomplete results we hope to return. The default value is 50. The value must be a number between 1 and 100. </term>
        ///   </item>
        ///   <item>
        ///     <term>filter</term>
        ///     <term>AnyObject</term>
        ///     <term></term>
        ///     <term> The filter for the autocomplete request. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response AutoComplete(RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateAutoCompleteRequest(requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="AutoComplete"/> and <see cref="AutoCompleteAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateAutoCompleteRequest(RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/search/autocomplete", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Get lineage info of the entity specified by GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. </param>
        /// <param name="depth"> The number of hops for lineage. </param>
        /// <param name="width"> The number of max expanding width in lineage. </param>
        /// <param name="includeParent"> True to include the parent chain in the response. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetLineageGraphAsync(string guid, string direction, int? depth = null, int? width = null, bool? includeParent = null, bool? getDerivedLineage = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetLineageGraphRequest(guid, direction, depth, width, includeParent, getDerivedLineage, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.GetLineageGraph");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get lineage info of the entity specified by GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. </param>
        /// <param name="depth"> The number of hops for lineage. </param>
        /// <param name="width"> The number of max expanding width in lineage. </param>
        /// <param name="includeParent"> True to include the parent chain in the response. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetLineageGraph(string guid, string direction, int? depth = null, int? width = null, bool? includeParent = null, bool? getDerivedLineage = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetLineageGraphRequest(guid, direction, depth, width, includeParent, getDerivedLineage, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.GetLineageGraph");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetLineageGraph"/> and <see cref="GetLineageGraphAsync"/> operations. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. </param>
        /// <param name="depth"> The number of hops for lineage. </param>
        /// <param name="width"> The number of max expanding width in lineage. </param>
        /// <param name="includeParent"> True to include the parent chain in the response. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateGetLineageGraphRequest(string guid, string direction, int? depth = null, int? width = null, bool? includeParent = null, bool? getDerivedLineage = null, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/atlas/v2/lineage/", false);
            uri.AppendPath(guid, true);
            if (depth != null)
            {
                uri.AppendQuery("depth", depth.Value, true);
            }
            if (width != null)
            {
                uri.AppendQuery("width", width.Value, true);
            }
            uri.AppendQuery("direction", direction, true);
            if (includeParent != null)
            {
                uri.AppendQuery("includeParent", includeParent.Value, true);
            }
            if (getDerivedLineage != null)
            {
                uri.AppendQuery("getDerivedLineage", getDerivedLineage.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Return immediate next page lineage info about entity with pagination. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="offset"> The offset for pagination purpose. </param>
        /// <param name="limit"> The page size - by default there is no paging. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> NextPageLineageAsync(string guid, string direction, bool? getDerivedLineage = null, int? offset = null, int? limit = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateNextPageLineageRequest(guid, direction, getDerivedLineage, offset, limit, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.NextPageLineage");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return immediate next page lineage info about entity with pagination. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="offset"> The offset for pagination purpose. </param>
        /// <param name="limit"> The page size - by default there is no paging. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response NextPageLineage(string guid, string direction, bool? getDerivedLineage = null, int? offset = null, int? limit = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateNextPageLineageRequest(guid, direction, getDerivedLineage, offset, limit, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("PurviewCatalogClient.NextPageLineage");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="NextPageLineage"/> and <see cref="NextPageLineageAsync"/> operations. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="offset"> The offset for pagination purpose. </param>
        /// <param name="limit"> The page size - by default there is no paging. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateNextPageLineageRequest(string guid, string direction, bool? getDerivedLineage = null, int? offset = null, int? limit = null, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/lineage/", false);
            uri.AppendPath(guid, true);
            uri.AppendPath("/next/", false);
            uri.AppendQuery("direction", direction, true);
            if (getDerivedLineage != null)
            {
                uri.AppendQuery("getDerivedLineage", getDerivedLineage.Value, true);
            }
            if (offset != null)
            {
                uri.AppendQuery("offset", offset.Value, true);
            }
            if (limit != null)
            {
                uri.AppendQuery("limit", limit.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
