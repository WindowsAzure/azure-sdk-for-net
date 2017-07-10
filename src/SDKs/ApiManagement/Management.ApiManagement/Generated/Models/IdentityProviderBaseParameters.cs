// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identity Provider Base Parameter Properties.
    /// </summary>
    public partial class IdentityProviderBaseParameters
    {
        /// <summary>
        /// Initializes a new instance of the IdentityProviderBaseParameters
        /// class.
        /// </summary>
        public IdentityProviderBaseParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityProviderBaseParameters
        /// class.
        /// </summary>
        /// <param name="type">Identity Provider Type identifier. Possible
        /// values include: 'facebook', 'google', 'microsoft', 'twitter',
        /// 'aad', 'aadB2C'</param>
        /// <param name="allowedTenants">List of Allowed Tenants when
        /// configuring Azure Active Directory login.</param>
        /// <param name="signupPolicyName">Signup Policy Name. Only applies to
        /// AAD B2C Identity Provider.</param>
        /// <param name="signinPolicyName">Signin Policy Name. Only applies to
        /// AAD B2C Identity Provider.</param>
        /// <param name="profileEditingPolicyName">Profile Editing Policy Name.
        /// Only applies to AAD B2C Identity Provider.</param>
        /// <param name="passwordResetPolicyName">Password Reset Policy Name.
        /// Only applies to AAD B2C Identity Provider.</param>
        public IdentityProviderBaseParameters(IdentityProviderType? type = default(IdentityProviderType?), IList<string> allowedTenants = default(IList<string>), string signupPolicyName = default(string), string signinPolicyName = default(string), string profileEditingPolicyName = default(string), string passwordResetPolicyName = default(string))
        {
            Type = type;
            AllowedTenants = allowedTenants;
            SignupPolicyName = signupPolicyName;
            SigninPolicyName = signinPolicyName;
            ProfileEditingPolicyName = profileEditingPolicyName;
            PasswordResetPolicyName = passwordResetPolicyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identity Provider Type identifier. Possible values
        /// include: 'facebook', 'google', 'microsoft', 'twitter', 'aad',
        /// 'aadB2C'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public IdentityProviderType? Type { get; set; }

        /// <summary>
        /// Gets or sets list of Allowed Tenants when configuring Azure Active
        /// Directory login.
        /// </summary>
        [JsonProperty(PropertyName = "allowedTenants")]
        public IList<string> AllowedTenants { get; set; }

        /// <summary>
        /// Gets or sets signup Policy Name. Only applies to AAD B2C Identity
        /// Provider.
        /// </summary>
        [JsonProperty(PropertyName = "signupPolicyName")]
        public string SignupPolicyName { get; set; }

        /// <summary>
        /// Gets or sets signin Policy Name. Only applies to AAD B2C Identity
        /// Provider.
        /// </summary>
        [JsonProperty(PropertyName = "signinPolicyName")]
        public string SigninPolicyName { get; set; }

        /// <summary>
        /// Gets or sets profile Editing Policy Name. Only applies to AAD B2C
        /// Identity Provider.
        /// </summary>
        [JsonProperty(PropertyName = "profileEditingPolicyName")]
        public string ProfileEditingPolicyName { get; set; }

        /// <summary>
        /// Gets or sets password Reset Policy Name. Only applies to AAD B2C
        /// Identity Provider.
        /// </summary>
        [JsonProperty(PropertyName = "passwordResetPolicyName")]
        public string PasswordResetPolicyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AllowedTenants != null)
            {
                if (AllowedTenants.Count > 32)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "AllowedTenants", 32);
                }
            }
            if (SignupPolicyName != null)
            {
                if (SignupPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SignupPolicyName", 1);
                }
            }
            if (SigninPolicyName != null)
            {
                if (SigninPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SigninPolicyName", 1);
                }
            }
            if (ProfileEditingPolicyName != null)
            {
                if (ProfileEditingPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ProfileEditingPolicyName", 1);
                }
            }
            if (PasswordResetPolicyName != null)
            {
                if (PasswordResetPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "PasswordResetPolicyName", 1);
                }
            }
        }
    }
}
