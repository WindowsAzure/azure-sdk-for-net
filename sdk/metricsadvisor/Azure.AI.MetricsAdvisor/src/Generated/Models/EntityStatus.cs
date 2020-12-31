// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EntityStatus. </summary>
    internal readonly partial struct EntityStatus : IEquatable<EntityStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EntityStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntityStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string PausedValue = "Paused";

        /// <summary> Active. </summary>
        public static EntityStatus Active { get; } = new EntityStatus(ActiveValue);
        /// <summary> Paused. </summary>
        public static EntityStatus Paused { get; } = new EntityStatus(PausedValue);
        /// <summary> Determines if two <see cref="EntityStatus"/> values are the same. </summary>
        public static bool operator ==(EntityStatus left, EntityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntityStatus"/> values are not the same. </summary>
        public static bool operator !=(EntityStatus left, EntityStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EntityStatus"/>. </summary>
        public static implicit operator EntityStatus(string value) => new EntityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntityStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
