// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies how the Batch service should respond when the task completes.
    /// </summary>
    public partial class ExitConditions
    {
        /// <summary>
        /// Initializes a new instance of the ExitConditions class.
        /// </summary>
        public ExitConditions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExitConditions class.
        /// </summary>
        /// <param name="exitCodes">A list of individual task exit codes and
        /// how the Batch service should respond to them.</param>
        /// <param name="exitCodeRanges">A list of task exit code ranges and
        /// how the Batch service should respond to them.</param>
        /// <param name="preProcessingError">How the Batch service should
        /// respond if the task fails to start due to an error.</param>
        /// <param name="fileUploadError">How the Batch service should respond
        /// if a file upload error occurs.</param>
        /// <param name="defaultProperty">How the Batch service should respond
        /// if the task fails with an exit condition not covered by any of the
        /// other properties.</param>
        public ExitConditions(IList<ExitCodeMapping> exitCodes = default(IList<ExitCodeMapping>), IList<ExitCodeRangeMapping> exitCodeRanges = default(IList<ExitCodeRangeMapping>), ExitOptions preProcessingError = default(ExitOptions), ExitOptions fileUploadError = default(ExitOptions), ExitOptions defaultProperty = default(ExitOptions))
        {
            ExitCodes = exitCodes;
            ExitCodeRanges = exitCodeRanges;
            PreProcessingError = preProcessingError;
            FileUploadError = fileUploadError;
            DefaultProperty = defaultProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of individual task exit codes and how the Batch
        /// service should respond to them.
        /// </summary>
        [JsonProperty(PropertyName = "exitCodes")]
        public IList<ExitCodeMapping> ExitCodes { get; set; }

        /// <summary>
        /// Gets or sets a list of task exit code ranges and how the Batch
        /// service should respond to them.
        /// </summary>
        [JsonProperty(PropertyName = "exitCodeRanges")]
        public IList<ExitCodeRangeMapping> ExitCodeRanges { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task fails
        /// to start due to an error.
        /// </summary>
        [JsonProperty(PropertyName = "preProcessingError")]
        public ExitOptions PreProcessingError { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if a file upload
        /// error occurs.
        /// </summary>
        /// <remarks>
        /// If the task exited with an exit code that was specified via
        /// exitCodes or exitCodeRanges, and then encountered a file upload
        /// error, then the action specified by the exit code takes precedence.
        /// </remarks>
        [JsonProperty(PropertyName = "fileUploadError")]
        public ExitOptions FileUploadError { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task fails
        /// with an exit condition not covered by any of the other properties.
        /// </summary>
        /// <remarks>
        /// This value is used if the task exits with any nonzero exit code not
        /// listed in the exitCodes or exitCodeRanges collection, with a
        /// pre-processing error if the preProcessingError property is not
        /// present, or with a file upload error if the fileUploadError
        /// property is not present. If you want non-default behaviour on exit
        /// code 0, you must list it explicitly using the exitCodes or
        /// exitCodeRanges collection.
        /// </remarks>
        [JsonProperty(PropertyName = "default")]
        public ExitOptions DefaultProperty { get; set; }

    }
}
