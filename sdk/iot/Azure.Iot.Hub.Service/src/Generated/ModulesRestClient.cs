// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    internal partial class ModulesRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ModulesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ModulesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            endpoint ??= new Uri("https://fully-qualified-iothubname.azure-devices.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetTwinRequest(string id, string mid)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/twins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(mid, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TwinData>> GetTwinAsync(string id, string mid, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }

            using var message = CreateGetTwinRequest(id, mid);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TwinData.DeserializeTwinData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TwinData> GetTwin(string id, string mid, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }

            using var message = CreateGetTwinRequest(id, mid);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TwinData.DeserializeTwinData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReplaceTwinRequest(string id, string mid, TwinData deviceTwinInfo, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/twins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(mid, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(deviceTwinInfo);
            request.Content = content;
            return message;
        }

        /// <summary> Replaces the tags and desired properties of a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="deviceTwinInfo"> The module twin info that will replace the existing info. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the device twin, as per RFC7232. It determines if the replace operation should be carried out. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TwinData>> ReplaceTwinAsync(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }
            if (deviceTwinInfo == null)
            {
                throw new ArgumentNullException(nameof(deviceTwinInfo));
            }

            using var message = CreateReplaceTwinRequest(id, mid, deviceTwinInfo, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TwinData.DeserializeTwinData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Replaces the tags and desired properties of a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="deviceTwinInfo"> The module twin info that will replace the existing info. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the device twin, as per RFC7232. It determines if the replace operation should be carried out. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TwinData> ReplaceTwin(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }
            if (deviceTwinInfo == null)
            {
                throw new ArgumentNullException(nameof(deviceTwinInfo));
            }

            using var message = CreateReplaceTwinRequest(id, mid, deviceTwinInfo, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TwinData.DeserializeTwinData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateTwinRequest(string id, string mid, TwinData deviceTwinInfo, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/twins/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(mid, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(deviceTwinInfo);
            request.Content = content;
            return message;
        }

        /// <summary> Updates the tags and desired properties of a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="deviceTwinInfo"> The module twin info containing the tags and desired properties to be updated. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the device twin, as per RFC7232. It determines if the update operation should be carried out. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TwinData>> UpdateTwinAsync(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }
            if (deviceTwinInfo == null)
            {
                throw new ArgumentNullException(nameof(deviceTwinInfo));
            }

            using var message = CreateUpdateTwinRequest(id, mid, deviceTwinInfo, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TwinData.DeserializeTwinData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the tags and desired properties of a module twin. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-device-twins for more information. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="deviceTwinInfo"> The module twin info containing the tags and desired properties to be updated. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the device twin, as per RFC7232. It determines if the update operation should be carried out. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TwinData> UpdateTwin(string id, string mid, TwinData deviceTwinInfo, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }
            if (deviceTwinInfo == null)
            {
                throw new ArgumentNullException(nameof(deviceTwinInfo));
            }

            using var message = CreateUpdateTwinRequest(id, mid, deviceTwinInfo, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TwinData.DeserializeTwinData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetModulesOnDeviceRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the module identities on the device. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyList<ModuleIdentity>>> GetModulesOnDeviceAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetModulesOnDeviceRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ModuleIdentity> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<ModuleIdentity> array = new List<ModuleIdentity>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ModuleIdentity.DeserializeModuleIdentity(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the module identities on the device. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<ModuleIdentity>> GetModulesOnDevice(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetModulesOnDeviceRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ModuleIdentity> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<ModuleIdentity> array = new List<ModuleIdentity>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ModuleIdentity.DeserializeModuleIdentity(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetIdentityRequest(string id, string mid)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(mid, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets a module identity on the device. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ModuleIdentity>> GetIdentityAsync(string id, string mid, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }

            using var message = CreateGetIdentityRequest(id, mid);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModuleIdentity value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ModuleIdentity.DeserializeModuleIdentity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a module identity on the device. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ModuleIdentity> GetIdentity(string id, string mid, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }

            using var message = CreateGetIdentityRequest(id, mid);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModuleIdentity value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ModuleIdentity.DeserializeModuleIdentity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateIdentityRequest(string id, string mid, ModuleIdentity module, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(mid, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(module);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates the module identity for a device in the IoT Hub. The moduleId and generationId cannot be updated by the user. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="module"> The module identity. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the module, as per RFC7232. Should not be set when creating module, but may be set when updating a module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ModuleIdentity>> CreateOrUpdateIdentityAsync(string id, string mid, ModuleIdentity module, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }
            if (module == null)
            {
                throw new ArgumentNullException(nameof(module));
            }

            using var message = CreateCreateOrUpdateIdentityRequest(id, mid, module, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ModuleIdentity value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ModuleIdentity.DeserializeModuleIdentity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates the module identity for a device in the IoT Hub. The moduleId and generationId cannot be updated by the user. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="module"> The module identity. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the module, as per RFC7232. Should not be set when creating module, but may be set when updating a module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ModuleIdentity> CreateOrUpdateIdentity(string id, string mid, ModuleIdentity module, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }
            if (module == null)
            {
                throw new ArgumentNullException(nameof(module));
            }

            using var message = CreateCreateOrUpdateIdentityRequest(id, mid, module, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ModuleIdentity value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ModuleIdentity.DeserializeModuleIdentity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteIdentityRequest(string id, string mid, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(mid, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            return message;
        }

        /// <summary> Deletes the module identity for a device in the IoT Hub. </summary>
        /// <param name="id"> The unique identifier of the deivce. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the module, as per RFC7232. The delete operation is performed only if this ETag matches the value maintained by the server, indicating that the module has not been modified since it was last retrieved. To force an unconditional delete, set If-Match to the wildcard character (*). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteIdentityAsync(string id, string mid, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }

            using var message = CreateDeleteIdentityRequest(id, mid, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the module identity for a device in the IoT Hub. </summary>
        /// <param name="id"> The unique identifier of the deivce. </param>
        /// <param name="mid"> The unique identifier of the module. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for the module, as per RFC7232. The delete operation is performed only if this ETag matches the value maintained by the server, indicating that the module has not been modified since it was last retrieved. To force an unconditional delete, set If-Match to the wildcard character (*). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteIdentity(string id, string mid, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (mid == null)
            {
                throw new ArgumentNullException(nameof(mid));
            }

            using var message = CreateDeleteIdentityRequest(id, mid, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateInvokeMethodRequest(string deviceId, string moduleId, CloudToDeviceMethodRequest directMethodRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/twins/", false);
            uri.AppendPath(deviceId, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(moduleId, true);
            uri.AppendPath("/methods", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(directMethodRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Invokes a direct method on a module of a device. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-direct-methods for more information. </summary>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="moduleId"> The unique identifier of the module. </param>
        /// <param name="directMethodRequest"> The parameters to execute a direct method on the module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<CloudToDeviceMethodResponse>> InvokeMethodAsync(string deviceId, string moduleId, CloudToDeviceMethodRequest directMethodRequest, CancellationToken cancellationToken = default)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException(nameof(deviceId));
            }
            if (moduleId == null)
            {
                throw new ArgumentNullException(nameof(moduleId));
            }
            if (directMethodRequest == null)
            {
                throw new ArgumentNullException(nameof(directMethodRequest));
            }

            using var message = CreateInvokeMethodRequest(deviceId, moduleId, directMethodRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudToDeviceMethodResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudToDeviceMethodResponse.DeserializeCloudToDeviceMethodResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Invokes a direct method on a module of a device. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-direct-methods for more information. </summary>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="moduleId"> The unique identifier of the module. </param>
        /// <param name="directMethodRequest"> The parameters to execute a direct method on the module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<CloudToDeviceMethodResponse> InvokeMethod(string deviceId, string moduleId, CloudToDeviceMethodRequest directMethodRequest, CancellationToken cancellationToken = default)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException(nameof(deviceId));
            }
            if (moduleId == null)
            {
                throw new ArgumentNullException(nameof(moduleId));
            }
            if (directMethodRequest == null)
            {
                throw new ArgumentNullException(nameof(directMethodRequest));
            }

            using var message = CreateInvokeMethodRequest(deviceId, moduleId, directMethodRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudToDeviceMethodResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudToDeviceMethodResponse.DeserializeCloudToDeviceMethodResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
