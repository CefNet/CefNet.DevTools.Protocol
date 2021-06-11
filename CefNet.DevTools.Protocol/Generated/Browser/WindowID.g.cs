//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>[Experimental] </summary>
    public readonly struct WindowID
        : System.IEquatable<CefNet.DevTools.Protocol.Browser.WindowID>
    {
        private readonly int _value;

        public WindowID(
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
            if (obj is WindowID other) return Equals(other);
            return false;
        }

        public bool Equals(
            WindowID other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            WindowID x, 
            WindowID y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            WindowID x, 
            WindowID y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
