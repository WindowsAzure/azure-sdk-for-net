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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a script action on a running cluster.
    /// </summary>
    public partial class RuntimeScriptAction
    {
        /// <summary>
        /// Initializes a new instance of the RuntimeScriptAction class.
        /// </summary>
        public RuntimeScriptAction()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuntimeScriptAction class.
        /// </summary>
        /// <param name="name">The name of the script action.</param>
        /// <param name="uri">The URI to the script.</param>
        /// <param name="roles">The list of roles where script will be
        /// executed.</param>
        /// <param name="parameters">The parameters for the script</param>
        /// <param name="applicationName">The application name of the script
        /// action, if any.</param>
        public RuntimeScriptAction(string name, string uri, IList<string> roles, string parameters = default(string), string applicationName = default(string))
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
        /// Gets or sets the name of the script action.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URI to the script.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the parameters for the script
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

        /// <summary>
        /// Gets or sets the list of roles where script will be executed.
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// Gets the application name of the script action, if any.
        /// </summary>
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
            if (Roles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Roles");
            }
        }
    }
}
