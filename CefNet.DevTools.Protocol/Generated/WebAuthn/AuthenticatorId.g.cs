//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.WebAuthn
{
    public readonly struct AuthenticatorId
        : System.IEquatable<CefNet.DevTools.Protocol.WebAuthn.AuthenticatorId>
    {
        private readonly string? _value;

        public AuthenticatorId(
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
            if (obj is AuthenticatorId other) return Equals(other);
            return false;
        }

        public bool Equals(
            AuthenticatorId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            AuthenticatorId x, 
            AuthenticatorId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            AuthenticatorId x, 
            AuthenticatorId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
