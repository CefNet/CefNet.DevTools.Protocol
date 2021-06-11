//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>Unique object identifier.</summary>
    public readonly struct RemoteObjectId
        : System.IEquatable<CefNet.DevTools.Protocol.Runtime.RemoteObjectId>
    {
        private readonly string? _value;

        public RemoteObjectId(
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
            if (obj is RemoteObjectId other) return Equals(other);
            return false;
        }

        public bool Equals(
            RemoteObjectId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            RemoteObjectId x, 
            RemoteObjectId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            RemoteObjectId x, 
            RemoteObjectId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
