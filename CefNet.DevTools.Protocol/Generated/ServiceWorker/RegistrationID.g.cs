//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    public readonly struct RegistrationID
        : System.IEquatable<CefNet.DevTools.Protocol.ServiceWorker.RegistrationID>
    {
        private readonly string? _value;

        public RegistrationID(
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
            if (obj is RegistrationID other) return Equals(other);
            return false;
        }

        public bool Equals(
            RegistrationID other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            RegistrationID x, 
            RegistrationID y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            RegistrationID x, 
            RegistrationID y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
