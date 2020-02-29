// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Template.Models
{
    /// <summary> Fruit. </summary>
    public readonly partial struct Fruit : IEquatable<Fruit>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Fruit"/> values are the same. </summary>
        public Fruit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppleValue = "apple";
        private const string PearValue = "pear";

        /// <summary> apple. </summary>
        public static Fruit Apple { get; } = new Fruit(AppleValue);
        /// <summary> pear. </summary>
        public static Fruit Pear { get; } = new Fruit(PearValue);
        /// <summary> Determines if two <see cref="Fruit"/> values are the same. </summary>
        public static bool operator ==(Fruit left, Fruit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Fruit"/> values are not the same. </summary>
        public static bool operator !=(Fruit left, Fruit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Fruit"/>. </summary>
        public static implicit operator Fruit(string value) => new Fruit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Fruit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Fruit other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
