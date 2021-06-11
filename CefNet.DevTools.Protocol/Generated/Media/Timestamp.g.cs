//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Media
{
    public readonly struct Timestamp
        : System.IEquatable<CefNet.DevTools.Protocol.Media.Timestamp>
    {
        private readonly double _value;

        public Timestamp(
            double value)
        {
            _value = value;
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public readonly double GetUnderlyingValue(
            )
        {
            return _value;
        }

        public override int GetHashCode(
            )
        {
            return (_value).GetHashCode();
        }

        public override string ToString(
            )
        {
            return GetUnderlyingValue().ToString();
        }

        public override bool Equals(
            object? obj)
        {
            if (obj is Timestamp other) return Equals(other);
            return false;
        }

        public bool Equals(
            Timestamp other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            Timestamp x, 
            Timestamp y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            Timestamp x, 
            Timestamp y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
