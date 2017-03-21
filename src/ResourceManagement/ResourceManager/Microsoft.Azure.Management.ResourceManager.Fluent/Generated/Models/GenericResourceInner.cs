// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource information.
    /// </summary>
    public partial class GenericResourceInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the GenericResourceInner class.
        /// </summary>
        public GenericResourceInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenericResourceInner class.
        /// </summary>
        /// <param name="plan">The plan of the resource.</param>
        /// <param name="properties">The resource properties.</param>
        /// <param name="kind">The kind of the resource.</param>
        /// <param name="managedBy">Id of the resource that manages this
        /// resource.</param>
        /// <param name="sku">The sku of the resource.</param>
        /// <param name="identity">The identity of the resource.</param>
        public GenericResourceInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Plan plan = default(Plan), object properties = default(object), string kind = default(string), string managedBy = default(string), Sku sku = default(Sku), Identity identity = default(Identity))
            : base(location, id, name, type, tags)
        {
            Plan = plan;
            Properties = properties;
            Kind = kind;
            ManagedBy = managedBy;
            Sku = sku;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the plan of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the resource properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the kind of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets id of the resource that manages this resource.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Gets or sets the sku of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

    }
}
