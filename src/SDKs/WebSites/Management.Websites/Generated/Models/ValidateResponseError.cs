// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error details for when validation fails.
    /// </summary>
    public partial class ValidateResponseError
    {
        /// <summary>
        /// Initializes a new instance of the ValidateResponseError class.
        /// </summary>
        public ValidateResponseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateResponseError class.
        /// </summary>
        /// <param name="code">Validation error code.</param>
        /// <param name="message">Validation error message.</param>
        public ValidateResponseError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets validation error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets validation error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
