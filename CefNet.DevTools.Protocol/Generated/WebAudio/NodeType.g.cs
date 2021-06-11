//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>Enum of AudioNode types</summary>
    public readonly struct NodeType
        : System.IEquatable<CefNet.DevTools.Protocol.WebAudio.NodeType>
    {
        private readonly string? _value;

        public NodeType(
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
            if (obj is NodeType other) return Equals(other);
            return false;
        }

        public bool Equals(
            NodeType other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            NodeType x, 
            NodeType y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            NodeType x, 
            NodeType y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
