// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary>
    /// Name of the notification hub sku
    /// Serialized Name: SkuName
    /// </summary>
    public readonly partial struct NotificationHubSkuName : IEquatable<NotificationHubSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotificationHubSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationHubSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary>
        /// Free
        /// Serialized Name: SkuName.Free
        /// </summary>
        public static NotificationHubSkuName Free { get; } = new NotificationHubSkuName(FreeValue);
        /// <summary>
        /// Basic
        /// Serialized Name: SkuName.Basic
        /// </summary>
        public static NotificationHubSkuName Basic { get; } = new NotificationHubSkuName(BasicValue);
        /// <summary>
        /// Standard
        /// Serialized Name: SkuName.Standard
        /// </summary>
        public static NotificationHubSkuName Standard { get; } = new NotificationHubSkuName(StandardValue);
        /// <summary> Determines if two <see cref="NotificationHubSkuName"/> values are the same. </summary>
        public static bool operator ==(NotificationHubSkuName left, NotificationHubSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationHubSkuName"/> values are not the same. </summary>
        public static bool operator !=(NotificationHubSkuName left, NotificationHubSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationHubSkuName"/>. </summary>
        public static implicit operator NotificationHubSkuName(string value) => new NotificationHubSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationHubSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationHubSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
