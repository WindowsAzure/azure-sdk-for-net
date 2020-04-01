// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> Specify the credential type (key or cert) is used for service principal. </summary>
    public readonly partial struct ODataAadServicePrincipalCredentialType : IEquatable<ODataAadServicePrincipalCredentialType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ODataAadServicePrincipalCredentialType"/> values are the same. </summary>
        public ODataAadServicePrincipalCredentialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServicePrincipalKeyValue = "ServicePrincipalKey";
        private const string ServicePrincipalCertValue = "ServicePrincipalCert";

        /// <summary> ServicePrincipalKey. </summary>
        public static ODataAadServicePrincipalCredentialType ServicePrincipalKey { get; } = new ODataAadServicePrincipalCredentialType(ServicePrincipalKeyValue);
        /// <summary> ServicePrincipalCert. </summary>
        public static ODataAadServicePrincipalCredentialType ServicePrincipalCert { get; } = new ODataAadServicePrincipalCredentialType(ServicePrincipalCertValue);
        /// <summary> Determines if two <see cref="ODataAadServicePrincipalCredentialType"/> values are the same. </summary>
        public static bool operator ==(ODataAadServicePrincipalCredentialType left, ODataAadServicePrincipalCredentialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ODataAadServicePrincipalCredentialType"/> values are not the same. </summary>
        public static bool operator !=(ODataAadServicePrincipalCredentialType left, ODataAadServicePrincipalCredentialType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ODataAadServicePrincipalCredentialType"/>. </summary>
        public static implicit operator ODataAadServicePrincipalCredentialType(string value) => new ODataAadServicePrincipalCredentialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ODataAadServicePrincipalCredentialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ODataAadServicePrincipalCredentialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
