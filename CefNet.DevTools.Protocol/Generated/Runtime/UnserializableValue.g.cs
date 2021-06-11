//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// Primitive value which cannot be JSON-stringified. Includes values `-0`, `NaN`, `Infinity`,
    /// `-Infinity`, and bigint literals.
    /// </summary>
    public readonly struct UnserializableValue
        : System.IEquatable<CefNet.DevTools.Protocol.Runtime.UnserializableValue>
    {
        private readonly string? _value;

        public UnserializableValue(
            string value)
        {
            _value = value;
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public readonly string GetUnderlyingValue(
            )
        {
            return _value ?? "";
        }

        public override int GetHashCode(
            )
        {
            return (_value ?? "").GetHashCode();
        }

        public override string ToString(
            )
        {
            return GetUnderlyingValue();
        }

        public override bool Equals(
            object? obj)
        {
            if (obj is UnserializableValue other) return Equals(other);
            return false;
        }

        public bool Equals(
            UnserializableValue other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            UnserializableValue x, 
            UnserializableValue y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            UnserializableValue x, 
            UnserializableValue y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
