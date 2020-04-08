// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response indicates that the service is not able to process the
    /// incoming request. The reason is provided in the error message.
    /// </summary>
    public partial class DataExportErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the DataExportErrorResponse class.
        /// </summary>
        public DataExportErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataExportErrorResponse class.
        /// </summary>
        /// <param name="error">The details of the error.</param>
        public DataExportErrorResponse(ErrorResponse error = default(ErrorResponse))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the details of the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

    }
}
