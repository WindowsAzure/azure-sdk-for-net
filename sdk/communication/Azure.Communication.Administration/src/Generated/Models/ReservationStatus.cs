// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Administration.Models
{
    /// <summary> The status of the search. </summary>
    public readonly partial struct ReservationStatus : IEquatable<ReservationStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReservationStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string InProgressValue = "InProgress";
        private const string ReservedValue = "Reserved";
        private const string ExpiredValue = "Expired";
        private const string ExpiringValue = "Expiring";
        private const string CompletingValue = "Completing";
        private const string RefreshingValue = "Refreshing";
        private const string SuccessValue = "Success";
        private const string ManualValue = "Manual";
        private const string CancelledValue = "Cancelled";
        private const string CancellingValue = "Cancelling";
        private const string ErrorValue = "Error";
        private const string PurchasePendingValue = "PurchasePending";

        /// <summary> Pending. </summary>
        public static ReservationStatus Pending { get; } = new ReservationStatus(PendingValue);
        /// <summary> InProgress. </summary>
        public static ReservationStatus InProgress { get; } = new ReservationStatus(InProgressValue);
        /// <summary> Reserved. </summary>
        public static ReservationStatus Reserved { get; } = new ReservationStatus(ReservedValue);
        /// <summary> Expired. </summary>
        public static ReservationStatus Expired { get; } = new ReservationStatus(ExpiredValue);
        /// <summary> Expiring. </summary>
        public static ReservationStatus Expiring { get; } = new ReservationStatus(ExpiringValue);
        /// <summary> Completing. </summary>
        public static ReservationStatus Completing { get; } = new ReservationStatus(CompletingValue);
        /// <summary> Refreshing. </summary>
        public static ReservationStatus Refreshing { get; } = new ReservationStatus(RefreshingValue);
        /// <summary> Success. </summary>
        public static ReservationStatus Success { get; } = new ReservationStatus(SuccessValue);
        /// <summary> Manual. </summary>
        public static ReservationStatus Manual { get; } = new ReservationStatus(ManualValue);
        /// <summary> Cancelled. </summary>
        public static ReservationStatus Cancelled { get; } = new ReservationStatus(CancelledValue);
        /// <summary> Cancelling. </summary>
        public static ReservationStatus Cancelling { get; } = new ReservationStatus(CancellingValue);
        /// <summary> Error. </summary>
        public static ReservationStatus Error { get; } = new ReservationStatus(ErrorValue);
        /// <summary> PurchasePending. </summary>
        public static ReservationStatus PurchasePending { get; } = new ReservationStatus(PurchasePendingValue);
        /// <summary> Determines if two <see cref="ReservationStatus"/> values are the same. </summary>
        public static bool operator ==(ReservationStatus left, ReservationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationStatus"/> values are not the same. </summary>
        public static bool operator !=(ReservationStatus left, ReservationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationStatus"/>. </summary>
        public static implicit operator ReservationStatus(string value) => new ReservationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
