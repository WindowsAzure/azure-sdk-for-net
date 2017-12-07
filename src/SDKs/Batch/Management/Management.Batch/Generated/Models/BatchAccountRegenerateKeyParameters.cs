// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the RegenerateKey operation.
    /// </summary>
    public partial class BatchAccountRegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BatchAccountRegenerateKeyParameters class.
        /// </summary>
        public BatchAccountRegenerateKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BatchAccountRegenerateKeyParameters class.
        /// </summary>
        /// <param name="keyName">The type of account key to regenerate.
        /// Possible values include: 'Primary', 'Secondary'</param>
        public BatchAccountRegenerateKeyParameters(AccountKeyType keyName)
        {
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of account key to regenerate. Possible values
        /// include: 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public AccountKeyType KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
