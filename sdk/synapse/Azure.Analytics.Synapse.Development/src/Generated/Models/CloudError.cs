// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> The object that defines the structure of an Azure Synapse error response. </summary>
    public partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        internal CloudError(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Property name/path in request associated with error. </param>
        /// <param name="details"> Array with additional error details. </param>
        internal CloudError(string code, string message, string target, IReadOnlyList<CloudError> details)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Property name/path in request associated with error. </summary>
        public string Target { get; }
        /// <summary> Array with additional error details. </summary>
        public IReadOnlyList<CloudError> Details { get; }
    }
}
