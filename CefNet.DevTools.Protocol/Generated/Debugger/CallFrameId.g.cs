//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Debugger
{
    /// <summary>Call frame identifier.</summary>
    public readonly struct CallFrameId
        : System.IEquatable<CefNet.DevTools.Protocol.Debugger.CallFrameId>
    {
        private readonly string? _value;

        public CallFrameId(
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
            if (obj is CallFrameId other) return Equals(other);
            return false;
        }

        public bool Equals(
            CallFrameId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            CallFrameId x, 
            CallFrameId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            CallFrameId x, 
            CallFrameId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
