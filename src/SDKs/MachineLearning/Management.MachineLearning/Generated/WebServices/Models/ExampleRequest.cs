// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.WebServices;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sample input data for the service's input(s).
    /// </summary>
    public partial class ExampleRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExampleRequest class.
        /// </summary>
        public ExampleRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExampleRequest class.
        /// </summary>
        /// <param name="inputs">Sample input data for the web service's
        /// input(s) given as an input name to sample input values matrix
        /// map.</param>
        /// <param name="globalParameters">Sample input data for the web
        /// service's global parameters</param>
        public ExampleRequest(IDictionary<string, IList<IList<object>>> inputs = default(IDictionary<string, IList<IList<object>>>), IDictionary<string, object> globalParameters = default(IDictionary<string, object>))
        {
            Inputs = inputs;
            GlobalParameters = globalParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sample input data for the web service's input(s) given
        /// as an input name to sample input values matrix map.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IDictionary<string, IList<IList<object>>> Inputs { get; set; }

        /// <summary>
        /// Gets or sets sample input data for the web service's global
        /// parameters
        /// </summary>
        [JsonProperty(PropertyName = "globalParameters")]
        public IDictionary<string, object> GlobalParameters { get; set; }

    }
}
