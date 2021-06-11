//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.IO
{
    /// <summary>
    /// This is either obtained from another method or specified as `blob:&lt;uuid&gt;` where
    /// `&lt;uuid&gt` is an UUID of a Blob.
    /// </summary>
    public readonly struct StreamHandle
        : System.IEquatable<CefNet.DevTools.Protocol.IO.StreamHandle>
    {
        private readonly string? _value;

        public StreamHandle(
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
            if (obj is StreamHandle other) return Equals(other);
            return false;
        }

        public bool Equals(
            StreamHandle other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            StreamHandle x, 
            StreamHandle y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            StreamHandle x, 
            StreamHandle y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
