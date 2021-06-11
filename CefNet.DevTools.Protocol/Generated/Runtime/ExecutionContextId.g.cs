//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>Id of an execution context.</summary>
    public readonly struct ExecutionContextId
        : System.IEquatable<CefNet.DevTools.Protocol.Runtime.ExecutionContextId>
    {
        private readonly int _value;

        public ExecutionContextId(
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
            if (obj is ExecutionContextId other) return Equals(other);
            return false;
        }

        public bool Equals(
            ExecutionContextId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            ExecutionContextId x, 
            ExecutionContextId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            ExecutionContextId x, 
            ExecutionContextId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
