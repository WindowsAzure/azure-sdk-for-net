// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a labeling job for image data
    /// </summary>
    [Newtonsoft.Json.JsonObject("Image")]
    public partial class LabelingJobImageProperties : LabelingJobMediaProperties
    {
        /// <summary>
        /// Initializes a new instance of the LabelingJobImageProperties class.
        /// </summary>
        public LabelingJobImageProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabelingJobImageProperties class.
        /// </summary>
        /// <param name="annotationType">Annotation type of image labeling job.
        /// Possible values include: 'Classification', 'BoundingBox',
        /// 'InstanceSegmentation'</param>
        public LabelingJobImageProperties(string annotationType = default(string))
        {
            AnnotationType = annotationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets annotation type of image labeling job. Possible values
        /// include: 'Classification', 'BoundingBox', 'InstanceSegmentation'
        /// </summary>
        [JsonProperty(PropertyName = "annotationType")]
        public string AnnotationType { get; set; }

    }
}
