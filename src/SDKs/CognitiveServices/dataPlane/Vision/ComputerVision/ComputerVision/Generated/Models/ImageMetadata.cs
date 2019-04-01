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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Image metadata.
    /// </summary>
    public partial class ImageMetadata
    {
        /// <summary>
        /// Initializes a new instance of the ImageMetadata class.
        /// </summary>
        public ImageMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageMetadata class.
        /// </summary>
        /// <param name="width">Image width, in pixels.</param>
        /// <param name="height">Image height, in pixels.</param>
        /// <param name="format">Image format.</param>
        public ImageMetadata(int width = default(int), int height = default(int), string format = default(string))
        {
            Width = width;
            Height = height;
            Format = format;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets image width, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets image height, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets image format.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

    }
}
