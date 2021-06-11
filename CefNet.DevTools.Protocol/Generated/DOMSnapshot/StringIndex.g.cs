//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>
    /// Index of the string in the strings table.
    /// </summary>
    public readonly struct StringIndex
        : System.IEquatable<CefNet.DevTools.Protocol.DOMSnapshot.StringIndex>
    {
        private readonly int _value;

        public StringIndex(
            int value)
        {
            _value = value;
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public readonly int GetUnderlyingValue(
            )
        {
            return _value;
        }

        public override int GetHashCode(
            )
        {
            return _value;
        }

        public override string ToString(
            )
        {
            return GetUnderlyingValue().ToString();
        }

        public override bool Equals(
            object? obj)
        {
            if (obj is StringIndex other) return Equals(other);
            return false;
        }

        public bool Equals(
            StringIndex other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            StringIndex x, 
            StringIndex y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            StringIndex x, 
            StringIndex y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
