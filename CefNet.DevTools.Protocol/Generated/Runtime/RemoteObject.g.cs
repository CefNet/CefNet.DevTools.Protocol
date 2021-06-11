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
    /// Mirror object referencing original JavaScript object.
    /// </summary>
    public sealed class RemoteObject
    {
        /// <summary>Object type.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectType Type { get; set; }

        /// <summary>
        /// Object subtype hint. Specified for `object` type values only.
        /// NOTE: If you change anything here, make sure to also update
        /// `subtype` in `ObjectPreview` and `PropertyPreview` below.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype? Subtype { get; set; }

        /// <summary>
        /// Object class (constructor) name. Specified for `object` type values only.
        /// </summary>
        public string? ClassName { get; set; }

        /// <summary>
        /// Remote object value in case of primitive values or JSON values (if it was requested).
        /// </summary>
        public object? Value { get; set; }

        /// <summary>
        /// Primitive value which can not be JSON-stringified does not have `value`, but gets this
        /// property.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.UnserializableValue? UnserializableValue { get; set; }

        /// <summary>String representation of the object.</summary>
        public string? Description { get; set; }

        /// <summary>
        /// Unique object identifier (for non-primitive values).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId? ObjectId { get; set; }

        /// <summary>
        /// [Experimental] Preview containing abbreviated property values. Specified for `object` type values only.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ObjectPreview? Preview { get; set; }

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Runtime.CustomPreview? CustomPreview { get; set; }
    }
}
