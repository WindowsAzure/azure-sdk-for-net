// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents resource specific settings
    /// </summary>
    public partial class ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSettings class.
        /// </summary>
        public ResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSettings class.
        /// </summary>
        /// <param name="referenceVm">Details specific to Reference Vm</param>
        /// <param name="id">The unique id of the resource setting</param>
        /// <param name="galleryImageResourceId">The resource id of the gallery
        /// image used for creating the virtual machine</param>
        /// <param name="imageName">The name of the image used to created the
        /// environment setting</param>
        /// <param name="size">The size of the virtual machine. Possible values
        /// include: 'Basic', 'Standard', 'Performance'</param>
        /// <param name="cores">The translated compute cores of the virtual
        /// machine</param>
        public ResourceSettings(ReferenceVm referenceVm, string id = default(string), string galleryImageResourceId = default(string), string imageName = default(string), string size = default(string), int? cores = default(int?))
        {
            Id = id;
            GalleryImageResourceId = galleryImageResourceId;
            ImageName = imageName;
            Size = size;
            Cores = cores;
            ReferenceVm = referenceVm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the unique id of the resource setting
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the resource id of the gallery image used for creating
        /// the virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "galleryImageResourceId")]
        public string GalleryImageResourceId { get; set; }

        /// <summary>
        /// Gets the name of the image used to created the environment setting
        /// </summary>
        [JsonProperty(PropertyName = "imageName")]
        public string ImageName { get; private set; }

        /// <summary>
        /// Gets or sets the size of the virtual machine. Possible values
        /// include: 'Basic', 'Standard', 'Performance'
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets the translated compute cores of the virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public int? Cores { get; private set; }

        /// <summary>
        /// Gets or sets details specific to Reference Vm
        /// </summary>
        [JsonProperty(PropertyName = "referenceVm")]
        public ReferenceVm ReferenceVm { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReferenceVm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReferenceVm");
            }
            if (ReferenceVm != null)
            {
                ReferenceVm.Validate();
            }
        }
    }
}
