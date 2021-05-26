// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Rule to place restrictions on portions of the cache namespace being
    /// presented to clients.
    /// </summary>
    public partial class NfsAccessRule
    {
        /// <summary>
        /// Initializes a new instance of the NfsAccessRule class.
        /// </summary>
        public NfsAccessRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NfsAccessRule class.
        /// </summary>
        /// <param name="scope">Scope for this rule. The scope and filter
        /// determine which clients match the rule. Possible values include:
        /// 'default', 'network', 'host'</param>
        /// <param name="access">Access allowed by this rule. Possible values
        /// include: 'no', 'ro', 'rw'</param>
        /// <param name="filter">Filter applied to the scope for this rule. The
        /// filter's format depends on its scope. 'default' scope matches all
        /// clients and has no filter value. 'network' scope takes a filter in
        /// CIDR format (for example, 10.99.1.0/24). 'host' takes an IP address
        /// or fully qualified domain name as filter. If a client does not
        /// match any filter rule and there is no default rule, access is
        /// denied.</param>
        /// <param name="suid">Allow SUID semantics.</param>
        /// <param name="submountAccess">For the default policy, allow access
        /// to subdirectories under the root export. If this is set to no,
        /// clients can only mount the path '/'. If set to yes, clients can
        /// mount a deeper path, like '/a/b'.</param>
        /// <param name="rootSquash">Map root accesses to anonymousUID and
        /// anonymousGID.</param>
        /// <param name="anonymousUID">UID value that replaces 0 when
        /// rootSquash is true. 65534 will be used if not provided.</param>
        /// <param name="anonymousGID">GID value that replaces 0 when
        /// rootSquash is true. This will use the value of anonymousUID if not
        /// provided.</param>
        public NfsAccessRule(string scope, string access, string filter = default(string), bool? suid = default(bool?), bool? submountAccess = default(bool?), bool? rootSquash = default(bool?), string anonymousUID = default(string), string anonymousGID = default(string))
        {
            Scope = scope;
            Filter = filter;
            Access = access;
            Suid = suid;
            SubmountAccess = submountAccess;
            RootSquash = rootSquash;
            AnonymousUID = anonymousUID;
            AnonymousGID = anonymousGID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scope for this rule. The scope and filter determine
        /// which clients match the rule. Possible values include: 'default',
        /// 'network', 'host'
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets filter applied to the scope for this rule. The
        /// filter's format depends on its scope. 'default' scope matches all
        /// clients and has no filter value. 'network' scope takes a filter in
        /// CIDR format (for example, 10.99.1.0/24). 'host' takes an IP address
        /// or fully qualified domain name as filter. If a client does not
        /// match any filter rule and there is no default rule, access is
        /// denied.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets access allowed by this rule. Possible values include:
        /// 'no', 'ro', 'rw'
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets allow SUID semantics.
        /// </summary>
        [JsonProperty(PropertyName = "suid")]
        public bool? Suid { get; set; }

        /// <summary>
        /// Gets or sets for the default policy, allow access to subdirectories
        /// under the root export. If this is set to no, clients can only mount
        /// the path '/'. If set to yes, clients can mount a deeper path, like
        /// '/a/b'.
        /// </summary>
        [JsonProperty(PropertyName = "submountAccess")]
        public bool? SubmountAccess { get; set; }

        /// <summary>
        /// Gets or sets map root accesses to anonymousUID and anonymousGID.
        /// </summary>
        [JsonProperty(PropertyName = "rootSquash")]
        public bool? RootSquash { get; set; }

        /// <summary>
        /// Gets or sets UID value that replaces 0 when rootSquash is true.
        /// 65534 will be used if not provided.
        /// </summary>
        [JsonProperty(PropertyName = "anonymousUID")]
        public string AnonymousUID { get; set; }

        /// <summary>
        /// Gets or sets GID value that replaces 0 when rootSquash is true.
        /// This will use the value of anonymousUID if not provided.
        /// </summary>
        [JsonProperty(PropertyName = "anonymousGID")]
        public string AnonymousGID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Scope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scope");
            }
            if (Access == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Access");
            }
        }
    }
}
