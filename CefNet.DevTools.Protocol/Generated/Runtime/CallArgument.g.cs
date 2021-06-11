//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// Represents function call argument. Either remote object id `objectId`, primitive `value`,
    /// unserializable primitive value or neither of (for undefined) them should be specified.
    /// </summary>
    public sealed class CallArgument
    {
        /// <summary>
        /// Primitive value or serializable javascript object.
        /// </summary>
        public object? Value { get; set; }

        /// <summary>
        /// Primitive value which can not be JSON-stringified.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.UnserializableValue? UnserializableValue { get; set; }

        /// <summary>Remote object handle.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId? ObjectId { get; set; }
    }
}
