// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a search results group, such as mainline.
    /// </summary>
    public partial class RankingRankingGroup
    {
        /// <summary>
        /// Initializes a new instance of the RankingRankingGroup class.
        /// </summary>
        public RankingRankingGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RankingRankingGroup class.
        /// </summary>
        /// <param name="items">A list of search result items to display in the
        /// group.</param>
        public RankingRankingGroup(IList<RankingRankingItem> items)
        {
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of search result items to display in the group.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<RankingRankingItem> Items { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Items == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Items");
            }
            if (Items != null)
            {
                foreach (var element in Items)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
