//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Unique frame identifier.</summary>
    public readonly struct FrameId
        : System.IEquatable<CefNet.DevTools.Protocol.Page.FrameId>
    {
        private readonly string? _value;

        public FrameId(
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
            if (obj is FrameId other) return Equals(other);
            return false;
        }

        public bool Equals(
            FrameId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            FrameId x, 
            FrameId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            FrameId x, 
            FrameId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
