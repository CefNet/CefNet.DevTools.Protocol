//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>Enum of AudioParam types</summary>
    public readonly struct ParamType
        : System.IEquatable<CefNet.DevTools.Protocol.WebAudio.ParamType>
    {
        private readonly string? _value;

        public ParamType(
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
            if (obj is ParamType other) return Equals(other);
            return false;
        }

        public bool Equals(
            ParamType other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            ParamType x, 
            ParamType y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            ParamType x, 
            ParamType y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
