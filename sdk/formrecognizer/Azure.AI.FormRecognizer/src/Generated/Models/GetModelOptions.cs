// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> The Enum0. </summary>
    internal readonly partial struct GetModelOptions : IEquatable<GetModelOptions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="GetModelOptions"/> values are the same. </summary>
        public GetModelOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullValue = "full";
        private const string SummaryValue = "summary";

        /// <summary> full. </summary>
        public static GetModelOptions Full { get; } = new GetModelOptions(FullValue);
        /// <summary> summary. </summary>
        public static GetModelOptions Summary { get; } = new GetModelOptions(SummaryValue);
        /// <summary> Determines if two <see cref="GetModelOptions"/> values are the same. </summary>
        public static bool operator ==(GetModelOptions left, GetModelOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GetModelOptions"/> values are not the same. </summary>
        public static bool operator !=(GetModelOptions left, GetModelOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GetModelOptions"/>. </summary>
        public static implicit operator GetModelOptions(string value) => new GetModelOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GetModelOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GetModelOptions other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
