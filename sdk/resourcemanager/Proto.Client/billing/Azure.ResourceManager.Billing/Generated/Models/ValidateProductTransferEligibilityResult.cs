// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Result of the product transfer eligibility validation. </summary>
    public partial class ValidateProductTransferEligibilityResult
    {
        /// <summary> Initializes a new instance of ValidateProductTransferEligibilityResult. </summary>
        internal ValidateProductTransferEligibilityResult()
        {
        }

        /// <summary> Initializes a new instance of ValidateProductTransferEligibilityResult. </summary>
        /// <param name="isMoveEligible"> Specifies whether the transfer is eligible or not. </param>
        /// <param name="errorDetails"> Validation error details. </param>
        internal ValidateProductTransferEligibilityResult(bool? isMoveEligible, ValidateProductTransferEligibilityError errorDetails)
        {
            IsMoveEligible = isMoveEligible;
            ErrorDetails = errorDetails;
        }

        /// <summary> Specifies whether the transfer is eligible or not. </summary>
        public bool? IsMoveEligible { get; }
        /// <summary> Validation error details. </summary>
        public ValidateProductTransferEligibilityError ErrorDetails { get; }
    }
}
