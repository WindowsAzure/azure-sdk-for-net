// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Text.Models
{
    /// <summary> Prompt for an answer. </summary>
    internal partial class Prompt
    {
        /// <summary> Initializes a new instance of Prompt. </summary>
        internal Prompt()
        {
        }

        /// <summary> Initializes a new instance of Prompt. </summary>
        /// <param name="displayOrder"> Index of the prompt - used in ordering of the prompts. </param>
        /// <param name="qnaId"> Qna id corresponding to the prompt - if QnaId is present, QnA object is ignored. </param>
        /// <param name="qna"> QnA - Either QnaId or QnA needs to be present in a Prompt object. </param>
        /// <param name="displayText"> Text displayed to represent a follow up question prompt. </param>
        internal Prompt(int? displayOrder, int? qnaId, QnA qna, string displayText)
        {
            DisplayOrder = displayOrder;
            QnaId = qnaId;
            Qna = qna;
            DisplayText = displayText;
        }

        /// <summary> Index of the prompt - used in ordering of the prompts. </summary>
        public int? DisplayOrder { get; }
        /// <summary> Qna id corresponding to the prompt - if QnaId is present, QnA object is ignored. </summary>
        public int? QnaId { get; }
        /// <summary> QnA - Either QnaId or QnA needs to be present in a Prompt object. </summary>
        public QnA Qna { get; }
        /// <summary> Text displayed to represent a follow up question prompt. </summary>
        public string DisplayText { get; }
    }
}
