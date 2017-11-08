// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IP security restriction on an app.
    /// </summary>
    public partial class IpSecurityRestriction
    {
        /// <summary>
        /// Initializes a new instance of the IpSecurityRestriction class.
        /// </summary>
        public IpSecurityRestriction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpSecurityRestriction class.
        /// </summary>
        /// <param name="ipAddress">IP address the security restriction is
        /// valid for.</param>
        /// <param name="subnetMask">Subnet mask for the range of IP addresses
        /// the restriction is valid for.</param>
        public IpSecurityRestriction(string ipAddress, string subnetMask = default(string))
        {
            IpAddress = ipAddress;
            SubnetMask = subnetMask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP address the security restriction is valid for.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets subnet mask for the range of IP addresses the
        /// restriction is valid for.
        /// </summary>
        [JsonProperty(PropertyName = "subnetMask")]
        public string SubnetMask { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IpAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpAddress");
            }
        }
    }
}
