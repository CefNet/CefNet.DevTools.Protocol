//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>Number of milliseconds.</summary>
    public readonly struct TimeDelta
        : System.IEquatable<CefNet.DevTools.Protocol.Runtime.TimeDelta>
    {
        private readonly double _value;

        public TimeDelta(
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
            if (obj is TimeDelta other) return Equals(other);
            return false;
        }

        public bool Equals(
            TimeDelta other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            TimeDelta x, 
            TimeDelta y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            TimeDelta x, 
            TimeDelta y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
