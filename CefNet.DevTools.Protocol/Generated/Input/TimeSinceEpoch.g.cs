//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Input
{
    /// <summary>
    /// UTC time in seconds, counted from January 1, 1970.
    /// </summary>
    public readonly struct TimeSinceEpoch
        : System.IEquatable<CefNet.DevTools.Protocol.Input.TimeSinceEpoch>
    {
        private readonly double _value;

        public TimeSinceEpoch(
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
            if (obj is TimeSinceEpoch other) return Equals(other);
            return false;
        }

        public bool Equals(
            TimeSinceEpoch other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            TimeSinceEpoch x, 
            TimeSinceEpoch y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            TimeSinceEpoch x, 
            TimeSinceEpoch y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
