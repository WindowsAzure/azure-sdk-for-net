// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Data.Tables
{
    internal class TableInsertEntityHeaders
    {
        private readonly Response _response;
        public TableInsertEntityHeaders(Response response)
        {
            _response = response;
        }
        public string XMsVersion => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        public string PreferenceApplied => _response.Headers.TryGetValue("Preference-Applied", out string value) ? value : null;
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
    }
}
