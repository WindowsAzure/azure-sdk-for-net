// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used to regenerate the storage account key.
    /// </summary>
    public partial class StorageAccountRegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountRegenerateKeyParameters class.
        /// </summary>
        public StorageAccountRegenerateKeyParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountRegenerateKeyParameters class.
        /// </summary>
        /// <param name="keyName">The name of storage keys that want to be
        /// regenerated, possible vaules are key1, key2.</param>
        public StorageAccountRegenerateKeyParameters(string keyName)
        {
            KeyName = keyName;
        }

        /// <summary>
        /// Gets or sets the name of storage keys that want to be regenerated,
        /// possible vaules are key1, key2.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyName");
            }
        }
    }
}

