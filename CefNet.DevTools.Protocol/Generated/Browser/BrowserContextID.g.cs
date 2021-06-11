//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>[Experimental] </summary>
    public readonly struct BrowserContextID
        : System.IEquatable<CefNet.DevTools.Protocol.Browser.BrowserContextID>
    {
        private readonly string? _value;

        public BrowserContextID(
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
            if (obj is BrowserContextID other) return Equals(other);
            return false;
        }

        public bool Equals(
            BrowserContextID other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            BrowserContextID x, 
            BrowserContextID y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            BrowserContextID x, 
            BrowserContextID y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
