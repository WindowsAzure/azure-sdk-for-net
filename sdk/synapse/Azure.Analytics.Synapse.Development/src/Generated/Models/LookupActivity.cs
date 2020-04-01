// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Lookup activity. </summary>
    public partial class LookupActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of LookupActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="source"> Dataset-specific source properties, same as copy activity source. </param>
        /// <param name="dataset"> Lookup activity dataset reference. </param>
        public LookupActivity(string name, CopySource source, DatasetReference dataset) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            Source = source;
            Dataset = dataset;
            Type = "Lookup";
        }

        /// <summary> Initializes a new instance of LookupActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="source"> Dataset-specific source properties, same as copy activity source. </param>
        /// <param name="dataset"> Lookup activity dataset reference. </param>
        /// <param name="firstRowOnly"> Whether to return first row or all rows. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        internal LookupActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, CopySource source, DatasetReference dataset, object firstRowOnly) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Source = source;
            Dataset = dataset;
            FirstRowOnly = firstRowOnly;
            Type = type ?? "Lookup";
        }

        /// <summary> Dataset-specific source properties, same as copy activity source. </summary>
        public CopySource Source { get; set; }
        /// <summary> Lookup activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary> Whether to return first row or all rows. Default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object FirstRowOnly { get; set; }
    }
}
