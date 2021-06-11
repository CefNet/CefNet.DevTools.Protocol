//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>
    /// Unique DOM node identifier used to reference a node that may not have been pushed to the
    /// front-end.
    /// </summary>
    public readonly struct BackendNodeId
        : System.IEquatable<CefNet.DevTools.Protocol.DOM.BackendNodeId>
    {
        private readonly int _value;

        public BackendNodeId(
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
            if (obj is BackendNodeId other) return Equals(other);
            return false;
        }

        public bool Equals(
            BackendNodeId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            BackendNodeId x, 
            BackendNodeId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            BackendNodeId x, 
            BackendNodeId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
