// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extracts information from forms and images into structured data based
    /// on a model created by a set of representative training forms.
    /// </summary>
    public partial interface IFormRecognizerClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Supported Cognitive Services endpoints (protocol and hostname, for
        /// example: https://westus2.api.cognitive.microsoft.com).
        /// </summary>
        string Endpoint { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Train Model
        /// </summary>
        /// <remarks>
        /// The train request must include a source parameter that is either an
        /// externally accessible Azure Storage blob container Uri (preferably
        /// a Shared Access Signature Uri) or valid path to a data folder in a
        /// locally mounted drive. When local paths are specified, they must
        /// follow the Linux/Unix path format and be an absolute path rooted to
        /// the input mount configuration
        /// setting value e.g., if '{Mounts:Input}' configuration setting value
        /// is '/input' then a valid source path would be
        /// '/input/contosodataset'. All data to be trained are expected to be
        /// under the source. Models are trained using documents that are of
        /// the following content type - 'application/pdf', 'image/jpeg' and
        /// 'image/png'."
        /// Other content is ignored when training a model.
        /// </remarks>
        /// <param name='trainRequest'>
        /// Request object for training.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrainResult>> TrainCustomModelWithHttpMessagesAsync(TrainRequest trainRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Keys
        /// </summary>
        /// <remarks>
        /// Use the API to retrieve the keys that were
        /// extracted by the specified model.
        /// </remarks>
        /// <param name='id'>
        /// Model identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeysResult>> GetExtractedKeysWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Models
        /// </summary>
        /// <remarks>
        /// Get information about all trained models
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ModelsResult>> GetCustomModelsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Model
        /// </summary>
        /// <remarks>
        /// Get information about a model.
        /// </remarks>
        /// <param name='id'>
        /// Model identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ModelResult>> GetCustomModelWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Model
        /// </summary>
        /// <remarks>
        /// Delete model artifacts.
        /// </remarks>
        /// <param name='id'>
        /// The identifier of the model to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteCustomModelWithHttpMessagesAsync(System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Analyze Form
        /// </summary>
        /// <remarks>
        /// The document to analyze must be of a supported content type -
        /// 'application/pdf', 'image/jpeg' or 'image/png'. The response
        /// contains not just the extracted information of the analyzed form
        /// but also information about content that was not extracted along
        /// with a reason.
        /// </remarks>
        /// <param name='id'>
        /// Model Identifier to analyze the document with.
        /// </param>
        /// <param name='formStream'>
        /// A pdf document or image (jpg,png) file to analyze.
        /// </param>
        /// <param name='keys'>
        /// An optional list of known keys to extract the values for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AnalyzeResult>> AnalyzeWithCustomModelWithHttpMessagesAsync(System.Guid id, Stream formStream, IList<string> keys = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
