// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the operations that can be performed over a specific SharedGallery. </summary>
    public partial class SharedGalleryOperations : ResourceOperationsBase<SubscriptionResourceIdentifier, SharedGallery>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private SharedGalleriesRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryOperations"/> class for mocking. </summary>
        protected SharedGalleryOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal SharedGalleryOperations(OperationsBase options, SubscriptionResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SharedGalleriesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<SharedGallery>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SharedGallery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<SharedGallery> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                return Response.FromValue(new SharedGallery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Gets a list of SharedGalleryImages in the SharedGallery. </summary>
        /// <returns> An object representing collection of SharedGalleryImages and their operations over a SharedGallery. </returns>
        public SharedGalleryImageContainer GetSharedGalleryImages()
        {
            return new SharedGalleryImageContainer(this);
        }
    }
}
