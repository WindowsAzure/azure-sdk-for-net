// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight.Models
{
    using Microsoft.HDInsight;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The persisted script action for cluster.
    /// </summary>
    public partial class ScriptActionPersistedGetResponseSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ScriptActionPersistedGetResponseSpec class.
        /// </summary>
        public ScriptActionPersistedGetResponseSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ScriptActionPersistedGetResponseSpec class.
        /// </summary>
        /// <param name="name">The name of script action.</param>
        /// <param name="uri">The URI to the script.</param>
        /// <param name="parameters">The parameters for the script
        /// provided.</param>
        /// <param name="roles">The list of roles where script will be
        /// executed.</param>
        /// <param name="applicationName">The application name for the script
        /// action.</param>
        public ScriptActionPersistedGetResponseSpec(string name = default(string), string uri = default(string), string parameters = default(string), IList<string> roles = default(IList<string>), string applicationName = default(string))
        {
            Name = name;
            Uri = uri;
            Parameters = parameters;
            Roles = roles;
            ApplicationName = applicationName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of script action.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URI to the script.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the parameters for the script provided.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

        /// <summary>
        /// Gets or sets the list of roles where script will be executed.
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// Gets or sets the application name for the script action.
        /// </summary>
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }

    }
}
