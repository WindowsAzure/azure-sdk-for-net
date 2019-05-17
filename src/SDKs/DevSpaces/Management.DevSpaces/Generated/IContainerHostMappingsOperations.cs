// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevSpaces
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ContainerHostMappingsOperations operations.
    /// </summary>
    public partial interface IContainerHostMappingsOperations
    {
        /// <summary>
        /// Returns container host mapping object for a container host resource
        /// ID if an associated controller exists.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group to which the resource belongs.
        /// </param>
        /// <param name='location'>
        /// Location of the container host.
        /// </param>
        /// <param name='containerHostResourceId'>
        /// ARM ID of the Container Host resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DevSpacesErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ContainerHostMapping>> GetContainerHostMappingWithHttpMessagesAsync(string resourceGroupName, string location, string containerHostResourceId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
