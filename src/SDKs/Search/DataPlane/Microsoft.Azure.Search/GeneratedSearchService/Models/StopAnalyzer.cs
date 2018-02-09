// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Divides text at non-letters; Applies the lowercase and stopword token
    /// filters. This analyzer is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/StopAnalyzer.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.StopAnalyzer")]
    public partial class StopAnalyzer : Analyzer
    {
        /// <summary>
        /// Initializes a new instance of the StopAnalyzer class.
        /// </summary>
        public StopAnalyzer() { }

        /// <summary>
        /// Initializes a new instance of the StopAnalyzer class.
        /// </summary>
        /// <param name="name">The name of the analyzer. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start and
        /// end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="stopwords">A list of stopwords.</param>
        public StopAnalyzer(string name, IList<string> stopwords = default(IList<string>))
            : base(name)
        {
            Stopwords = stopwords;
        }

        /// <summary>
        /// Gets or sets a list of stopwords.
        /// </summary>
        [JsonProperty(PropertyName = "stopwords")]
        public IList<string> Stopwords { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

