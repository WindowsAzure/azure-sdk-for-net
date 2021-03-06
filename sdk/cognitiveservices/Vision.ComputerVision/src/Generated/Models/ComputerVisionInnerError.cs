// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details about the API request error.
    /// </summary>
    public partial class ComputerVisionInnerError
    {
        /// <summary>
        /// Initializes a new instance of the ComputerVisionInnerError class.
        /// </summary>
        public ComputerVisionInnerError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputerVisionInnerError class.
        /// </summary>
        /// <param name="code">The error code. Possible values include:
        /// 'InvalidImageFormat', 'UnsupportedMediaType', 'InvalidImageUrl',
        /// 'NotSupportedFeature', 'NotSupportedImage', 'Timeout',
        /// 'InternalServerError', 'InvalidImageSize', 'BadArgument',
        /// 'DetectFaceError', 'NotSupportedLanguage', 'InvalidThumbnailSize',
        /// 'InvalidDetails', 'InvalidModel', 'CancelledRequest',
        /// 'NotSupportedVisualFeature', 'FailedToProcess', 'Unspecified',
        /// 'StorageException'</param>
        /// <param name="message">Error message.</param>
        public ComputerVisionInnerError(string code, string message)
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error code. Possible values include:
        /// 'InvalidImageFormat', 'UnsupportedMediaType', 'InvalidImageUrl',
        /// 'NotSupportedFeature', 'NotSupportedImage', 'Timeout',
        /// 'InternalServerError', 'InvalidImageSize', 'BadArgument',
        /// 'DetectFaceError', 'NotSupportedLanguage', 'InvalidThumbnailSize',
        /// 'InvalidDetails', 'InvalidModel', 'CancelledRequest',
        /// 'NotSupportedVisualFeature', 'FailedToProcess', 'Unspecified',
        /// 'StorageException'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
