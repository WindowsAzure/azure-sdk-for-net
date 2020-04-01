// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Azure Synapse secure string definition. The string value will be masked with asterisks &apos;*&apos; during Get or List API calls. </summary>
    public partial class SecureString : SecretBase
    {
        /// <summary> Initializes a new instance of SecureString. </summary>
        /// <param name="value"> Value of secure string. </param>
        public SecureString(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            Type = "SecureString";
        }

        /// <summary> Initializes a new instance of SecureString. </summary>
        /// <param name="type"> Type of the secret. </param>
        /// <param name="value"> Value of secure string. </param>
        internal SecureString(string type, string value) : base(type)
        {
            Value = value;
            Type = type ?? "SecureString";
        }

        /// <summary> Value of secure string. </summary>
        public string Value { get; set; }
    }
}
