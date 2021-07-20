// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Route.Models
{
    /// <summary> The VehicleLoadType. </summary>
    public readonly partial struct VehicleLoadType : IEquatable<VehicleLoadType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VehicleLoadType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VehicleLoadType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string USHazmatClass1Value = "USHazmatClass1";
        private const string USHazmatClass2Value = "USHazmatClass2";
        private const string USHazmatClass3Value = "USHazmatClass3";
        private const string USHazmatClass4Value = "USHazmatClass4";
        private const string USHazmatClass5Value = "USHazmatClass5";
        private const string USHazmatClass6Value = "USHazmatClass6";
        private const string USHazmatClass7Value = "USHazmatClass7";
        private const string USHazmatClass8Value = "USHazmatClass8";
        private const string USHazmatClass9Value = "USHazmatClass9";
        private const string OtherHazmatExplosiveValue = "otherHazmatExplosive";
        private const string OtherHazmatGeneralValue = "otherHazmatGeneral";
        private const string OtherHazmatHarmfulToWaterValue = "otherHazmatHarmfulToWater";

        /// <summary> Explosives. </summary>
        public static VehicleLoadType USHazmatClass1 { get; } = new VehicleLoadType(USHazmatClass1Value);
        /// <summary> Compressed gas. </summary>
        public static VehicleLoadType USHazmatClass2 { get; } = new VehicleLoadType(USHazmatClass2Value);
        /// <summary> Flammable liquids. </summary>
        public static VehicleLoadType USHazmatClass3 { get; } = new VehicleLoadType(USHazmatClass3Value);
        /// <summary> Flammable solids. </summary>
        public static VehicleLoadType USHazmatClass4 { get; } = new VehicleLoadType(USHazmatClass4Value);
        /// <summary> Oxidizers. </summary>
        public static VehicleLoadType USHazmatClass5 { get; } = new VehicleLoadType(USHazmatClass5Value);
        /// <summary> Poisons. </summary>
        public static VehicleLoadType USHazmatClass6 { get; } = new VehicleLoadType(USHazmatClass6Value);
        /// <summary> Radioactive. </summary>
        public static VehicleLoadType USHazmatClass7 { get; } = new VehicleLoadType(USHazmatClass7Value);
        /// <summary> Corrosives. </summary>
        public static VehicleLoadType USHazmatClass8 { get; } = new VehicleLoadType(USHazmatClass8Value);
        /// <summary> Miscellaneous. </summary>
        public static VehicleLoadType USHazmatClass9 { get; } = new VehicleLoadType(USHazmatClass9Value);
        /// <summary> Explosives. </summary>
        public static VehicleLoadType OtherHazmatExplosive { get; } = new VehicleLoadType(OtherHazmatExplosiveValue);
        /// <summary> Miscellaneous. </summary>
        public static VehicleLoadType OtherHazmatGeneral { get; } = new VehicleLoadType(OtherHazmatGeneralValue);
        /// <summary> Harmful to water. </summary>
        public static VehicleLoadType OtherHazmatHarmfulToWater { get; } = new VehicleLoadType(OtherHazmatHarmfulToWaterValue);
        /// <summary> Determines if two <see cref="VehicleLoadType"/> values are the same. </summary>
        public static bool operator ==(VehicleLoadType left, VehicleLoadType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VehicleLoadType"/> values are not the same. </summary>
        public static bool operator !=(VehicleLoadType left, VehicleLoadType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VehicleLoadType"/>. </summary>
        public static implicit operator VehicleLoadType(string value) => new VehicleLoadType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VehicleLoadType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VehicleLoadType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
