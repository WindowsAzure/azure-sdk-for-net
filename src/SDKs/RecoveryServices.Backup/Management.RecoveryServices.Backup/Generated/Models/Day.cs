// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Day of the week.
    /// </summary>
    public partial class Day
    {
        /// <summary>
        /// Initializes a new instance of the Day class.
        /// </summary>
        public Day()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Day class.
        /// </summary>
        /// <param name="date">Date of the month</param>
        /// <param name="isLast">Whether Date is last date of month</param>
        public Day(int? date = default(int?), bool? isLast = default(bool?))
        {
            Date = date;
            IsLast = isLast;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date of the month
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public int? Date { get; set; }

        /// <summary>
        /// Gets or sets whether Date is last date of month
        /// </summary>
        [JsonProperty(PropertyName = "isLast")]
        public bool? IsLast { get; set; }

    }
}
