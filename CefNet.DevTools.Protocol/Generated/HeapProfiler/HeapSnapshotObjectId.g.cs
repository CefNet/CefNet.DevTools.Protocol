//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    /// <summary>Heap snapshot object id.</summary>
    public readonly struct HeapSnapshotObjectId
        : System.IEquatable<CefNet.DevTools.Protocol.HeapProfiler.HeapSnapshotObjectId>
    {
        private readonly string? _value;

        public HeapSnapshotObjectId(
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
            if (obj is HeapSnapshotObjectId other) return Equals(other);
            return false;
        }

        public bool Equals(
            HeapSnapshotObjectId other)
        {
            return GetUnderlyingValue() == other.GetUnderlyingValue();
        }

        public static bool operator==(
            HeapSnapshotObjectId x, 
            HeapSnapshotObjectId y)
        {
            return x.GetUnderlyingValue() == y.GetUnderlyingValue();
        }

        public static bool operator!=(
            HeapSnapshotObjectId x, 
            HeapSnapshotObjectId y)
        {
            return x.GetUnderlyingValue() != y.GetUnderlyingValue();
        }
    }
}
