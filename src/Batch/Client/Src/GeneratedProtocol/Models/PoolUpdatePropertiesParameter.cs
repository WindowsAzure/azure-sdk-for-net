// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for a CloudPoolOperations.UpdateProperties request.
    /// </summary>
    public partial class PoolUpdatePropertiesParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolUpdatePropertiesParameter
        /// class.
        /// </summary>
        public PoolUpdatePropertiesParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolUpdatePropertiesParameter
        /// class.
        /// </summary>
        /// <param name="certificateReferences">A list of certificates to be
        /// installed on each compute node in the pool.</param>
        /// <param name="applicationPackageReferences">A list of application
        /// packages to be installed on each compute node in the pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the pool as metadata.</param>
        /// <param name="startTask">A task to run on each compute node as it
        /// joins the pool.</param>
        public PoolUpdatePropertiesParameter(System.Collections.Generic.IList<CertificateReference> certificateReferences, System.Collections.Generic.IList<ApplicationPackageReference> applicationPackageReferences, System.Collections.Generic.IList<MetadataItem> metadata, StartTask startTask = default(StartTask))
        {
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets a task to run on each compute node as it joins the
        /// pool.
        /// </summary>
        /// <remarks>
        /// If omitted, any existing start task is removed from the pool.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets a list of certificates to be installed on each
        /// compute node in the pool.
        /// </summary>
        /// <remarks>
        /// If you specify an empty collection, any existing certificate
        /// references are removed from the pool.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateReferences")]
        public System.Collections.Generic.IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages to be installed on
        /// each compute node in the pool.
        /// </summary>
        /// <remarks>
        /// If you specify an empty collection, any existing application
        /// packages references are removed from the pool.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationPackageReferences")]
        public System.Collections.Generic.IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool
        /// as metadata.
        /// </summary>
        /// <remarks>
        /// If you specify an empty collection, any existing metadata is
        /// removed from the pool.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CertificateReferences == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "CertificateReferences");
            }
            if (ApplicationPackageReferences == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ApplicationPackageReferences");
            }
            if (Metadata == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Metadata");
            }
            if (this.StartTask != null)
            {
                this.StartTask.Validate();
            }
            if (this.CertificateReferences != null)
            {
                foreach (var element in this.CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element1 in this.ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Metadata != null)
            {
                foreach (var element2 in this.Metadata)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
