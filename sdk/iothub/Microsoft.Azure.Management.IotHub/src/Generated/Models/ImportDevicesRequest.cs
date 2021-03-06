// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Use to provide parameters when requesting an import of all devices in
    /// the hub.
    /// </summary>
    public partial class ImportDevicesRequest
    {
        /// <summary>
        /// Initializes a new instance of the ImportDevicesRequest class.
        /// </summary>
        public ImportDevicesRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportDevicesRequest class.
        /// </summary>
        /// <param name="inputBlobContainerUri">The input blob container
        /// URI.</param>
        /// <param name="outputBlobContainerUri">The output blob container
        /// URI.</param>
        /// <param name="inputBlobName">The blob name to be used when importing
        /// from the provided input blob container.</param>
        /// <param name="outputBlobName">The blob name to use for storing the
        /// status of the import job.</param>
        /// <param name="authenticationType">Specifies authentication type
        /// being used for connecting to the storage account. Possible values
        /// include: 'keyBased', 'identityBased'</param>
        /// <param name="identity">Managed identity properties of storage
        /// endpoint for import devices.</param>
        /// <param name="includeConfigurations">The value indicating whether
        /// configurations should be imported.</param>
        /// <param name="configurationsBlobName">The blob name to be used when
        /// importing configurations from the provided input blob
        /// container.</param>
        public ImportDevicesRequest(string inputBlobContainerUri, string outputBlobContainerUri, string inputBlobName = default(string), string outputBlobName = default(string), string authenticationType = default(string), ManagedIdentity identity = default(ManagedIdentity), bool? includeConfigurations = default(bool?), string configurationsBlobName = default(string))
        {
            InputBlobContainerUri = inputBlobContainerUri;
            OutputBlobContainerUri = outputBlobContainerUri;
            InputBlobName = inputBlobName;
            OutputBlobName = outputBlobName;
            AuthenticationType = authenticationType;
            Identity = identity;
            IncludeConfigurations = includeConfigurations;
            ConfigurationsBlobName = configurationsBlobName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the input blob container URI.
        /// </summary>
        [JsonProperty(PropertyName = "inputBlobContainerUri")]
        public string InputBlobContainerUri { get; set; }

        /// <summary>
        /// Gets or sets the output blob container URI.
        /// </summary>
        [JsonProperty(PropertyName = "outputBlobContainerUri")]
        public string OutputBlobContainerUri { get; set; }

        /// <summary>
        /// Gets or sets the blob name to be used when importing from the
        /// provided input blob container.
        /// </summary>
        [JsonProperty(PropertyName = "inputBlobName")]
        public string InputBlobName { get; set; }

        /// <summary>
        /// Gets or sets the blob name to use for storing the status of the
        /// import job.
        /// </summary>
        [JsonProperty(PropertyName = "outputBlobName")]
        public string OutputBlobName { get; set; }

        /// <summary>
        /// Gets or sets specifies authentication type being used for
        /// connecting to the storage account. Possible values include:
        /// 'keyBased', 'identityBased'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets managed identity properties of storage endpoint for
        /// import devices.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether configurations should be
        /// imported.
        /// </summary>
        [JsonProperty(PropertyName = "includeConfigurations")]
        public bool? IncludeConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the blob name to be used when importing configurations
        /// from the provided input blob container.
        /// </summary>
        [JsonProperty(PropertyName = "configurationsBlobName")]
        public string ConfigurationsBlobName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InputBlobContainerUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InputBlobContainerUri");
            }
            if (OutputBlobContainerUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OutputBlobContainerUri");
            }
        }
    }
}
