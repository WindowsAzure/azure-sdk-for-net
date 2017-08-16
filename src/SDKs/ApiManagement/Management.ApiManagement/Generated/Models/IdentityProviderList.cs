// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of all the Identity Providers configured on the service instance.
    /// </summary>
    public partial class IdentityProviderList
    {
        /// <summary>
        /// Initializes a new instance of the IdentityProviderList class.
        /// </summary>
        public IdentityProviderList()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityProviderList class.
        /// </summary>
        /// <param name="value">Identity Provider configuration values.</param>
        /// <param name="nextLink">Next page link if any.</param>
        public IdentityProviderList(IList<IdentityProviderContract> value = default(IList<IdentityProviderContract>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identity Provider configuration values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<IdentityProviderContract> Value { get; set; }

        /// <summary>
        /// Gets or sets next page link if any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
