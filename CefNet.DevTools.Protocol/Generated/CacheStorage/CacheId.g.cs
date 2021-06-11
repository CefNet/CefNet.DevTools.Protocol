//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.CacheStorage
{
    /// <summary>Unique identifier of the Cache object.</summary>
    public readonly struct CacheId
        : System.IEquatable<CefNet.DevTools.Protocol.CacheStorage.CacheId>
    {
        private readonly string? _value;

        public CacheId(
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
            if (obj is CacheId other) return Equals(other);
            return false;
        }

        public bool Equals(
            CacheId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            CacheId x, 
            CacheId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            CacheId x, 
            CacheId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
