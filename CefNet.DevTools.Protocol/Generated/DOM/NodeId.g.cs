//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>Unique DOM node identifier.</summary>
    public readonly struct NodeId
        : System.IEquatable<CefNet.DevTools.Protocol.DOM.NodeId>
    {
        private readonly int _value;

        public NodeId(
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
            if (obj is NodeId other) return Equals(other);
            return false;
        }

        public bool Equals(
            NodeId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            NodeId x, 
            NodeId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            NodeId x, 
            NodeId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
