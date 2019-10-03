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
    /// An NFS mount point for use as a StorageTarget.
    /// </summary>
    public partial class Nfs3Target
    {
        /// <summary>
        /// Initializes a new instance of the Nfs3Target class.
        /// </summary>
        public Nfs3Target()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Nfs3Target class.
        /// </summary>
        /// <param name="target">IP or name of an NFS Storage Target host, ie:
        /// 10.0.44.44</param>
        /// <param name="usageModel">Identifies the primary usage model to be
        /// used for this storage target.   GET choices from
        /// .../usageModels</param>
        public Nfs3Target(string target = default(string), string usageModel = default(string))
        {
            Target = target;
            UsageModel = usageModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP or name of an NFS Storage Target host, ie:
        /// 10.0.44.44
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets identifies the primary usage model to be used for this
        /// storage target.   GET choices from .../usageModels
        /// </summary>
        [JsonProperty(PropertyName = "usageModel")]
        public string UsageModel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Target != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Target, "^[-.0-9a-zA-Z]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Target", "^[-.0-9a-zA-Z]+$");
                }
            }
        }
    }
}
