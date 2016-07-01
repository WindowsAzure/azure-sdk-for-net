// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.AzureStack.Management;

namespace Microsoft.AzureStack.Management
{
    public partial class AzureStackClient : ServiceClient<AzureStackClient>, IAzureStackClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Your documentation here.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Your documentation here.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Your documentation here.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private ICurationOperations _curation;
        
        /// <summary>
        /// Operations on the curation items  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual ICurationOperations Curation
        {
            get { return this._curation; }
        }
        
        private IExtensionMetadataOperations _extensionsMetadata;
        
        /// <summary>
        /// Operations for extensions metadata.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IExtensionMetadataOperations ExtensionsMetadata
        {
            get { return this._extensionsMetadata; }
        }
        
        private IGalleryItemOperations _galleryItem;
        
        /// <summary>
        /// Gallery item operations.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IGalleryItemOperations GalleryItem
        {
            get { return this._galleryItem; }
        }
        
        private IManagedLocationOperations _managedLocations;
        
        /// <summary>
        /// Managed locations operations for admin.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedLocationOperations ManagedLocations
        {
            get { return this._managedLocations; }
        }
        
        private IManagedOfferOperations _managedOffers;
        
        /// <summary>
        /// Administrator Operations on the offer  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedOfferOperations ManagedOffers
        {
            get { return this._managedOffers; }
        }
        
        private IManagedPlanOperations _managedPlans;
        
        /// <summary>
        /// Administrator operations on the plan  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedPlanOperations ManagedPlans
        {
            get { return this._managedPlans; }
        }
        
        private IManagedSubscriptionOperations _managedSubscriptions;
        
        /// <summary>
        /// Administrator Operations on the subscription  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedSubscriptionOperations ManagedSubscriptions
        {
            get { return this._managedSubscriptions; }
        }
        
        private IOfferOperations _offers;
        
        /// <summary>
        /// Operations on the offer  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IOfferOperations Offers
        {
            get { return this._offers; }
        }
        
        private IPlanOperations _plans;
        
        /// <summary>
        /// Operations on the plan  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IPlanOperations Plans
        {
            get { return this._plans; }
        }
        
        private IProviderRegistrationOperations _providerRegistrations;
        
        /// <summary>
        /// Resource provider manifest registration operations  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IProviderRegistrationOperations ProviderRegistrations
        {
            get { return this._providerRegistrations; }
        }
        
        private IPublicGalleryItemOperations _publicGalleryItem;
        
        /// <summary>
        /// Public gallery items operations.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IPublicGalleryItemOperations PublicGalleryItem
        {
            get { return this._publicGalleryItem; }
        }
        
        private IResourceGroupOperations _resourceGroups;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IResourceGroupOperations ResourceGroups
        {
            get { return this._resourceGroups; }
        }
        
        private IResourceOperations _resources;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IResourceOperations Resources
        {
            get { return this._resources; }
        }
        
        private IResourceProviderOperations _resourceProviders;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IResourceProviderOperations ResourceProviders
        {
            get { return this._resourceProviders; }
        }
        
        private IShallowResourceOperations _shallowResources;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IShallowResourceOperations ShallowResources
        {
            get { return this._shallowResources; }
        }
        
        private ISubscriptionOperations _subscriptions;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual ISubscriptionOperations Subscriptions
        {
            get { return this._subscriptions; }
        }
        
        private IUsageConnectionsOperations _usageConnections;
        
        /// <summary>
        /// Usage connection operations  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IUsageConnectionsOperations UsageConnections
        {
            get { return this._usageConnections; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        public AzureStackClient()
            : base()
        {
            this._curation = new CurationOperations(this);
            this._extensionsMetadata = new ExtensionMetadataOperations(this);
            this._galleryItem = new GalleryItemOperations(this);
            this._managedLocations = new ManagedLocationOperations(this);
            this._managedOffers = new ManagedOfferOperations(this);
            this._managedPlans = new ManagedPlanOperations(this);
            this._managedSubscriptions = new ManagedSubscriptionOperations(this);
            this._offers = new OfferOperations(this);
            this._plans = new PlanOperations(this);
            this._providerRegistrations = new ProviderRegistrationOperations(this);
            this._publicGalleryItem = new PublicGalleryItemOperations(this);
            this._resourceGroups = new ResourceGroupOperations(this);
            this._resources = new ResourceOperations(this);
            this._resourceProviders = new ResourceProviderOperations(this);
            this._shallowResources = new ShallowResourceOperations(this);
            this._subscriptions = new SubscriptionOperations(this);
            this._usageConnections = new UsageConnectionsOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='credentials'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='apiVersion'>
        /// Required. Your documentation here.
        /// </param>
        public AzureStackClient(Uri baseUri, SubscriptionCloudCredentials credentials, string apiVersion)
            : this()
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            this._apiVersion = apiVersion;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AzureStackClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._curation = new CurationOperations(this);
            this._extensionsMetadata = new ExtensionMetadataOperations(this);
            this._galleryItem = new GalleryItemOperations(this);
            this._managedLocations = new ManagedLocationOperations(this);
            this._managedOffers = new ManagedOfferOperations(this);
            this._managedPlans = new ManagedPlanOperations(this);
            this._managedSubscriptions = new ManagedSubscriptionOperations(this);
            this._offers = new OfferOperations(this);
            this._plans = new PlanOperations(this);
            this._providerRegistrations = new ProviderRegistrationOperations(this);
            this._publicGalleryItem = new PublicGalleryItemOperations(this);
            this._resourceGroups = new ResourceGroupOperations(this);
            this._resources = new ResourceOperations(this);
            this._resourceProviders = new ResourceProviderOperations(this);
            this._shallowResources = new ShallowResourceOperations(this);
            this._subscriptions = new SubscriptionOperations(this);
            this._usageConnections = new UsageConnectionsOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='credentials'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='apiVersion'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AzureStackClient(Uri baseUri, SubscriptionCloudCredentials credentials, string apiVersion, HttpClient httpClient)
            : this(httpClient)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            this._apiVersion = apiVersion;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another AzureStackClient
        /// instance
        /// </summary>
        /// <param name='client'>
        /// Instance of AzureStackClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<AzureStackClient> client)
        {
            base.Clone(client);
            
            if (client is AzureStackClient)
            {
                AzureStackClient clonedClient = ((AzureStackClient)client);
                
                clonedClient._baseUri = this._baseUri;
                clonedClient._credentials = this._credentials;
                clonedClient._apiVersion = this._apiVersion;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
