// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Workspace data table definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Table : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="retentionInDays">The data table data retention in
        /// days, between 30 and 730. Setting this property to null will
        /// default to the workspace retention.</param>
        public Table(string id = default(string), string name = default(string), string type = default(string), int? retentionInDays = default(int?))
            : base(id, name, type)
        {
            RetentionInDays = retentionInDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data table data retention in days, between 30 and
        /// 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionInDays > 730)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RetentionInDays", 730);
            }
            if (RetentionInDays < 30)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RetentionInDays", 30);
            }
        }
    }
}
