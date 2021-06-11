//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Target
{
    public readonly struct TargetID
        : System.IEquatable<CefNet.DevTools.Protocol.Target.TargetID>
    {
        private readonly string? _value;

        public TargetID(
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
            if (obj is TargetID other) return Equals(other);
            return false;
        }

        public bool Equals(
            TargetID other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            TargetID x, 
            TargetID y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            TargetID x, 
            TargetID y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
