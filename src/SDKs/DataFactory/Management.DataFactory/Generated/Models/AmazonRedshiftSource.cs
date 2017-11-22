// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity source for Amazon Redshift Source.
    /// </summary>
    public partial class AmazonRedshiftSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the AmazonRedshiftSource class.
        /// </summary>
        public AmazonRedshiftSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmazonRedshiftSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="query">Database query. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="redshiftUnloadSettings">The Amazon S3 settings needed
        /// for the interim Amazon S3 when copying from Amazon Redshift with
        /// unload. With this, data from Amazon Redshift source will be
        /// unloaded into S3 first and then copied into the targeted sink from
        /// the interim S3.</param>
        public AmazonRedshiftSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object query = default(object), RedshiftUnloadSettings redshiftUnloadSettings = default(RedshiftUnloadSettings))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait)
        {
            Query = query;
            RedshiftUnloadSettings = redshiftUnloadSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database query. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the Amazon S3 settings needed for the interim Amazon
        /// S3 when copying from Amazon Redshift with unload. With this, data
        /// from Amazon Redshift source will be unloaded into S3 first and then
        /// copied into the targeted sink from the interim S3.
        /// </summary>
        [JsonProperty(PropertyName = "redshiftUnloadSettings")]
        public RedshiftUnloadSettings RedshiftUnloadSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RedshiftUnloadSettings != null)
            {
                RedshiftUnloadSettings.Validate();
            }
        }
    }
}
