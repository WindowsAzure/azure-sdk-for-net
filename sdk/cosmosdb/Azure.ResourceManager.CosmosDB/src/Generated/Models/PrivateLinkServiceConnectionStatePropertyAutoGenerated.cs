// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Connection State of the Private Endpoint Connection. </summary>
    public partial class PrivateLinkServiceConnectionStatePropertyAutoGenerated
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionStatePropertyAutoGenerated. </summary>
        public PrivateLinkServiceConnectionStatePropertyAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionStatePropertyAutoGenerated. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </param>
        internal PrivateLinkServiceConnectionStatePropertyAutoGenerated(string status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public string Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </summary>
        public string ActionsRequired { get; }
    }
}
