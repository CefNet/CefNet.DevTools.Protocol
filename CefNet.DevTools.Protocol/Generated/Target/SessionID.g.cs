//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Target
{
    /// <summary>
    /// Unique identifier of attached debugging session.
    /// </summary>
    public readonly struct SessionID
        : System.IEquatable<CefNet.DevTools.Protocol.Target.SessionID>
    {
        private readonly string? _value;

        public SessionID(
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
            if (obj is SessionID other) return Equals(other);
            return false;
        }

        public bool Equals(
            SessionID other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            SessionID x, 
            SessionID y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            SessionID x, 
            SessionID y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
