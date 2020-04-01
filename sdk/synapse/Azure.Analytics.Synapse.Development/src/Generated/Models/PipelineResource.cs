// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Pipeline resource type. </summary>
    public partial class PipelineResource : SubResource, IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of PipelineResource. </summary>
        public PipelineResource()
        {
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of PipelineResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="description"> The description of the pipeline. </param>
        /// <param name="activities"> List of activities in pipeline. </param>
        /// <param name="parameters"> List of parameters for pipeline. </param>
        /// <param name="variables"> List of variables for pipeline. </param>
        /// <param name="concurrency"> The max number of concurrent runs for the pipeline. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Pipeline. </param>
        /// <param name="runDimensions"> Dimensions emitted by Pipeline. </param>
        /// <param name="folder"> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </param>
        /// <param name="additionalProperties"> . </param>
        internal PipelineResource(string id, string name, string type, string etag, string description, IList<Activity> activities, IDictionary<string, ParameterSpecification> parameters, IDictionary<string, VariableSpecification> variables, int? concurrency, IList<object> annotations, IDictionary<string, object> runDimensions, PipelineFolder folder, IDictionary<string, object> additionalProperties) : base(id, name, type, etag)
        {
            Description = description;
            Activities = activities;
            Parameters = parameters;
            Variables = variables;
            Concurrency = concurrency;
            Annotations = annotations;
            RunDimensions = runDimensions;
            Folder = folder;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> The description of the pipeline. </summary>
        public string Description { get; set; }
        /// <summary> List of activities in pipeline. </summary>
        public IList<Activity> Activities { get; set; }
        /// <summary> List of parameters for pipeline. </summary>
        public IDictionary<string, ParameterSpecification> Parameters { get; set; }
        /// <summary> List of variables for pipeline. </summary>
        public IDictionary<string, VariableSpecification> Variables { get; set; }
        /// <summary> The max number of concurrent runs for the pipeline. </summary>
        public int? Concurrency { get; set; }
        /// <summary> List of tags that can be used for describing the Pipeline. </summary>
        public IList<object> Annotations { get; set; }
        /// <summary> Dimensions emitted by Pipeline. </summary>
        public IDictionary<string, object> RunDimensions { get; set; }
        /// <summary> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </summary>
        public PipelineFolder Folder { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
