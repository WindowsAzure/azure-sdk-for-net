// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Text.Models
{
    /// <summary> The TextAnalyticsWarning. </summary>
    internal partial class TextAnalyticsWarning
    {
        /// <summary> Initializes a new instance of TextAnalyticsWarning. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Warning message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal TextAnalyticsWarning(WarningCodeValue code, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of TextAnalyticsWarning. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Warning message. </param>
        /// <param name="targetRef"> A JSON pointer reference indicating the target object. </param>
        internal TextAnalyticsWarning(WarningCodeValue code, string message, string targetRef)
        {
            Code = code;
            Message = message;
            TargetRef = targetRef;
        }

        /// <summary> Error code. </summary>
        public WarningCodeValue Code { get; }
        /// <summary> Warning message. </summary>
        public string Message { get; }
        /// <summary> A JSON pointer reference indicating the target object. </summary>
        public string TargetRef { get; }
    }
}
