// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Geolocation.Models
{
    /// <summary> The GeographicResourceLocation. </summary>
    internal readonly partial struct GeographicResourceLocation : IEquatable<GeographicResourceLocation>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="GeographicResourceLocation"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GeographicResourceLocation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UsValue = "us";
        private const string EuValue = "eu";

        /// <summary> Used to access an Azure Maps Creator resource in the United States. </summary>
        public static GeographicResourceLocation Us { get; } = new GeographicResourceLocation(UsValue);
        /// <summary> Used to access an Azure Maps Creator resource in Europe. </summary>
        public static GeographicResourceLocation Eu { get; } = new GeographicResourceLocation(EuValue);
        /// <summary> Determines if two <see cref="GeographicResourceLocation"/> values are the same. </summary>
        public static bool operator ==(GeographicResourceLocation left, GeographicResourceLocation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GeographicResourceLocation"/> values are not the same. </summary>
        public static bool operator !=(GeographicResourceLocation left, GeographicResourceLocation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GeographicResourceLocation"/>. </summary>
        public static implicit operator GeographicResourceLocation(string value) => new GeographicResourceLocation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeographicResourceLocation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GeographicResourceLocation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
