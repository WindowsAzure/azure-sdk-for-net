// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for access validation based on JSON Web Tokens (JWT).
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.VideoAnalyzer.JwtAuthentication")]
    public partial class JwtAuthentication : AuthenticationBase
    {
        /// <summary>
        /// Initializes a new instance of the JwtAuthentication class.
        /// </summary>
        public JwtAuthentication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JwtAuthentication class.
        /// </summary>
        /// <param name="issuers">List of expected token issuers. Token issuer
        /// is valid if it matches at least one of the given values.</param>
        /// <param name="audiences">List of expected token audiences. Token
        /// audience is valid if it matches at least one of the given
        /// values.</param>
        /// <param name="claims">List of additional token claims to be
        /// validated. Token must contains all claims and respective values for
        /// it to be valid.</param>
        /// <param name="keys">List of keys which can be used to validate
        /// access tokens. Having multiple keys allow for seamless key rotation
        /// of the token signing key. Token signature must match exactly one
        /// key.</param>
        public JwtAuthentication(IList<string> issuers = default(IList<string>), IList<string> audiences = default(IList<string>), IList<TokenClaim> claims = default(IList<TokenClaim>), IList<TokenKey> keys = default(IList<TokenKey>))
        {
            Issuers = issuers;
            Audiences = audiences;
            Claims = claims;
            Keys = keys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of expected token issuers. Token issuer is valid
        /// if it matches at least one of the given values.
        /// </summary>
        [JsonProperty(PropertyName = "issuers")]
        public IList<string> Issuers { get; set; }

        /// <summary>
        /// Gets or sets list of expected token audiences. Token audience is
        /// valid if it matches at least one of the given values.
        /// </summary>
        [JsonProperty(PropertyName = "audiences")]
        public IList<string> Audiences { get; set; }

        /// <summary>
        /// Gets or sets list of additional token claims to be validated. Token
        /// must contains all claims and respective values for it to be valid.
        /// </summary>
        [JsonProperty(PropertyName = "claims")]
        public IList<TokenClaim> Claims { get; set; }

        /// <summary>
        /// Gets or sets list of keys which can be used to validate access
        /// tokens. Having multiple keys allow for seamless key rotation of the
        /// token signing key. Token signature must match exactly one key.
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public IList<TokenKey> Keys { get; set; }

    }
}
