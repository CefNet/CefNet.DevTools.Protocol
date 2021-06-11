//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// [Experimental] Unique identifier of current debugger.
    /// </summary>
    public readonly struct UniqueDebuggerId
        : System.IEquatable<CefNet.DevTools.Protocol.Runtime.UniqueDebuggerId>
    {
        private readonly string? _value;

        public UniqueDebuggerId(
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
            if (obj is UniqueDebuggerId other) return Equals(other);
            return false;
        }

        public bool Equals(
            UniqueDebuggerId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            UniqueDebuggerId x, 
            UniqueDebuggerId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            UniqueDebuggerId x, 
            UniqueDebuggerId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
