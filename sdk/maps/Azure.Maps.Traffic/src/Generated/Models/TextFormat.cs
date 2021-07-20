// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Traffic.Models
{
    /// <summary> The TextFormat. </summary>
    public readonly partial struct TextFormat : IEquatable<TextFormat>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TextFormat"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TextFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JsonValue = "json";
        private const string XmlValue = "xml";

        /// <summary> [The JavaScript Object Notation Data Interchange Format](https://tools.ietf.org/html/rfc8259). </summary>
        public static TextFormat Json { get; } = new TextFormat(JsonValue);
        /// <summary> [The Extensible Markup Language](https://www.w3.org/TR/xml/). </summary>
        public static TextFormat Xml { get; } = new TextFormat(XmlValue);
        /// <summary> Determines if two <see cref="TextFormat"/> values are the same. </summary>
        public static bool operator ==(TextFormat left, TextFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TextFormat"/> values are not the same. </summary>
        public static bool operator !=(TextFormat left, TextFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TextFormat"/>. </summary>
        public static implicit operator TextFormat(string value) => new TextFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TextFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TextFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
