// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Operating system type used by the VM.
    /// Serialized Name: VMPriceOSType
    /// </summary>
    public readonly partial struct MachineLearningVmPriceOSType : IEquatable<MachineLearningVmPriceOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningVmPriceOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningVmPriceOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary>
        /// Linux
        /// Serialized Name: VMPriceOSType.Linux
        /// </summary>
        public static MachineLearningVmPriceOSType Linux { get; } = new MachineLearningVmPriceOSType(LinuxValue);
        /// <summary>
        /// Windows
        /// Serialized Name: VMPriceOSType.Windows
        /// </summary>
        public static MachineLearningVmPriceOSType Windows { get; } = new MachineLearningVmPriceOSType(WindowsValue);
        /// <summary> Determines if two <see cref="MachineLearningVmPriceOSType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningVmPriceOSType left, MachineLearningVmPriceOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningVmPriceOSType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningVmPriceOSType left, MachineLearningVmPriceOSType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningVmPriceOSType"/>. </summary>
        public static implicit operator MachineLearningVmPriceOSType(string value) => new MachineLearningVmPriceOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningVmPriceOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningVmPriceOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
