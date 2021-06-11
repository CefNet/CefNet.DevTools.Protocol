//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// Monotonically increasing time in seconds since an arbitrary point in the past.
    /// </summary>
    public readonly struct MonotonicTime
        : System.IEquatable<CefNet.DevTools.Protocol.Network.MonotonicTime>
    {
        private readonly double _value;

        public MonotonicTime(
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
            if (obj is MonotonicTime other) return Equals(other);
            return false;
        }

        public bool Equals(
            MonotonicTime other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            MonotonicTime x, 
            MonotonicTime y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            MonotonicTime x, 
            MonotonicTime y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
