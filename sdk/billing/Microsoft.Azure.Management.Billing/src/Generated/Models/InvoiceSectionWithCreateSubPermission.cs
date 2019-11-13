// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Invoice section properties with create subscription permission.
    /// </summary>
    public partial class InvoiceSectionWithCreateSubPermission
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InvoiceSectionWithCreateSubPermission class.
        /// </summary>
        public InvoiceSectionWithCreateSubPermission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InvoiceSectionWithCreateSubPermission class.
        /// </summary>
        /// <param name="invoiceSectionId">Invoice Section Id.</param>
        /// <param name="invoiceSectionDisplayName">Invoice Section display
        /// name.</param>
        /// <param name="billingProfileId">Billing profile Id.</param>
        /// <param name="billingProfileDisplayName">Billing profile display
        /// name.</param>
        /// <param name="enabledAzurePlans">Enabled azure plans for the
        /// associated billing profile.</param>
        public InvoiceSectionWithCreateSubPermission(string invoiceSectionId = default(string), string invoiceSectionDisplayName = default(string), string billingProfileId = default(string), string billingProfileDisplayName = default(string), IList<AzurePlan> enabledAzurePlans = default(IList<AzurePlan>))
        {
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            EnabledAzurePlans = enabledAzurePlans;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets invoice Section Id.
        /// </summary>
        [JsonProperty(PropertyName = "invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets invoice Section display name.
        /// </summary>
        [JsonProperty(PropertyName = "invoiceSectionDisplayName")]
        public string InvoiceSectionDisplayName { get; private set; }

        /// <summary>
        /// Gets billing profile Id.
        /// </summary>
        [JsonProperty(PropertyName = "billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing profile display name.
        /// </summary>
        [JsonProperty(PropertyName = "billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets enabled azure plans for the associated billing
        /// profile.
        /// </summary>
        [JsonProperty(PropertyName = "enabledAzurePlans")]
        public IList<AzurePlan> EnabledAzurePlans { get; set; }

    }
}
