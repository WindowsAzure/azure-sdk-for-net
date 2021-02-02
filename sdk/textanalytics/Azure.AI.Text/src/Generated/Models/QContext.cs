// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Text.Models
{
    /// <summary> Context object with previous QnA&apos;s information. </summary>
    internal partial class QContext
    {
        /// <summary> Initializes a new instance of QContext. </summary>
        public QContext()
        {
        }

        /// <summary> Previous QnA Id - qnaId of the top result. </summary>
        public int? PreviousQnaId { get; set; }
        /// <summary> Previous user query. </summary>
        public string PreviousUserQuery { get; set; }
    }
}
