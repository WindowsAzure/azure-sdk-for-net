// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Plan for the managed application. </summary>
    public partial class PlanAutoGenerated
    {
        /// <summary> Initializes a new instance of PlanAutoGenerated. </summary>
        /// <param name="name"> The plan name. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> The product code. </param>
        /// <param name="version"> The plan&apos;s version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="publisher"/>, <paramref name="product"/>, or <paramref name="version"/> is null. </exception>
        public PlanAutoGenerated(string name, string publisher, string product, string version)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            Name = name;
            Publisher = publisher;
            Product = product;
            Version = version;
        }

        /// <summary> Initializes a new instance of PlanAutoGenerated. </summary>
        /// <param name="name"> The plan name. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> The product code. </param>
        /// <param name="promotionCode"> The promotion code. </param>
        /// <param name="version"> The plan&apos;s version. </param>
        internal PlanAutoGenerated(string name, string publisher, string product, string promotionCode, string version)
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            Version = version;
        }

        /// <summary> The plan name. </summary>
        public string Name { get; set; }
        /// <summary> The publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> The product code. </summary>
        public string Product { get; set; }
        /// <summary> The promotion code. </summary>
        public string PromotionCode { get; set; }
        /// <summary> The plan&apos;s version. </summary>
        public string Version { get; set; }
    }
}
