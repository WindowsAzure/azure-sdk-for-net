// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translator.DocumentTranslation;

namespace Azure.AI.Translator.DocumentTranslation.Models
{
    /// <summary> Base type for List return in our api. </summary>
    internal partial class FileFormatListResult
    {
        /// <summary> Initializes a new instance of FileFormatListResult. </summary>
        /// <param name="value"> list of objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal FileFormatListResult(IEnumerable<FileFormat> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of FileFormatListResult. </summary>
        /// <param name="value"> list of objects. </param>
        internal FileFormatListResult(IReadOnlyList<FileFormat> value)
        {
            Value = value;
        }

        /// <summary> list of objects. </summary>
        public IReadOnlyList<FileFormat> Value { get; }
    }
}
