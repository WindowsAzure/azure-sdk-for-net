// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The frequency at which the product will be billed. </summary>
    public readonly partial struct BillingFrequency : IEquatable<BillingFrequency>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="BillingFrequency"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneTimeValue = "OneTime";
        private const string MonthlyValue = "Monthly";
        private const string UsageBasedValue = "UsageBased";

        /// <summary> OneTime. </summary>
        public static BillingFrequency OneTime { get; } = new BillingFrequency(OneTimeValue);
        /// <summary> Monthly. </summary>
        public static BillingFrequency Monthly { get; } = new BillingFrequency(MonthlyValue);
        /// <summary> UsageBased. </summary>
        public static BillingFrequency UsageBased { get; } = new BillingFrequency(UsageBasedValue);
        /// <summary> Determines if two <see cref="BillingFrequency"/> values are the same. </summary>
        public static bool operator ==(BillingFrequency left, BillingFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingFrequency"/> values are not the same. </summary>
        public static bool operator !=(BillingFrequency left, BillingFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BillingFrequency"/>. </summary>
        public static implicit operator BillingFrequency(string value) => new BillingFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
