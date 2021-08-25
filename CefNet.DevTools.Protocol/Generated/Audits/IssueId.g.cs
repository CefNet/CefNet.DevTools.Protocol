//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// A unique id for a DevTools inspector issue. Allows other entities (e.g.
    /// exceptions, CDP message, console messages, etc.) to reference an issue.
    /// </summary>
    public readonly struct IssueId
        : System.IEquatable<CefNet.DevTools.Protocol.Audits.IssueId>
    {
        private readonly string? _value;

        public IssueId(
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
            if (obj is IssueId other) return Equals(other);
            return false;
        }

        public bool Equals(
            IssueId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            IssueId x, 
            IssueId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            IssueId x, 
            IssueId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
