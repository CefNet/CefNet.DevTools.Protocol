//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>
    /// An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API
    /// </summary>
    public readonly struct GraphObjectId
        : System.IEquatable<CefNet.DevTools.Protocol.WebAudio.GraphObjectId>
    {
        private readonly string? _value;

        public GraphObjectId(
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
            if (obj is GraphObjectId other) return Equals(other);
            return false;
        }

        public bool Equals(
            GraphObjectId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            GraphObjectId x, 
            GraphObjectId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            GraphObjectId x, 
            GraphObjectId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
