// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> The language of the query. </summary>
    public readonly partial struct QueryLanguage : IEquatable<QueryLanguage>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="QueryLanguage"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string EnUsValue = "en-us";

        /// <summary> Query language not specified. </summary>
        public static QueryLanguage None { get; } = new QueryLanguage(NoneValue);
        /// <summary> English. </summary>
        public static QueryLanguage EnUs { get; } = new QueryLanguage(EnUsValue);
        /// <summary> Determines if two <see cref="QueryLanguage"/> values are the same. </summary>
        public static bool operator ==(QueryLanguage left, QueryLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryLanguage"/> values are not the same. </summary>
        public static bool operator !=(QueryLanguage left, QueryLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryLanguage"/>. </summary>
        public static implicit operator QueryLanguage(string value) => new QueryLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryLanguage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
