// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input directory for the job.
    /// </summary>
    public partial class InputDirectory
    {
        /// <summary>
        /// Initializes a new instance of the InputDirectory class.
        /// </summary>
        public InputDirectory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InputDirectory class.
        /// </summary>
        /// <param name="id">The id for the input directory.</param>
        /// <param name="path">The path to the input directory.</param>
        public InputDirectory(string id, string path)
        {
            Id = id;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id for the input directory.
        /// </summary>
        /// <remarks>
        /// It will be available for the job as an environment variable under
        /// AZ_BATCHAI_INPUT_id. The service will also provide the following
        /// environment variable: AZ_BATCHAI_PREV_OUTPUT_Name. The value of the
        /// variable will be populated if the job is being retried after a
        /// previous failure, otherwise it will be set to nothing.
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the path to the input directory.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}
