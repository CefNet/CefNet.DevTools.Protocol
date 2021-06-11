//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Unique script identifier.</summary>
    public readonly struct ScriptIdentifier
        : System.IEquatable<CefNet.DevTools.Protocol.Page.ScriptIdentifier>
    {
        private readonly string? _value;

        public ScriptIdentifier(
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
            if (obj is ScriptIdentifier other) return Equals(other);
            return false;
        }

        public bool Equals(
            ScriptIdentifier other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            ScriptIdentifier x, 
            ScriptIdentifier y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            ScriptIdentifier x, 
            ScriptIdentifier y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
