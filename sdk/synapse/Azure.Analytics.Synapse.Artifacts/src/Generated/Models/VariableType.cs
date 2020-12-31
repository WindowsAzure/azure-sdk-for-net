// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Variable type. </summary>
    public readonly partial struct VariableType : IEquatable<VariableType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VariableType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VariableType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "String";
        private const string BoolValue = "Bool";
        private const string BooleanValue = "Boolean";
        private const string ArrayValue = "Array";

        /// <summary> String. </summary>
        public static VariableType String { get; } = new VariableType(StringValue);
        /// <summary> Bool. </summary>
        public static VariableType Bool { get; } = new VariableType(BoolValue);
        /// <summary> Boolean. </summary>
        public static VariableType Boolean { get; } = new VariableType(BooleanValue);
        /// <summary> Array. </summary>
        public static VariableType Array { get; } = new VariableType(ArrayValue);
        /// <summary> Determines if two <see cref="VariableType"/> values are the same. </summary>
        public static bool operator ==(VariableType left, VariableType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VariableType"/> values are not the same. </summary>
        public static bool operator !=(VariableType left, VariableType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VariableType"/>. </summary>
        public static implicit operator VariableType(string value) => new VariableType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VariableType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VariableType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
